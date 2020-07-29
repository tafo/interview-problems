using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Interview.Code.Twenty.TaskScheduler
{
    public class Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TestSolution(char[] tasks, int n, int expectedResult)
        {
            var solution = new Solution();
            var result = solution.Run(tasks, n);
            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] {new[] {'A', 'B', 'A'}, 2, 4};
            yield return new object[] {new[] {'A', 'A', 'A'}, 2, 7};
            yield return new object[] {new[] {'A', 'A', 'A', 'B', 'B', 'B'}, 2, 8};
            yield return new object[] {new[] {'A', 'A', 'A', 'B', 'B', 'B'}, 0, 6};
            yield return new object[] {new[] {'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G'}, 2, 16};
            yield return new object[]
            {
                new[]
                {
                    'A', 'A', 'B', 'B', 'C', 'C', 'D', 'D', 'E', 'E', 'F', 'F', 'G', 'G', 'H', 'H', 'I', 'I', 'J', 'J',
                    'K', 'K', 'L', 'L', 'M', 'M', 'N', 'N', 'O', 'O', 'P', 'P', 'Q', 'Q', 'R', 'R', 'S', 'S', 'T', 'T',
                    'U', 'U', 'V', 'V', 'W', 'W', 'X', 'X', 'Y', 'Y', 'Z', 'Z'
                },
                2, 52
            };
        }
    }
}