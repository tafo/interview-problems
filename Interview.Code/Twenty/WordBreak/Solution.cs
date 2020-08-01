using System.Collections.Generic;

namespace Interview.Code.Twenty.WordBreak
{
    public class Solution
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var result = new List<string>();
            Trie.Alphabet = new HashSet<int>();
            var rootTrie = new Trie();
            for (var i = 0; i < wordDict.Count; i++)
            {
                rootTrie.Set(wordDict[i]).Word = wordDict[i];
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (!Trie.Alphabet.Contains(s[i])) return result;
            }

            Check(0, string.Empty);
            return result;

            void Check(int i, string sentence)
            {
                var trie = rootTrie;
                for (; i < s.Length; i++)
                {
                    trie = trie.Get(s[i]);
                    if (trie == null) return;
                    if (trie.Position == 0) continue;
                    Check(i + 1, $"{sentence} {trie.Word}");
                }

                if (trie.Position == 0) return;
                result.Add($"{sentence} {trie.Word}".TrimStart());
            }
        }

        public class Trie
        {
            public static HashSet<int> Alphabet { get; set; }
            public string Word { get; set; }
            public int LetterCode { get; set; }
            public List<Trie> Letters { get; set; }
            public int Position { get; set; }

            public Trie(int letterCode = -1)
            {
                LetterCode = letterCode;
                Letters = new List<Trie>();
            }

            public Trie Set(string word)
            {
                var trie = this;
                for (var i = 0; i < word.Length; i++)
                {
                    trie = trie.Set(word[i]);
                }

                trie.Position = 1;
                return trie;
            }

            public Trie Set(int letterCode)
            {
                for (var i = 0; i < Letters.Count; i++)
                {
                    var letter = Letters[i];
                    if (letter.LetterCode == letterCode) return letter;
                }

                var trie = new Trie(letterCode);
                Letters.Add(trie);
                Alphabet.Add(letterCode);
                return trie;
            }

            public Trie Get(int letterCode)
            {
                for (var i = 0; i < Letters.Count; i++)
                {
                    var letter = Letters[i];
                    if (letter.LetterCode == letterCode) return letter;
                }

                return null;
            }
        }
    }
}