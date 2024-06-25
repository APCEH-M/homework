// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
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

            Console.Write("Введите значение m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Ackermann(m, n);
            Console.WriteLine($"A({m}, {n}) = {result}");

        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Необходимо вводить числовое значение!");
        }
        
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        else
        {
            throw new ArgumentException("Значения 'm' и 'n' не должны быть отрицательными!");
        }
    }
}
