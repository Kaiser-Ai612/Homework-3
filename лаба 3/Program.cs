﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static string GetMonthName(int month)
        {
            string[] monthNames = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                                "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            return monthNames[month - 1];
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
        static void Task1()
        {
            /*Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня
в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
февраля (високосный год не учитывать).
             */
            Console.WriteLine("напишите чисо от 1 до 365");
            //DateTime data = new DateTime(2000,1,1);
            //DateTime data2 = new DateTime(int.Parse(Console.ReadLine()));
            //DateTime data1 = new DateTime(data2.AddDays(Convert.ToDouble(data2)));

            // Массив с количеством дней в каждом месяце 
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int dayOfYear = int.Parse(Console.ReadLine());
            // Определение месяца и дня
            byte month = 0;
            byte day = 0;
            for (int i = 0; i < daysInMonth.Length; i++)
            {
               if (dayOfYear <= daysInMonth[i])
               {
                   month = i + 1; // Месяцы начинаются с 1
                   day = dayOfYear; // Остаток - это день в месяце
                   break;
               }
               else
               {
                   dayOfYear -= daysInMonth[i]; // Уменьшаем номер дня на количество дней в текущем месяце
               }
            }
            Console.WriteLine($"{day} {GetMonthName(month)}.");
        }
        static void Task2()
        {
            /*Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать
исключение, и выдавать на экран сообщение.
             */
            Console.WriteLine("напишите чисо от 1 до 365");
            int dayOfYear4 = int.Parse(Console.ReadLine());
            byte month4 = 0;
            byte day4 = 0;
            if (dayOfYear4 < 1)
            {
                Console.WriteLine("число не может быть меньше 1");
            }
            else if (dayOfYear4 > 365)
            {
                Console.WriteLine("число не может быть больше 365");
            }
            for (int i = 0; i < daysInMonth.Length; i++)
            {
               if (dayOfYear4 <= daysInMonth[i])
               {
                   month4 = i + 1; // Месяцы начинаются с 1
                   day4 = dayOfYear4; // Остаток - это день в месяце
                   break;
               }
               else
               {
                   dayOfYear4 -= daysInMonth[i]; // Уменьшаем номер дня на количество дней в текущем месяце
               }
            }

                // Вывод результата
            Console.WriteLine($"{day4} {GetMonthName(month4)}.");
        }
        static void Task3()
        {
            /* Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
год. Однако, если он делится без остатка на 400, это високосный год.)
             */
            Console.WriteLine("введите год потом число");
            short year = int.Parse(Console.ReadLine());
            //int dayOfYear1 = int.Parse(Console.ReadLine());
            byte month1 = 0;
            byte day1 = 0;
            
            int[] daysInMonth2 = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (year % 4 == 0 && year % 100 == 0) //не високосный
            {
                int dayOfYear1 = int.Parse(Console.ReadLine());
                if (dayOfYear1 < 1)
                {
                    Console.WriteLine("число не может быть меньше 1");
                }
                else if (dayOfYear1 > 365)
                {
                    Console.WriteLine("число не может быть больше 365");
                }
                for (int i = 0; i < daysInMonth.Length; i++)
                {
                    if (dayOfYear1 <= daysInMonth[i])
                    {
                        month1 = i + 1; // Месяцы начинаются с 1
                        day1 = dayOfYear1; // Остаток - это день в месяце
                        break;
                    }
                    else
                    {
                        dayOfYear1 -= daysInMonth[i]; // Уменьшаем номер дня на количество дней в текущем месяце
                    }
                }
                Console.WriteLine($"{day1} {GetMonthName(month1)}.");
            }
            else if ((year % 4 == 0)||(year%400 == 0)) //високосный
            {
                int dayOfYear1 = int.Parse(Console.ReadLine());
                if (dayOfYear1 < 1)
                {
                    Console.WriteLine("число не может быть меньше 1");
                }
                else if (dayOfYear1 > 366)
                {
                    Console.WriteLine("число не может быть больше 366");
                }
                for (int i = 0; i < daysInMonth.Length; i++)
                {
                    if (dayOfYear1 <= daysInMonth2[i])
                    {
                        month1 = i + 1; // Месяцы начинаются с 1
                        day1 = dayOfYear1; // Остаток - это день в месяце
                        break;
                    }
                    else
                    {
                        dayOfYear1 -= daysInMonth2[i]; // Уменьшаем номер дня на количество дней в текущем месяце
                    }
                }
                Console.WriteLine($"{day1} {GetMonthName(month1)}.");
            }
            else
            {
                int dayOfYear1 = int.Parse(Console.ReadLine());
                if (dayOfYear1 < 1)
                {
                    Console.WriteLine("число не может быть меньше 1");
                }
                else if (dayOfYear1 > 365)
                {
                    Console.WriteLine("число не может быть больше 365");
                }
                for (int i = 0; i < daysInMonth.Length; i++)
                {
                    if (dayOfYear1 <= daysInMonth[i])
                    {
                        month1 = i + 1; // Месяцы начинаются с 1
                        day1 = dayOfYear1; // Остаток - это день в месяце
                        break;
                    }
                    else
                    {
                        dayOfYear1 -= daysInMonth[i]; // Уменьшаем номер дня на количество дней в текущем месяце
                    }
                }
                Console.WriteLine($"{day1} {GetMonthName(month1)}.");
            }
            
        }
    }
}
