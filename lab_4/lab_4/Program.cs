using System;

namespace lab_4
{
    class Program
    {
        static void choseSizeOfArray(out int size)
        {
            do
            {
                Console.Write("Введите желаемий размер массива: ");
                size = Convert.ToInt32(Console.ReadLine());
                if(size <= 1)
                    Console.WriteLine("C таким размером масива быть не может!!!");
            } while (size <= 1);
        }
        static void enterElementsOfArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Array[{i}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void deleteElementFromArray(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];
            array = newArray;
        }
        static void DeleteElementsFromArray(ref int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == element)
                {
                    deleteElementFromArray(ref array, i);
                    i--;
                }
        }

        static void countAmountSimilarElementsInArray(in int[] array, ref int counter, int element, int index)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                if ((array[i] == element) && (index != i))
                    counter++;
        }
        static void deleteLessThanTwoSimilarElementsFromArray(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                countAmountSimilarElementsInArray(in array, ref temp, array[i], i);
                if (temp == 0)
                {
                    deleteElementFromArray(ref array, i);
                    i--;
                }
                else temp = 0;
            }  
        }
        static void deleteMoreThanTwoSimilarElementsFromArray(ref int[] array)
        {
            int temp = 0, element;
            for (int i = 0; i < array.Length; i++)
            {
                element = array[i];
                countAmountSimilarElementsInArray(in array, ref temp, array[i], i);
                if (temp >= 2)
                {
                    DeleteElementsFromArray(ref array, element);
                    temp = 0;
                }
                else temp = 0;
            }
        }
        static void deleteallSimilarElementsFromArray(ref int[] array, int amountSimilarElements)
        {
            int temp = 0, element;
            for (int i = 0; i < array.Length; i++)
            {
                element = array[i];
                countAmountSimilarElementsInArray(in array, ref temp, array[i], i);
                if (temp == (amountSimilarElements - 1))
                {
                    DeleteElementsFromArray(ref array, element);
                    temp = 0;
                }
                else temp = 0;
            }
        }
        static void printArray(int[] arr)
        {
            foreach (var elem in arr)
                Console.Write($" {elem}");
        }
        static void Main(string[] args)
        {
            int sizeOfArray;
            Console.WriteLine("Программа к задаче 21!!!");
            choseSizeOfArray(out sizeOfArray);
            int[] arr = new int[sizeOfArray];
            enterElementsOfArray(ref arr);
            sbyte whatToDo;

            Console.WriteLine("Введенний вами масив: ");
            printArray(arr);
            Console.WriteLine();

            Console.WriteLine("Виберите действие с масивом");
            Console.WriteLine("0 - удалить все елементи что встречаются менее двух раз");
            Console.WriteLine("1 - удалить все елементи что встречаются более двух раз");
            Console.WriteLine("2 - удалить все елементи что встречаются ровно два раза");
            Console.WriteLine("3 - удалить все елементи что встречаются ровно три раза");
            Console.Write("Enter>> ");
            whatToDo = Convert.ToSByte(Console.ReadLine());

            switch (whatToDo)
            {
                case 0:
                    deleteLessThanTwoSimilarElementsFromArray(ref arr);
                    printArray(arr);
                    break;
                case 1:
                    deleteMoreThanTwoSimilarElementsFromArray(ref arr);
                    printArray(arr);
                    break;
                case 2:
                    deleteallSimilarElementsFromArray(ref arr, 2);
                    printArray(arr);
                    break;
                case 3:
                    deleteallSimilarElementsFromArray(ref arr, 3);
                    printArray(arr);
                    break;
                default:
                    Console.WriteLine("Такой команди не существует!!!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
