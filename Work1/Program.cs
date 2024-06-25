// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
using System;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            // Устанавливаем кодировку консоли на UTF-8
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введите значение M: ");
            int M = Convert.ToInt32(Console.ReadLine());
    //        int M = int.Parse(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Введите значение N: ");
            int N = Convert.ToInt32(Console.ReadLine());
    //        int N = int.Parse(Convert.ToInt32(Console.ReadLine()));

            if (M > N)
            {
                Console.WriteLine("M должно быть меньше или равно N!");
            }
            else
            {
                Console.WriteLine("------- Вывод натуральных чисел -------");
                PrintNaturalNumbers(M, N);
                Console.WriteLine("---------------------------------------");
            }
        }

        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Необходимо вводить числовое значение.");
        }
    
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }

    static void PrintNaturalNumbers(int current, int end)
    {

        // Условие выхода из рекурсии
        if (current > end)
        {
            return;
        }
        else if (current == end)
        {
            Console.WriteLine(current);
        }
        else
        {
            Console.Write(current + " ");
        }
        
        // Рекурсивный вызов с увеличением текущего числа
        PrintNaturalNumbers(current + 1, end);
    }
}