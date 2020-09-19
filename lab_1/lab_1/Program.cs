using System;

namespace lab_1
{
    class Program
    {   
        static void enterVariable(out double variable, char name)
        {
            Console.Write($"Введите пожалуста {name}: ");
            variable = Convert.ToInt32(Console.ReadLine());     
        }

        static double calculateVolume(double height, Double radius) => (Math.PI * radius * radius * height);

        static void Main(string[] args)
        {
            double height, radius;
            Console.WriteLine("Программа вичисления обьема цилиндра до завдання 6!!!");

            enterVariable(out height, 'H');
            enterVariable(out radius, 'R');

            Console.WriteLine("Обьем цилиндра по заданих параметрах равен -> " + calculateVolume(height, radius));
            Console.ReadKey();
        }
    }
}
