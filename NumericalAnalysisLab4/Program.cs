using System;

namespace NumericalAnalysisLab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function f = new();
            f.PrintX();
            Console.WriteLine();
            f.PrintFunctionValues();
        }
    }
}
