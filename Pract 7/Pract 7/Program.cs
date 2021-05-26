using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
namespace Pract_7
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = "C:\\File.txt";
            Console.Write("Введите свои ФИО(пробел): ");
            string[] str = Console.ReadLine().Split(' ');

            try
            {
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.Default))
                {
                    writer.WriteLine("{0} {1} {2}", str[0], str[1], str[2]);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
