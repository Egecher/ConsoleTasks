using System;

namespace sorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ortalaması alınacak toplam ürün sayısını giriniz: ");
            int urunAdedi = Convert.ToInt32(Console.ReadLine());

            double toplamFiyat = 0;

            for (int i = 1; i <= urunAdedi; i++)
            {
                double fiyat;

                while (true)
                {
                    Console.Write($"{i}. sayıyı giriniz: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out fiyat) && fiyat >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Lütfen geçerli bir pozitif sayı giriniz. ");
                    }
                }

                toplamFiyat = fiyat;
            }

            double ortalama = toplamFiyat / urunAdedi;
            Console.WriteLine($"{urunAdedi} ürün fiyatının ortalaması: {ortalama} TL");
            Console.ReadKey();
        }
    }
}
