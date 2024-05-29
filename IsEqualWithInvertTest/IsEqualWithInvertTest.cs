using IsEqualWithInvertLib;

namespace IsEqualWithInvertTest
{
    public class IsEqualWithInvertTest
    {
        [Theory]
        [InlineData(new int[] { 832, 998, 148, 570, 533, 561, 894, 147, 455, 279 }, new int[] { 832, 570, 148, 998, 533, 561, 455, 147, 894, 279 }, false)]
        [InlineData(new int[] { 1, 2, 1, 2 }, new int[] { 2, 2, 1, 1 }, true)]
        public void Calculate(int[] a, int[] b, bool result) => Assert.Equal(result, IsEqualWithInvert.Solution(a, b));

    }
}