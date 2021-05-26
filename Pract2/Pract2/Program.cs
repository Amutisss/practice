using System;
using System.Collections.Generic;
namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Задание 1
            Console.WriteLine("Задание 1");
            string slovo = Console.ReadLine();
            int F = 0, index = 0;
           
            for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i] == 'f')
                {
                    F++;
                    if (F == 2)
                    {
                        index += i;
                    }
                }
            }
            if (F > 2)
            {
                Console.WriteLine("Второе вхождения f = " + index);
                Console.WriteLine("Всего f = " + F);
            }
            if (F == 2)
            {
                Console.WriteLine("Второе вхождения f = " + index);
                Console.WriteLine("Всего f = " + F);
            }
            if (F == 1)
            {
                Console.WriteLine(-1);
            }
            if (F == 0)
            {
                Console.WriteLine(-2);
            }
            ///Задание 2
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите слово для перевода");
            string perevod = "";
            string sslovo  = Console.ReadLine();
            char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ы', 'э', 'ю', 'я' };
            string[] eng = { "a", "b", "v", "g", "d", "e", "j", "z", "i", "k", "l", "m", "n", "o", "p", "r", "s", "t", "y", "f", "h", "c", "ch", "sh", "sh", "ie", "e", "ye", "ya" };
            for (int i = 0; i < sslovo.Length; i++)
            {
                for (int j = 0; j < rus.Length; j++)
                {
                    if (sslovo[i] == rus[j])
                    {
                        perevod += eng[j];
                    }
                }
            }
            Console.WriteLine(perevod);
            ///Задание 3
            string st = " ";
            char f = 'h';
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите слово или слово сочетание содержащее h");
            st = Console.ReadLine();
            //Нахождение первой буквы
            int first_index = st.IndexOf(f);
            //Нахождение последней буквы 
            int last_index = st.LastIndexOf(f);
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == f)
                {
                    if (i != first_index && i != last_index)
                    {
                        st = st.Remove(i, 1).Insert(i, "H");
                    }
                }
            }
            Console.WriteLine(st);




        }
        
    }
}
