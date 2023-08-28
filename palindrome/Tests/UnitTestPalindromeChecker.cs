using Palindrome;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestPalindromeChecker
    {
        private PalindromeChecker checker = new PalindromeChecker();

        [Fact]
        public void TestBasics()
        {
            Assert.True(checker.IsPalindrome("racecar"));
            Assert.False(checker.IsPalindrome("house"));
            Assert.True(checker.IsPalindrome("radar"));
            Assert.False(checker.IsPalindrome("dada"));
            Assert.True(checker.IsPalindrome("1780871"));
            Assert.False(checker.IsPalindrome("123"));
            Assert.True(checker.IsPalindrome("madam"));
            Assert.False(checker.IsPalindrome("mister"));
        }

        [Fact]
        public void TestNumbers()
        {
            Assert.True(checker.IsPalindrome("1780871"));
            Assert.True(checker.IsPalindrome("603306"));
            Assert.True(checker.IsPalindrome("040"));
            Assert.False(checker.IsPalindrome("123"));
            Assert.False(checker.IsPalindrome("353453"));
            Assert.False(checker.IsPalindrome("7687687676"));
        }

        [Fact]
        public void TestCapitalLetters()
        {
            Assert.True(checker.IsPalindrome("RaceCar"));
            Assert.False(checker.IsPalindrome("HousE"));
            Assert.True(checker.IsPalindrome("raDar"));
            Assert.False(checker.IsPalindrome("dAdA"));
            Assert.True(checker.IsPalindrome("MaDAM"));
            Assert.False(checker.IsPalindrome("mister"));
        }

        [Fact]
        public void TestEmptyNullString()
        {
            Assert.False(checker.IsPalindrome(""));
            Assert.False(checker.IsPalindrome(null));
        }

        [Fact]
        public void TestSentences()
        {
            Assert.True(checker.IsPalindrome("Ah, Satan sees Natasha "));
            Assert.True(checker.IsPalindrome("Go hang a salami, I'm a lasagna hog"));
            Assert.True(checker.IsPalindrome("Mr. Owl ate my metal worm"));
            Assert.True(checker.IsPalindrome("Race fast, safe car"));
            Assert.True(checker.IsPalindrome("UFO tofu"));
            Assert.False(checker.IsPalindrome("this is not a paal droom"));
            Assert.False(checker.IsPalindrome("Who can be here now ?"));
            Assert.False(checker.IsPalindrome(" house "));
        }
    }
}
