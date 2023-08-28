using AbbreviateThis;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestAbbreviator
    {
        private Abbreviator abbreviator = new Abbreviator();

        [Fact]
        public void BasicTest()
        {
            Assert.Equal("RTFM", abbreviator.Abbreviate("Read The Fucking Manual"));
            Assert.Equal("LOL", abbreviator.Abbreviate("League of Legends"));
            Assert.Equal("ROFL", abbreviator.Abbreviate("Rolling On Floor Laughing"));
            Assert.Equal("DIY", abbreviator.Abbreviate("Do It Yourself"));
            Assert.Equal("AOE", abbreviator.Abbreviate("Age Of Empires"));
            Assert.Equal("CS", abbreviator.Abbreviate("Counter Strike"));
        }

        [Fact]
        public void TestMixedCase()
        {
            Assert.Equal("RTFM", abbreviator.Abbreviate("read the fucking manual"));
            Assert.Equal("LOL", abbreviator.Abbreviate("League of Legends"));
            Assert.Equal("ROFL", abbreviator.Abbreviate("rolling On floor Laughing"));
            Assert.Equal("DIY", abbreviator.Abbreviate("do it yourself"));
            Assert.Equal("AOE", abbreviator.Abbreviate("Age of Empires"));
            Assert.Equal("CS", abbreviator.Abbreviate("counter strike"));
        }

        [Fact]
        public void TestSpecialCases()
        {
            Assert.Equal("H", abbreviator.Abbreviate("hello"));
            Assert.Equal("H", abbreviator.Abbreviate("Hello"));
            Assert.Equal("CS", abbreviator.Abbreviate("C Sharp"));
            Assert.Equal("", abbreviator.Abbreviate(""));
            Assert.Equal("", abbreviator.Abbreviate(null));
        }
    }
}
