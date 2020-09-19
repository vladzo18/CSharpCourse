using System;

namespace lab_3
{
    class Program
    {
        static void enterVariable(out sbyte variable, char xOrY, string number)
        {
            do
            {
                Console.Write($"Введите пожалуста координату {xOrY} для {number} коня: ");
                variable = Convert.ToSByte(Console.ReadLine());
                if (variable < 0 || variable > 7)
                    Console.WriteLine("Такой координати бить не может, попробуйте еще раз...");
            } while (variable < 0 || variable > 7);
        }
        static bool hourseCanGo(sbyte x1, sbyte y1, sbyte x2, sbyte y2)
        {
            if (((Math.Abs(x2-x1) == 1) && (Math.Abs(y2 - y1) == 2)) || (Math.Abs(x2 - x1) == 2) && (Math.Abs(y2 - y1) == 1))
                return true;
            else return false;
        }
        static void Main(string[] args)
        {
            sbyte xForFirstHourse, yForFirstHourse;
            sbyte xForSecondeHourse, yForSecondeHourse;

            Console.WriteLine("Проррамма к задаче 21 ЛБ 3!!!");
            Console.WriteLine("Ячейки шахматной доски нумеруются от 0 до 7!!!");

            enterVariable(out xForFirstHourse, 'x', "первого");
            enterVariable(out yForFirstHourse, 'y', "первого");
            enterVariable(out xForSecondeHourse, 'x', "второго");
            enterVariable(out yForSecondeHourse, 'y', "второго");

            if (hourseCanGo(xForFirstHourse, yForFirstHourse, xForSecondeHourse, yForSecondeHourse))
                Console.WriteLine("Ваш конь может походить так!!!");
            else Console.WriteLine("Ваш конь не может походить так!!!");

            Console.ReadKey();
        }
    }
}
