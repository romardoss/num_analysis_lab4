using System;
using System.Linq;

namespace NumericalAnalysisLab4
{
    internal class Function
    {
        private static readonly int Variant = 6;
        private static readonly int k = Variant - 1;
        private static readonly int alfa = 1;
        public static readonly int[] X = { -5 + k, -3 + k, -1 + k, 1 + k, 3 + k };

        public void PrintX()
        {
            Console.WriteLine(String.Join(" ", X));
        }

        public double FunctionValue(double x)
        {
            return Math.Sin(x * alfa / 2) + Math.Pow(x * alfa, 1.0 / 3);
        }

        public double[] GetFunctionValues()
        {
            double[] doubles = new double[X.Length];
            for(int i = 0; i < X.Length; i++)
            {
                doubles[i] = FunctionValue(X[i]);
            }
            return doubles;
        }

        public void PrintFunctionValues()
        {
            Console.WriteLine(string.Join(" ", GetFunctionValues()));
        }
    }
}
