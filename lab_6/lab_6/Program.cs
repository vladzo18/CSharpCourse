﻿using System;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа к ЛБ 6!!!");
            string str;
            int whatToDo;

            Console.WriteLine("Виберите действие!!!");
            Console.WriteLine("0 - Отобразить число в обратном порядке");
            Console.WriteLine("1 - Отобразит строку в обратном порядке");
            Console.WriteLine("2 - Отобразить дробовое число в обратном порядке");
            Console.WriteLine("3 - Отобразит строку с магическим знаком в обратном порядке");
            Console.WriteLine("4 - Отобразить число в обратном порядке (рекурсив)");
            Console.WriteLine("5 - Отобразит строку в обратном порядке (рекурсив)");
            Console.WriteLine("6 - Отобразить дробовое число в обратном порядке (рекурсив)");
            Console.WriteLine("7 - Отобразит строку с магическим знаком в обратном порядке (рекурсив)");
            enterVariable(out whatToDo, "код действия");

            switch (whatToDo)
            {
                case 0:
                    enterVariable(out str, "число");
                    printStringRevers(in str);
                    break;
                case 1:
                    enterVariable(out str, "cтроку");
                    printStringRevers(in str);
                    break;
                case 2:
                    enterVariable(out str, "число с точкою");
                    printStringWithMagicSymbolRevers(in str);
                    break;
                case 3:
                    enterVariable(out str, "cтроку с точкою");
                    printStringWithMagicSymbolRevers(in str);
                    break;
                case 4:
                    enterVariable(out str, "число");
                    printStringReversRecursiv(in str);
                    break;
                case 5:
                    enterVariable(out str, "cтроку");
                    printStringReversRecursiv(in str);
                    break;
                case 6:
                    enterVariable(out str, "число с точкою");
                    printStringWithMagicSymbolReversRecursive(in str);
                    break;
                case 7:
                    enterVariable(out str, "cтроку с точкою");
                    printStringWithMagicSymbolRevers(in str);
                    break;
            }

            Console.ReadKey();
        }
        static void enterVariable(out int variable, string name)
        {
            Console.Write($"Введите {name}: ");
            variable = Convert.ToInt32(Console.ReadLine());
        }
        static void enterVariable(out string str, string name)
        {
            Console.Write($"Введите {name}: ");
            str = Console.ReadLine();
        }
        /*
         * static void swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        //task 7
        static void reverseArray(ref int[] arr)
        {
            int centrOfArray = arr.Length / 2;
            for (var i = 0; i < centrOfArray; i++)
                swap(ref arr[i], ref arr[arr.Length - (1 + i)]);
        }
        static int[] fromStringArrayToInt32(in string str)
        {
            int[] numbersFromString = new int[str.Length];
            for (var i = 0; i < str.Length; i++)
                numbersFromString[i] = (int)char.GetNumericValue(str, i);
            return numbersFromString;
        }
        //task 7
        static void reverseNumber(ref string str)
        {
            int[] numbersFromString = fromStringArrayToInt32(in str); 
            reverseArray(ref numbersFromString);
            str = String.Concat<int>(numbersFromString);
        }

        //task 7
        static void reversString(ref string str)
        {
            int centrOfString = str.Length / 2;
            for (var i = 0; i < centrOfString; i++)
                swap(ref str[i], ref str[arr.Length - (1 + i)]);
        }
        */

        //task 1,2
        static void printStringRevers(in string str)
        {
            for (var i = str.Length - 1; i >= 0; i--)
                Console.Write(str[i]);
        }
        //task 3,4
        static void printStringWithMagicSymbolRevers(in string str)
        {
            int indexOfMagicSymbol = findIndexOfMagicSymbol(in str, '.');
            for (var i = indexOfMagicSymbol - 1; i >= 0; i--)
                Console.Write(str[i]);
            Console.Write('.');
            for (var i = str.Length - 1; i > indexOfMagicSymbol; i--)
                Console.Write(str[i]);
        }
        static int findIndexOfMagicSymbol(in string str, char magicSymbol)
        {
            for (var i = 0; i < str.Length; i++)
                if (str[i] == magicSymbol)
                    return i;
            return -1;
        }
        //task 6
        static void printStringReversRecursiv(in string str) => Console.Write(Reverse(str));
        static void printStringWithMagicSymbolReversRecursive(in string str)
        {        
            string[] words = str.Split(new char[] { '.' });
            Console.Write(Reverse(words[0]));
            Console.Write('.');
            Console.Write(Reverse(words[1]));
        }
        static string Reverse(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return Reverse(str.Substring(1)) + str[0].ToString();
        }

    }
}
