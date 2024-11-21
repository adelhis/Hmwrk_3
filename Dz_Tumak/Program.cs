using System;

namespace Hmwrk
{
    class Tumak
    {
        static void Main()
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
        }
        static void Zadanie1()
        {
            /*Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня
            в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
            февраля (високосный год не учитывать).*/
            Console.WriteLine("Упражнение 4.1. Подсчитать месяц и день месяца по дню в год\n");
            Console.Write("Введите день в году: ");
            bool isday = short.TryParse(Console.ReadLine(), out short day);
            if (isday && day < 366 && day > 0)
            {
                DateTime theDate = new DateTime(2024, 1, 1).AddDays(day - 1);
                Console.WriteLine(theDate.ToString("d MMMM"));
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
        static void Zadanie2()
        {
            /*Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
            пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать
            исключение, и выдавать на экран сообщение.*/
            Console.WriteLine("\nУпражнение 4.2. Добавить к предыдущему заданию проверку\n");
            //Так получилось что я уже сделал проверку, как обычно
            Console.Write("Введите день в году: ");
            bool isday = short.TryParse(Console.ReadLine(), out short day);
            if (isday && day < 366 && day > 0)
            {
                DateTime theDate = new DateTime(2024, 1, 1).AddDays(day - 1);
                Console.WriteLine(theDate.ToString("d MMMM"));
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
        static void Zadanie3()
        {        
            /*Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
            учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
            делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
            год. Однако, если он делится без остатка на 400, это високосный год.)*/
            Console.WriteLine("\nУпражнение 4.3. Добавить проверку на високосный год\n");
            Console.Write("Введите день в году: ");
            bool isday = short.TryParse(Console.ReadLine(), out short day);
            Console.Write("Введите год:");
            bool isyear = short.TryParse(Console.ReadLine(), out short year);
            if (isday && day < 366 && day > 0 && year < 10000 && year > 0)
            {
                DateTime theDate = new DateTime(year, 1, 1).AddDays(day - 1);
                Console.WriteLine(theDate.ToString("d MMMM yyyy"));
                //Console.WriteLine(DateTime.MaxValue.Year.ToString());
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }

        }
    }
}