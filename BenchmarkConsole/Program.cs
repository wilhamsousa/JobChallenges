// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using MaxSubArraySumLib;

var summary = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run();
