using System.Diagnostics;

Stopwatch watch = Stopwatch.StartNew();

// var sol = new SolutionSimple();
var sol = new SolutionOptimized();
int max = sol.GetMaximumGenerated(100000);

watch.Stop();

Console.WriteLine("max = " + max);
Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");