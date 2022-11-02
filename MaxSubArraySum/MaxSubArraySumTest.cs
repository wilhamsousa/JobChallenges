namespace MaxSubArraySum
{
    public class MaxSubArraySumTest
    {
        [Fact]
        public void DefaultSumTest()
        {
            Assert.Equal(10, MaxSubArraySumLib.MaxSubArraySum.DefaultSum(new int[] {1, 2, 3, 4 }));
            Assert.Equal(-1, MaxSubArraySumLib.MaxSubArraySum.DefaultSum(new int[] {-1, -2, -3, -4 }));
            Assert.Equal(3, MaxSubArraySumLib.MaxSubArraySum.DefaultSum(new int[] {-1, -2, 1, 2 }));
            Assert.Equal(3, MaxSubArraySumLib.MaxSubArraySum.DefaultSum(new int[] {1, 2, -1, -2 }));
        }

        [Fact]
        public void KadeneSumTest()
        {
            Assert.Equal(10, MaxSubArraySumLib.MaxSubArraySum.KadeneSum(new int[] { 1, 2, 3, 4 }));
            Assert.Equal(-1, MaxSubArraySumLib.MaxSubArraySum.KadeneSum(new int[] { -1, -2, -3, -4 }));
            Assert.Equal(3, MaxSubArraySumLib.MaxSubArraySum.KadeneSum(new int[] { -1, -2, 1, 2 }));
            Assert.Equal(3, MaxSubArraySumLib.MaxSubArraySum.KadeneSum(new int[] { 1, 2, -1, -2 }));
        }
    }
}