using System;
using System.Diagnostics;

namespace LeetCode.Tests.Helpers
{
    public static class StopwatchHelper
    {
        public static (TResult result, TimeSpan timeElapsed) RunWithStopwatch<TResult>(Func<TResult> func)
        {
            var sw = new Stopwatch();
            sw.Start();

            var result = func();
            
            sw.Stop();

            return (result, sw.Elapsed);
        }
    }
}