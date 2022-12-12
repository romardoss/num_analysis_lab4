using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalAnalysisLab4
{
    internal class Print
    {
        public static string Number(double num)
        {
            //виводить 6 значущих цифр одного числа
            string s = num.ToString();
            string answer = "";
            if (num < 0)
            {
                answer = "-";
                s = s[1..];
            }
            int k = (num >= 0) ? 6 : 5;
            if (s.Length >= k)
            {
                answer += s[..k];
            }
            else
            {
                answer += string.Concat(Enumerable.Repeat("0", k - s.Length)) + s;
            }

            if (num == 0)
            {
                return "000000";
            }
            return answer;
        }

        public static void Array(double[] arr)
        {
            //виводить на екран одновимірний масив чисел з плаваючою точкою
            string answer = "";
            for (int i = 0; i < arr.Length; i++)
            {
                answer += Number(arr[i]) + " ";
            }
            Console.WriteLine(answer + "\n");
        }

        public static void Array(int[] arr)
        {
            //виводить на екран одновимірний масив цілих чисел
            Console.Write(String.Join(" ", arr));
            Console.WriteLine();
        }
    }
}
