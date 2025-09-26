//***************************************************************************
// *Практическая работа №7                                                  *
//* Выполнил: Абдуллаев Э.С., группа 2-ИСПд                                 *
//* Задание: Определить кол-во чисел, значение которых >5 по модулю         *
//***************************************************************************
using System;
namespace Pr_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n;
            string numbers = "";

            Console.WriteLine("Введите 10 целых чисел:");
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.Write($"Число {i + 1}: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (Math.Abs(n) > 5)
                    {
                        count++;
                        if (numbers != "")
                        {
                            numbers += ", ";
                        }
                        numbers += n;
                    }
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine($"Ошибка:{fEx.Message}");
                    i--;
                }
                catch (OverflowException oEx)
                {
                    Console.WriteLine($"Ошибка: {oEx.Message}");
                    i--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                    i--;
                }
            }
            Console.WriteLine($"Количество чисел, больших 5 по модулю: {count}");

            if (count > 0)
            {
                Console.WriteLine($"Введённые числа: {numbers}");
            }
            else
            {
                Console.WriteLine("Чисел, больших 5 по модулю, не найдено.");
            }
            Console.ReadKey();
        }
    }
}