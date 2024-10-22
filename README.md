# Двумерные массивы
## Homework
<img src="https://github.com/user-attachments/assets/f57852aa-b866-4a98-b1f2-5788c74bcd49" width="135" />

> Карасев Илья

![image](https://github.com/user-attachments/assets/aeb10983-5f6c-4f17-93b0-2bee5cc15642)

![image](https://github.com/user-attachments/assets/bb24abf3-8618-463a-ab45-f223e0255720)

![image](https://github.com/user-attachments/assets/5cfd9aba-8545-45d3-bf2b-1a3914c70fa7)


```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Задание 1");
            Console.WriteLine("Привет, мир!");
            Thread.Sleep(5000);
        }

        static int Task2(int a, int b)
        {
            return a + b;
        }
        
        static string Task3(string a)
        {
            return Convert.ToString(a.Length);
        }

        
        static int[] Task4(int[] array)
        {
            array = new int[array.Length];

            
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Task1();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Задание 2");
                        Console.WriteLine("Введите первое число: ");

                        int a, b;
                        while (!int.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Введите корректное число!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("Введите первое число: ");
                        }

                        Console.WriteLine("Введите второе число: ");
                        while (!int.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Введите корректное число!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("Введите первое число: ");
                        }

                        int tefteli = Task2(a, b);
                        Console.WriteLine($"Результат сложения данных чисел: {tefteli}");

                        Thread.Sleep(5000);
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Задание 3");
                        Console.Write("Введите строку:");

                        Console.WriteLine($"Кол-во символов в данной строке: {Task3(Console.ReadLine())}");
                        
                        Thread.Sleep(5000);
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Задание 4");

                        Random rnd = new Random();
                        int[] array = new int[12];

                        Console.WriteLine("Массив: ");
                        for (int i = 0; i <= array.Length; i++)
                        {
                            array[i] = rnd.Next(1, 100);
                            Console.Write($"{array[i]} ");
                        }



                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Произошла ошибка!");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}

```
