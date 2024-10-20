using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задание №1");

            Random rnd = new Random();
            int[,] array = new int[3, 4];
            int[] temp_array = new int[array.GetLength(1)];

            Console.WriteLine("\nИсходный массив: ");
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                    if (i == 2)
                    {
                        temp_array[j] = array[i, j];
                    }
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

            Array.Sort(temp_array);

            Console.WriteLine("\nИтоговый массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 2)
                    {
                        array[i, j] = temp_array[j];
                    }
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void Task2()
        {
            Console.WriteLine("Задание №2");

            Random rnd = new Random();
            int[,] array = new int[7, 7];
            int sum = 0;

            Console.WriteLine("\nИсходный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                    if (array[i, j] % 2 != 0 && array[i, j] < 0)
                    {
                        sum += Math.Abs(array[i, j]);
                    }
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nСумма модулей отрицательных нечётных элементов данного масива: {sum}");

            Console.ReadKey();

        }

        static void Task3()
        {
            Console.WriteLine("Задание №3");

            Random rnd = new Random();
            int[,] array = new int[5, 6];
            int sum = 0;

            Console.WriteLine("\nИсходный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nСреднее арифметическое элементов столбца:");

            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j, i];
                }
                Console.WriteLine($"{i + 1}. {sum / array.GetLength(1)}");
            }

            Console.ReadKey();
        }

        static void Task4()
        {
            Console.WriteLine("Задание №4");

            Random rnd = new Random();
            int[,] array = new int[5, 5];
            int[] diagonal = new int[5];
            int x = 52, count = 4;

            Console.WriteLine("\nИсходный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                    Console.Write($" {array[i, j]}");
                    if (j == count)
                    {
                        count--;
                        if (array[i, j] < x) x = array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nНаименьший элемент на побочной диагонали: {x}");

            Console.ReadKey();
        }

        static void Task5()
        {
            Console.WriteLine("Задание №5");

            Random rnd = new Random();
            int[,] array = new int[5, 4];
            int[] temp_array = new int[array.GetLength(0)];

            Console.WriteLine("\nИсходный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                    if (j == 3)
                    {
                        temp_array[i] = array[i, j];
                    }
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

            Array.Sort(temp_array);

            Console.WriteLine("\nИтоговый массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == 3)
                    {
                        array[i, j] = temp_array[i];
                    }
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void Task6()
        {
            Console.WriteLine("Задание №6");

            Random rnd = new Random();
            int[,] array = new int[4, 3];
            int[] temp_array1 = new int[array.GetLength(0)];
            int[] temp_array2 = new int[array.GetLength(0)];

            Console.WriteLine("\nИсходный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                    if (j == 0)
                    {
                        temp_array1[i] = array[i, j];
                    }
                    if (j == 2)
                    {
                        temp_array2[i] = array[i, j];
                    }
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

            int index_1 = Array.IndexOf(temp_array1, temp_array1.Max());
            int index_2 = Array.IndexOf(temp_array2, temp_array2.Max());

            array.SetValue(temp_array1[index_1], index_2, 2);
            array.SetValue(temp_array2[index_2], index_1, 0);

            Console.WriteLine("\nИтоговый массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void Task7()
        {
            Console.WriteLine("Задание №7");

            Random rnd = new Random();
            int[,] array = new int[3, 4];
            int[] temp_array1 = new int[array.GetLength(1)];
            int[] temp_array2 = new int[array.GetLength(1)];

            Console.WriteLine("\nИсходный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-50, 51);
                    if (i == 0)
                    {
                        temp_array1[j] = array[i, j];
                    }
                    if (i == 2)
                    {
                        temp_array2[j] = array[i, j];
                    }
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }
            

            int index_1 = Array.IndexOf(temp_array1, temp_array1.Min());
            int index_2 = Array.IndexOf(temp_array2, temp_array2.Min());

            array.SetValue(temp_array1[index_1], 2, index_2);
            array.SetValue(temp_array2[index_2], 0, index_1);

            Console.WriteLine("\nИтоговый массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void Task8()
        {
            Console.WriteLine("Задание №8");

            Random rnd = new Random();
            int size = rnd.Next(1, 11);
            double[,] array = new double[size, size];
            double product = 1;

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = rnd.NextDouble() * 50;
                    Console.Write($"{array[i, j]:F4} ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < size; j++)
            {
                double min = array[0, j];
                for (int i = 1; i < size; i++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
                product *= min;
            }

            Console.WriteLine($"\nПроизведение наименьших элементов каждого столбца массива: {product:F4}");

            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
                Console.Write("Выберите задание (1-8): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Task1();
                        break;

                    case "2":
                        Task2();
                        break;

                    case "3":
                        Task3();
                        break;

                    case "4":
                        Task4();
                        break;

                    case "5":
                        Task5();
                        break;

                    case "6":
                        Task6();
                        break;

                    case "7":
                        Task7();
                        break;

                    case "8":
                        Task8();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\aВыберите корректное задание!");
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}
