// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using MaxSubArraySumLib;

BenchmarkRunner.Run<MaxSubArraySum>();
var summary = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run();
