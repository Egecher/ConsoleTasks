using System;

namespace sorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int sayiAdedi = 10;
            double sayilarınToplami = 0;

            for (int i = 1; i <= sayiAdedi; i++)
            {
                double sayi;

                while (true)
                {
                    Console.Write($"{i}. Sayıyı giriniz: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out sayi))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Lütfen geçerli bir sayı giriniz. ");
                    }
                }

                if (sayi > 0) sayilarınToplami += sayi;
            }

            Console.WriteLine("Girilen {0} adet sayının içerisindeki sadece pozitif sayıların toplamı: {1}", sayiAdedi, sayilarınToplami);
            Console.ReadKey();
        }
    }
}

