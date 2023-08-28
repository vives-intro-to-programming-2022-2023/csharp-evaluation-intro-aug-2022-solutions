using ThatsASmallNumber;
using System;
using Xunit;
using System.Linq;

namespace Tests
{
    public class UnitTestsArrayHelper
    {
        ArrayHelper helper = new ArrayHelper();

        [Fact]
        public void TestValueEmptyArray()
        {
            Assert.Equal(0, helper.SmallestValue(null));
            Assert.Equal(0, helper.SmallestValue(new int[] { }));
        }

        [Fact]
        public void TestIndexEmptyArray()
        {
            Assert.Equal(-1, helper.SmallestIndex(null));
            Assert.Equal(-1, helper.SmallestIndex(new int[] { }));
        }

        [Fact]
        public void TestValuesBasic()
        {
            Assert.Equal(0, helper.SmallestValue(new int[] { 0, 1, 2, 3, 4, 5 }));
            Assert.Equal(0, helper.SmallestValue(new int[] { 12, 634, 1, 0, 3 }));
            Assert.Equal(-4, helper.SmallestValue(new int[] { 123, 2, 33, 21, -4 }));
            Assert.Equal(-1, helper.SmallestValue(new int[] { 943, 2, 53, -1, 99 }));
            Assert.Equal(19, helper.SmallestValue(new int[] { 19, 32, 324, 5324 }));
            Assert.Equal(-1233, helper.SmallestValue(new int[] { 0, -1233, 1233, 23, 55 }));
            Assert.Equal(190, helper.SmallestValue(new int[] { 1223, 18320, 5555, 190 }));
        }

        [Fact]
        public void TestIndexBasic()
        {
            Assert.Equal(0, helper.SmallestIndex(new int[] { 0, 1, 2, 3, 4, 5 } ));
            Assert.Equal(4, helper.SmallestIndex(new int[] { 3284, 3430, 245, 1152, 28 }));
            Assert.Equal(0, helper.SmallestIndex(new int[] { 575, 4303, 5758, 4175, 5661, 3336 }));
            Assert.Equal(5, helper.SmallestIndex(new int[] { 2185, -659, 4730, 70, 9, -1190 }));
            Assert.Equal(1, helper.SmallestIndex(new int[] { 2263, -88, 4769, 2652, 1879 }));
            Assert.Equal(0, helper.SmallestIndex(new int[] { -194, 2442, 2164, -11, 3081 }));
            Assert.Equal(1, helper.SmallestIndex(new int[] { 0, -5 }));
        }
    }
}
