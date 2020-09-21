using System;

namespace lab_2
{
    class Program
    {
        static void enterVariable(out double variable, string name)
        {
            Console.Write($"Введите пожалуста {name}: ");
            variable = Convert.ToDouble(Console.ReadLine());
        }
        static decimal calculateFormula(double nn, double nk)
        {
            decimal result = 0;
            for (int i = (int)(nn); i <= nk; i++)
                try
                {
                    result += (decimal)((Math.Pow(-1, i * i + 1) * i * i - 2) / (3 * i * i - 2 * i));
                }
                catch { }    
            return result;
        }
        static void Main(string[] args)
        {
            double nnVariable, nkVariable;

            Console.WriteLine("Программа к зараче 6");

            enterVariable(out nnVariable, "nn");
            enterVariable(out nkVariable, "nk");

            Console.WriteLine(calculateFormula(nnVariable, nkVariable));

            Console.ReadKey();
        }
    }
}
