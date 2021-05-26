using System;

namespace Pract_8
{
    class Program
    {
        static void Main(string[] args)
        {
           
                // Создание массива
                int[,] Array = new int[10, 10];
                Random r = new Random();

                // Заполенение массива
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        Array[i, j] = r.Next(1, 10);
                    }
                }

                // Вывод массива
                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        Console.Write(Array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                // Побочная диагональ
                int GetLenght = Array.GetLength(0) - 2;
                int one = 1;
                int NewAr = Array[0, Array.GetLength(0) - 1];
                while (GetLenght >= 0)
                {
                    if (NewAr < Array[one, GetLenght])
                    {
                        NewAr = Array[one, GetLenght];
                    }
                    GetLenght--;
                    one++;
                }
                Console.WriteLine("Максимальный элемент побочной диагонали: " + NewAr);
                NewAr = 0;

                // Главная диагональ
                for (int i = 0; i <= 9; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        if (NewAr < Array[i, j])
                        {
                            NewAr = Array[i, j];
                        }
                    }
                }
                Console.WriteLine("Максимальный элемент главной диагонали: " + NewAr);

                // Сумма столбцов
                for (int i = 0; i < Array.GetLength(1); i++)
                {
                    NewAr = 0;
                    for (int j = 0; j < Array.GetLength(0); j++)
                    {
                        NewAr += Array[j, i];
                    }
                    Console.WriteLine($"Сумма {i + 1} столбца: " + NewAr);
                }
            }
            
        }
    
    
}
