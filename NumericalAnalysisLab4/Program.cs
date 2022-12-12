using System;

namespace NumericalAnalysisLab4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Значення аргументiв: ");
            Print.Array(Function.X);
            Console.WriteLine();
            Console.Write("Значення функції за даних аргументiв: ");
            Print.Array(Function.GetFunctionValues());
            Console.WriteLine();
            Equation.PrintMainEquation();
        }
    }
}
