using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Week
    {
        Mondy = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность
упорядоченной по возрастанию. В случае отрицательного ответа определить
порядковый номер первого числа, которое нарушает данную последовательность.
Использовать break.
             */
            Console.WriteLine("1.1");
            int[] numbers = new int[10];
            Console.WriteLine("введите 10 чисел");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int errornum = 0;
            // Проверка на упорядоченность
            bool Flag = true;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Flag = false; // Если найдено несоответствие, последовательность не упорядочена
                    break;
                }
                else
                {
                    errornum = i + 3;
                }
            }

            if (Flag)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine($"Последовательность не упорядочена по возрастанию. Последовательность нарушается на {errornum} числе ");
            }

            /* 2. Игральным картам условно присвоены следующие порядковые номера в зависимости от
их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
Порядковые номера остальных карт соответствуют их названиям («шестерка»,
«девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
соответствующей карты. Использовать try-catch-finally.
             */
            Console.WriteLine("2");
            byte k = 0;
            try
            {
                Console.Write("Введите номер карты (6 <= k <= 14): ");
                k = byte.Parse(Console.ReadLine());

                if (k < 6 || k > 14)
                {
                    Console.WriteLine("Номер карты должен быть в диапазоне от 6 до 14.");
                }

                string rank = string.Empty;

                // Определение достоинства карты
                switch (k)
                {
                    case 6:
                        rank = "Шестёрка";
                        break;
                    case 7:
                        rank = "Семёрка";
                        break;
                    case 8:
                        rank = "Восьмёрка";
                        break;
                    case 9:
                        rank = "Девятка";
                        break;
                    case 10:
                        rank = "Десятка";
                        break;
                    case 11:
                        rank = "Валет";
                        break;
                    case 12:
                        rank = "Дама";
                        break;
                    case 13:
                        rank = "Король";
                        break;
                    case 14:
                        rank = "Туз";
                        break;
                }

                Console.WriteLine($"Достоинство карты: {rank}");
            }
            catch (FormatException)
            {
                Console.WriteLine("введено некорректное значение. Пожалуйста, введите целое число.");
            }
            finally
            {
                Console.WriteLine("Конец программы.");
            }

            /*3. Напишите программу, которая принимает на входе строку и производит выходные
данные в соответствии со следующей таблицей:
             */
            Console.WriteLine("3");
            Console.WriteLine("напишите что нибудь из этого Jabroni/school Counselor/programmer/bike gang member/politician/rapper");
            string data = Console.ReadLine().ToLower();
            switch (data)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anyhning with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax Dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

            /*Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
Использовать enum.
             */
            Console.WriteLine("4");
            byte week = byte.Parse(Console.ReadLine());
            switch (week)
            {
                case 1: Console.WriteLine(Week.Mondy); break;
                case 2: Console.WriteLine(Week.Tuesday); break;
                case 3: Console.WriteLine(Week.Wednesday); break;
                case 4: Console.WriteLine(Week.Thursday); break;
                case 5: Console.WriteLine(Week.Friday); break;
                case 6: Console.WriteLine(Week.Saturday); break;
                case 7: Console.WriteLine(Week.Sunday); break;
            }

            /*5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
результату. Вывести на экран сколько кукол в “сумке”.
             */
            string[] market = { "book", "cat", "spoon", "spoon1", "spoon2", "tetris", "car", "Hello Kitty", "Barbie Doll", "car mini", "Hello Kitty" };
            int bag = 0;
            foreach (string el in market)
            {
                if (el == "Hello Kitty" || el == "Barbie Doll")
                {
                    bag++;
                }
            }
            Console.WriteLine(bag);
        }
    }
}
