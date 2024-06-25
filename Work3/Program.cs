// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        try
        {
            // Устанавливаем кодировку консоли на UTF-8
            Console.OutputEncoding = Encoding.UTF8;

            // Запрашиваем длину массива
            Console.Write("Введите длину массива: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            // Создаем массив заданной длины
            int[] array = new int[length];

            // Заполняем массив случайными числами
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(100); // Заполняем числами от 0 до 99
            }

            // Выводим элементы массива в прямом порядке для наглядности
            Console.WriteLine("Заполненный массив выглядит следующим образом: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Вызываем рекурсивный метод для вывода элементов массива с конца
            Console.WriteLine("------  Массив в обратном порядке  ------");
            PrintArrayFromEnd(array, array.Length - 1);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
        }
        catch (FormatException)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Ошибка! Необходимо вводить числовое значение.");
            Console.WriteLine("---------------------------------------------");
        }

        // catch (Exception ex)
        // {
        //     Console.WriteLine("Произошла ошибка: " + ex.Message);
        // }
    }

    static void PrintArrayFromEnd(int[] array, int index)
    {
        // Базовый случай: если индекс меньше 0, прекращаем рекурсию
        if (index < 0)
        {
            return;
        }
        // Выводим текущий элемент
        Console.Write(array[index] + " ");

        // Рекурсивно вызываем метод для следующего элемента
        PrintArrayFromEnd(array, index - 1);
    }
}
