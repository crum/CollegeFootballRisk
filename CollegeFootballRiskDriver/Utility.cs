using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CollegeFootballRiskDriver
{
    internal static class Utility
    {
        internal static void WriteLine(string line)
        {
            Debug.WriteLine(line);
            Console.WriteLine(line);
        }
    }
}
