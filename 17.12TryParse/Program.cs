/*
 * а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечётных положительных чисел. 
 * Сами числа и сумму вывести на экран, используя tryParse.
 */
using System;

namespace tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа для подсчета суммы");
            int n;
            if (int.TryParse(Console.ReadLine(), out n) == false)
            {
                n = -1;
                Console.WriteLine("Недопустимый символ повторите ввод");
            }
            int sum = 0;
            while (n != 0)
            {
                if (n > 0 && n % 2 != 0)
                {
                    sum += n;

                }
                if (int.TryParse(Console.ReadLine(), out n) == false)
                {
                    n = -1;
                    Console.WriteLine("Недопустимый символ повторите ввод");

                }

            }
            Console.WriteLine(sum);
            Console.ReadLine();





        }


    }
}

