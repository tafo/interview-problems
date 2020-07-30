using System.Collections.Generic;
using System.Linq;

namespace Interview.Code.Twenty.WordBreak
{
    /// <summary>
    /// ToDo: Not Optimized!
    /// </summary>
    public class Solution
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var result = new List<string>();
            Trie.Alphabet = new HashSet<int>();
            var rootTrie = new Trie();
            foreach (var word in wordDict)
            {
                var lastTrie = word.Aggregate(rootTrie, (trie, letter) => trie.Set(letter));
                lastTrie.Word = word;
            }

            if (s.Any(letter => !Trie.Alphabet.Contains(letter))) return result;

            CheckWord(rootTrie, 0, new List<string>());
            return result;

            void CheckWord(Trie trie, int i, ICollection<string> words)
            {
                for (; i < s.Length; i++)
                {
                    trie = trie.Get(s[i]);
                    if (trie == null) return;
                    if (trie.Word == null) continue;
                    if (i + 1 < s.Length) CheckWord(rootTrie, i + 1, new List<string>(words) { trie.Word });
                }

                if (trie.Word == null) return;
                words.Add(trie.Word);
                result.Add(string.Join(" ", words));
            }
        }

        public class Trie
        {
            public static HashSet<int> Alphabet;
            public string Word { get; set; }
            public int LetterCode { get; set; }
            public List<Trie> Letters { get; set; }

            public Trie(int letterCode = -1)
            {
                LetterCode = letterCode;
                Letters = new List<Trie>();
            }

            public Trie Set(char letter)
            {
                var trie = Get(letter);
                if (trie != null) return trie;
                trie = new Trie(letter);
                Letters.Add(trie);
                Alphabet.Add(letter);
                return trie;
            }

            public Trie Get(char letter)
            {
                return Letters.Find(x => x.LetterCode == letter);
            }
        }
    }
}