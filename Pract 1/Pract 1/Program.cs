using System;

namespace Pract_1
{
    static class lib1
    {
        // Метод  возвращающий строку которая дублирует входную строку указанное количество раз
        public static void Stpow(string a, int b)
        {
            string c = "";
            for (int i = 0; i < b; i++)
            {
                c += a;
            }
            Console.WriteLine("" + c);
        }
        // Метод возвращающий строку перевернутую строку.
        public static void Rev(string a)
        {
            string c = "";
            for (int i = a.Length - 1; i > -1; i--)
            {
                c += a[i];
            }
            Console.WriteLine("" + c);
        }
        //Метод возвращающий строку удаляющую из строки str все совпадения с  подстрокой s .
        public static void Remove(string str, string s)
        {
            string c = "";
            c = str.Replace(s, "");
            Console.WriteLine(c);
        }
        // Метод возвращающий длинну строки str. 
        public static void Leng(string str)
        {
            int a = str.Length;
            Console.WriteLine(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №1");
            string c, f;
            int a;
            Console.WriteLine("Выберите задание" + "\n" + " 1 - Задание 2" + "\n" + " 2 - Задание 3" + "\n" + " 3 - Задание 4" + "\n" + " 4 - Задание 5");
            int S = Convert.ToInt32(Console.ReadLine());
            switch (S)
            {
                case 1:
                    Console.WriteLine("Введите слово, которое будет повторятся");
                    f = Console.ReadLine();
                    Console.WriteLine("Введите количество повторения слова");
                    a = Convert.ToInt32(Console.ReadLine());
                    lib1.Stpow(f, a);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Введите строку, которую хотите перевернуть");
                    f = Console.ReadLine();
                    lib1.Rev(f);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Введите строку в которой хотите удалить символы");
                    c = Console.ReadLine();
                    Console.WriteLine("Введите символы, которые вы хотите удалить из строки");
                    f = Console.ReadLine();
                    lib1.Remove(c, f);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Введите строку, длинну которого хотите узнать");
                    f = Console.ReadLine();
                    lib1.Leng(f);
                    Console.ReadLine();
                    break;
            }

        }
    }
}

