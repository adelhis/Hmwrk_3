using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;

namespace Hmwrk
{
    class Dz_File
    {
        static void Main()
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
            Zadanie4();
            Zadanie5();



        }
        /// <summary>
        /// Проверка, возрастает ли последовательность, и если не возрастает, возвращает номер "плохого элемента"
        /// </summary>
        static void Zadanie1()
        {
            /*1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность
            упорядоченной по возрастанию. В случае отрицательного ответа определить
            порядковый номер первого числа, которое нарушает данную последовательность.
            Использовать break.*/
            Console.WriteLine("Задание 1. Проверка последовательности на упорядоченность\n");
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 3 };
            bool flag = true;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] >= ar[i + 1])
                {
                    flag = false;
                    Console.WriteLine($"{i + 2} член последовательности нарушает порядок, так как {ar[i + 1]} <= {ar[i]}");
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Последовательность упорядоченна по возрастанию");
            }
        }
        /// <summary>
        /// Калькулятор карт
        /// Вводимое число от 6 до 14 конвертируется в достоинство соответствующей карты
        /// </summary>
        static void Zadanie2()
        {
            /*2. Игральным картам условно присвоены следующие порядковые номера в зависимости от
            их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            Порядковые номера остальных карт соответствуют их названиям («шестерка»,
            «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
            соответствующей карты. Использовать try-catch-finally.*/
            Console.WriteLine("\nЗадание 2. Определение достоинвства карты по ее номеру\n");
            string[] cards = { "Шестерка", "Семерка", "Восьмерка", "Девятка", "Десятка", "Валет", "Дама", "Король", "Туз" };
            Console.Write("Введите номер карты(от 6 до 14):");
            bool iscard = byte.TryParse(Console.ReadLine(), out byte card);
            try
            {
                Console.WriteLine($"Карта под номером {card} это {cards[card - 6]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Нужно было ввести число от 6 до 14");
            }
            finally
            {
                Console.WriteLine("Спасибо за использование нашего калькулятора карт");
            }
        }
        /// <summary>
        /// В зависимости от входной строки выводит разные значения
        /// </summary>
        static void Zadanie3()
        {
            /*3. Напишите программу, которая принимает на входе строку и производит выходные
            данные в соответствии со следующей таблицей:*/
            Console.WriteLine("\nЗадание 3. Обработка разных входов строк, в заготовленные выходные строки\n");
            Console.Write("Введите строку:");
            string input1 = Console.ReadLine().ToLower();
            switch (input1)
            {
                case "jabroni": 
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }
        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        /// <summary>
        /// Конвертирует номер дня недели в его название
        /// </summary>
        static void Zadanie4()
        {
            /*4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
            ...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
            Использовать enum.*/
            Console.WriteLine("\nЗадание 4. Выводит название дня по номеру в неделе\n");
            Console.Write("Введите номер дня в неделе: ");
            bool isday = byte.TryParse(Console.ReadLine(), out byte day_num);
            if (isday)
            {
                Console.WriteLine((Days)day_num);
            }
        }
        static void Zadanie5()
        {
            /*5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
            "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
            результату. Вывести на экран сколько кукол в “сумке”.*/
            Console.WriteLine("\nЗадание 5. Считает куколок\n");
            int res = 0;
            string[] strings = { "ASdasdghf", "Hello Kitty", "kjasdl", " asfaf", "Hello Kitty", "Barbie doll" };
            foreach (string str in strings)
            {
                if (str == "Hello Kitty" || str == "Barbie doll")
                {
                    res++;
                }
            }
            Console.WriteLine($"Количество кукол в сумке = {res}");
        }


    }
}