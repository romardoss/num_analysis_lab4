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

        public static double FunctionValue(double x)
        {
            //повертає значення функції в заданій точці
            return Math.Sin(x * alfa / 2) + Math.Pow(x * alfa, 1.0 / 3);
        }

        public static double[] GetFunctionValues()
        {
            //повертає масив усіх значень функції в усіх заданих значеннях аргументу
            double[] doubles = new double[X.Length];
            for(int i = 0; i < X.Length; i++)
            {
                doubles[i] = FunctionValue(X[i]);
            }
            return doubles;
        }
    }
}
