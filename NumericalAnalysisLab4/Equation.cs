using System;
using System.Text;

namespace NumericalAnalysisLab4
{
    internal class Equation
    {
        public static string GetMainEquation()
        {
            int[] doubles = Function.X;
            StringBuilder builder = new();
            builder.Append('\t');
            for(int i = 0; i < doubles.Length; i++)
            {
                builder.Append($"(x-{doubles[i]})");
            }
            builder.AppendLine();
            builder.Append("L(x) = \t");
            for (int i = 0; i < doubles.Length; i++)
            {
                builder.Append("------");
            }
            builder.AppendLine();
            builder.Append('\t');
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
