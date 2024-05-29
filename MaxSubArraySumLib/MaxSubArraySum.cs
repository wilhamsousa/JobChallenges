using BenchmarkDotNet.Attributes;

namespace MaxSubArraySumLib
{
    /// <summary>
    /// Array max consecutive sum
    /// Calculation of the subarray that results in the largest sum between the elements
    /// </summary>
    [RankColumn]
    [MemoryDiagnoser]
    public static class MaxSubArraySum
    {
        public static int DefaultSum(int[] param)
        {
            Validation(param);

            
            var maxSum = param[0];
            for (int i = 0; i < param.Length; i++)
            {
                var sum = 0;
                for (int x = i; x < param.Length; x++)
                {
                    sum += param[x];
                    if (sum > maxSum)
                        maxSum = sum;
                }
                
            }

            return maxSum;
        }

        public static int KadeneSum(int[] param)
        {
            Validation(param);

            var sum = param[0];
            var maxSum = param[0];
            for (int i = 1; i < param.Length; i++)
            {
                sum = param[i] > sum + param[i] ? param[i] : sum + param[i];
                maxSum = maxSum > sum ? maxSum : sum;
            }

            return maxSum;
        }

        private static void Validation(int[] param)
        {
            if (param.Length < 3)
                throw new Exception("< 3");

            if (param.Length > Math.Pow(10, 5))
                throw new Exception("> 10^5");

            foreach (var item in param)
                if (item < -10000 || item > 10000)
                    throw new Exception("-10000<x>+10000");
        }

        #region Benchmark
        [Benchmark]
        public static int DefaultSum()
        {
            return DefaultSum(new int[] { 1, 2, 3 });
        }

        [Benchmark]
        public static int KadeneSum()
        {
            return KadeneSum(new int[] { 1, 2, 3 });
        }
        #endregion
    }
}