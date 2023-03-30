using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        //test 1
        [Theory]
        [InlineData("racecar", true)]
        public void PalindromeTest1(string word, bool result)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(word);

            Assert.Equal(result, actual);
        }

        //test 2
        [Theory]
        [InlineData("guitar", false)]
        public void PalindromeTest2(string word, bool result)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(word);

            Assert.Equal(result, actual);
        }

        //test 3
        [Theory]
        [InlineData("rack", false)]
        public void PalindromeTest3(string word, bool result)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(word);

            Assert.Equal(result, actual);
        }

        //test 4
        [Theory]
        [InlineData("kayak", true)]
        public void PalindromeTest4(string word, bool result)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(word);

            Assert.Equal(result, actual);
        }
    }
}
