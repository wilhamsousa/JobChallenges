using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using MaxSubArraySumLib;
using Xunit.Abstractions;

namespace MaxSubArraySumTest
{
    public class MaxSubArraySumTest
    {
        public MaxSubArraySum MaxSubArraySum { get; set; }

        public MaxSubArraySumTest(ITestOutputHelper output)
        {
            this.output = output;
            MaxSubArraySum = new MaxSubArraySum();
        }

        private readonly ITestOutputHelper output;

        //[Fact]
        //public void Run_Benchmarks()
        //{
        //    var logger = new AccumulationLogger();

        //    var config = ManualConfig.Create(DefaultConfig.Instance)
        //        .AddLogger(logger)
        //        .WithOptions(ConfigOptions.DisableOptimizationsValidator);

        //    BenchmarkRunner.Run<MaxSubArraySum>(config);

        //    // write benchmark summary
        //    output.WriteLine(logger.GetLog());
        //}

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 10)]
        [InlineData(new int[] { -1, -2, -3, -4 }, -1)]
        [InlineData(new int[] { -1, -2, 1, 2 }, 3)]
        [InlineData(new int[] { 1, 2, -1, -2 }, 3)]
        [InlineData(new int[] { 1, 2, -1, -2, 1, 2, -1, -2, 1, 2, -1, -2, 1, 2, -1, -2 }, 3)]
        public void DefaultSumTest(int[] param, int result) => Assert.Equal(result, MaxSubArraySum.DefaultSum(param));

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 10)]
        [InlineData(new int[] { -1, -2, -3, -4 }, -1)]
        [InlineData(new int[] { -1, -2, 1, 2 }, 3)]
        [InlineData(new int[] { 1, 2, -1, -2 }, 3)]
        [InlineData(new int[] { 1, 2, -1, -2, 1, 2, -1, -2, 1, 2, -1, -2, 1, 2, -1, -2 }, 3)]
        public void KadeneSumTest(int[] param, int result) => Assert.Equal(result, MaxSubArraySum.KadeneSum(param));
    }
}