namespace MaxSubArraySum
{
    public class MaxSubArraySumTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 10)]
        [InlineData(new int[] { -1, -2, -3, -4 }, -1)]
        [InlineData(new int[] { -1, -2, 1, 2 }, 3)]
        [InlineData(new int[] { 1, 2, -1, -2 }, 3)]
        public void DefaultSumTest(int[] param, int result) => Assert.Equal(result, MaxSubArraySumLib.MaxSubArraySum.DefaultSum(param));

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 10)]
        [InlineData(new int[] { -1, -2, -3, -4 }, -1)]
        [InlineData(new int[] { -1, -2, 1, 2 }, 3)]
        [InlineData(new int[] { 1, 2, -1, -2 }, 3)]
        public void KadeneSumTest(int[] param, int result) => Assert.Equal(result, MaxSubArraySumLib.MaxSubArraySum.KadeneSum(param));
    }
}