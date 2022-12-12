using System;
using System.Text;

namespace NumericalAnalysisLab4
{
    internal class Equation
    {
        public static string GetMainEquation()
        {
            Function f = new();
            double[] doubles = f.GetFunctionValues();
            StringBuilder builder = new();
            for(int i = 0; i < doubles.Length; i++)
            {
                builder.Append($"(x-{doubles[i]})");
            }
            builder.AppendLine();
            for (int i = 0; i < doubles.Length*2; i++)
            {
                builder.Append("---------");
            }
            builder.AppendLine();
            for (int i = 0; i < doubles.Length; i++)
            {
                builder.Append($"(xj-{doubles[i]})");
            }
            builder.AppendLine();
            return builder.ToString();
        }

        public static void PrintMainEquation()
        {
            Console.WriteLine(GetMainEquation());
        }
    }
}
