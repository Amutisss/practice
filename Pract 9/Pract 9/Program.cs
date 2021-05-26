using System;

namespace Pract_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int matr = 9;
            int[,] A = new int[matr, matr];
            for (int i = 0; i < matr; i++)
            {
                for (int j = 0; j < matr; j++)
                {
                    A[i, j] = 1 - (i + j) % 2;
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            SS();
        }
        static void SS()
        {
            Console.Write("Введите размер массива ");
            int N = int.Parse(Console.ReadLine());
            int[] mas = new int[N];
            Random h = new Random();
            for (int i = 0; i <= N - 1; i++)
            {
                mas[i] = h.Next(100);
                Console.Write(" {0}", mas[i]);
            }
            Console.WriteLine();
            int n = 0;
            foreach (int L in mas)
            {
                n = L;
                for (int i = 2; i < n && n != 0; i++)
                { if (n % i == 0) ; }
                Console.WriteLine("простое число {0}", n);
            }
            Console.ReadKey();
        }
    }
    
}
