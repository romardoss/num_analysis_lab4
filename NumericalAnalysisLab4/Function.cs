using System;

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

        public static double PolynomDefaultValue(double x)
        {
            //обчислює поліном, що ще не переведений до вигляду a0*x^4 + a1*b^3 + a2*b^2 + a3*b^2 + a4*b + a5
            double answer = 2.1013 * x * (x - 4) * (x - 6) * (x - 8) / (-96);
            answer += 2.4966 * x * (x - 2) * (x - 6) * (x - 8) / 64;
            answer += 1.9582 * x * (x - 2) * (x - 4) * (x - 8) / (-96);
            answer += 1.2431 * x * (x - 2) * (x - 4) * (x - 6) / 384;
            return answer;
        }

        public static double PolynomValue(double x)
        {
            //Обчислює значення фінального поліному
            double y1 = 2.1013;
            double y2 = 2.4966;
            double y3 = 1.9582;
            double y4 = 1.2431;
            double answer = (y1 / (-96) + y2 / 64 + y3 / (-96) + y4 / 384) * Math.Pow(x, 4);
            answer += (3 * y1 / 16 + y2 / (-4) + 7 * y3 / 48 + y4 / (-32)) * Math.Pow(x, 3);
            answer += ((-13) * y1 / 12 + 1.1875 * y2 + (-7) * y3 / 12 + 11 * y4 / 96) * Math.Pow(x, 2);
            answer += (2 * y1 - 1.5 * y2 + 2 * y3 / 3 + y4 / (-8)) * Math.Pow(x, 1);
            return answer;
        }

        public static void CalculateAndPrintY1234Values()
        {
            //Обчислює коефіцієнти поліному
            double y1 = 2.1013;
            double y2 = 2.4966;
            double y3 = 1.9582;
            double y4 = 1.2431;
            Console.WriteLine(y1 / (-96) + y2 / 64 + y3 / (-96) + y4 / 384 + " * x^4");
            Console.WriteLine(3 * y1 / 16 + y2 / (-4) + 7 * y3 / 48 + y4 / (-32) + " * x^3");
            Console.WriteLine((-13) * y1 / 12 + 1.1875 * y2 + (-7) * y3 / 12 + 11 * y4 / 96 + " * x^2");
            Console.WriteLine(2 * y1 - 1.5 * y2 + 2 * y3 / 3 + y4 / (-8) + " * x");
        }
    }
}
