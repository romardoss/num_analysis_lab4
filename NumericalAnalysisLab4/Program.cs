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
            Console.Write("Значення функцiї за даних аргументiв: ");
            Print.Array(Function.GetFunctionValues());
            Console.WriteLine();
            Equation.PrintMainEquation();

            Console.WriteLine();
            Console.WriteLine("Отриманi коефiцiєнти багаточлену Лагранжа:");
            Function.CalculateAndPrintY1234Values();

            Console.WriteLine();
            Console.WriteLine("Результати методу Лагранжа, якщо туди пiдставити значення iксiв:");
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(Print.Number(Function.PolynomValue(i)));
            }
        }
    }
}
