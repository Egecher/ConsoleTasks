using System;

namespace sorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İsim giriniz: ");
            string name = Console.ReadLine();
            int yazdirmaAdedi;
            while (true)
            {
                Console.Write("Kaç kere yazdırılsın?: ");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out yazdirmaAdedi) && yazdirmaAdedi > 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Lütfen geçerli bi pozitif sayı giriniz! ");
                }
            }

            for (int i = 1; i <= yazdirmaAdedi; i++)
            {
                Console.WriteLine($"{i}. {name}");
            }

            Console.ReadKey();
        }
    }
}