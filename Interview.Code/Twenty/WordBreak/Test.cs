using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Interview.Code.Twenty.WordBreak
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Test
    {
        private readonly ITestOutputHelper _testOutput;

        public Test(ITestOutputHelper testOutput)
        {
            _testOutput = testOutput;
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test_Solution(string s, IList<string> dictionary, IList<string> expectation)
        {
            var timer = Stopwatch.StartNew();
            var result = new Solution().WordBreak(s, dictionary);
            timer.Stop();
            result.Should().BeEquivalentTo(expectation);
            result.ToList().ForEach(x => _testOutput.WriteLine(x));
            _testOutput.WriteLine($"{timer.ElapsedTicks} ticks");
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                new List<string>
                    {"a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaa"},
                new List<string>()
            };
            yield return new object[]
            {
                "abcd",
                new List<string> {"ab", "cd", "abc", "d"},
                new List<string> {"ab cd", "abc d"}
            };

            yield return new object[]
            {
                "catsanddog",
                new List<string> {"cat", "cats", "and", "sand", "dog"},
                new List<string> {"cats and dog", "cat sand dog"}
            };

            yield return new object[]
            {
                "pineapplepenapple",
                new List<string> {"apple", "pen", "applepen", "pine", "pineapple"},
                new List<string> {"pine apple pen apple", "pineapple pen apple", "pine applepen apple"}
            };

            yield return new object[]
            {
                "catsandog",
                new List<string> {"cat", "cats", "and", "sand", "dog", "z"},
                new List<string>()
            };
        }
    }
}