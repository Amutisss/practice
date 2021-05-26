using System;

namespace Pract_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Нахождение минимального по модулю элемента массива
            Console.WriteLine("Задание 1"); 
            int[] array = { 10, -3, -5, 2, 5 };
            int min = 214748364;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < min) 
                {
                    min = Math.Abs(array[i]);
                    index = i;
                }

            }
            Console.WriteLine(index);
            // Поиск повторяющихся элементов
            Console.WriteLine("Задание 2" + "\n");
            int[] mass = { 1, 5, 2, 1, 2, 3 };
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    // Поиск похожих и их количество
                    if (mass[i] == mass[j]) 
                    {
                        count++;
                    }
                }
                if (count == 1) 
                {
                    Console.Write(mass[i]  + "\n");
                }
                count = 0;
            }
            Console.WriteLine("Задание 3" + "\n");
            Console.Write("\n" + "Введите размер массива: " );
            int N = Convert.ToInt32(Console.ReadLine());
            int[] random = new int[N];
            Random rand1 = new Random();
            count = 0;
            Console.WriteLine( "Не отсеянный массив:");
            for (int i = 0; i < N; i++)
            {
                random[i] = rand1.Next(-50, 50);
                Console.Write(random[i] + " ");
                if (random[i] < 0)
                {

                    count++;
                }

            }

            int[] ready = new int[N - count];
            int f = 0;
            for (int i = 0; i < N; i++)
            {
                if (random[i] >= 0)
                {
                    ready[f] = random[i];
                    f++;
                }
            }
            Console.WriteLine("\n" + "Отсеянный массив: ");
            for (int i = 0; i < N - count; i++)
            {
                Console.Write(ready[i] + " ");
            }
        }
    }
}
