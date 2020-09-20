using System;

namespace lab_5
{
    class Program
    {
        private static void enterVariable(out sbyte variable, string name)
        {
            do
            {
                Console.Write($"Введите пожалуста {name}: ");
                variable = Convert.ToSByte(Console.ReadLine());
                if (variable < 0 || variable >= 4)
                    Console.WriteLine($"{name} не может иметь такое значение");
            } while (variable < 0 || variable >= 4);
        }

        private static void randomArray(ref int[,] matrix)
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rand.Next(50);
        }

        private static void swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        private static void changeRows(ref int[,] matrix, int k1, int k2) { 
            for (int j = 0; j < matrix.GetLength(1); j++) 
                swap(ref matrix[k1, j],ref matrix[k2, j]);
        }
        private static void printMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]} ");
                Console.Write("\n");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа к задаче 21!!!");
            Console.WriteLine("Она меняет строки матрицы местам под индексами k1 и k2!!!");

            int[,] matrix = new int[4, 10];
            sbyte k1Variable, k2Variable;

            randomArray(ref matrix);

            printMatrix(matrix);

            enterVariable(out k1Variable, "k1");
            enterVariable(out k2Variable, "k1");

            changeRows(ref matrix, k1Variable, k2Variable);

            printMatrix(matrix);

            Console.ReadKey();
        }
    }
}
