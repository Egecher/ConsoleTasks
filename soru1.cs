using System;

namespace sorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ortalaması alınacak toplam ürün sayısını giriniz: ");
            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int urunAdedi))
            {
                Console.WriteLine("Bir sayı girmediniz programı sonlandırıyorum.");
                Console.ReadKey();
                return;
            }

            double toplamFiyat = 0;

            for (int i = 1; i <= urunAdedi; i++)
            {
                double fiyat;

                while (true)
                {
                    Console.Write($"{i}. sayıyı giriniz: ");
                    string input2 = Console.ReadLine();

                    if (double.TryParse(input2, out fiyat) && fiyat >= 0)
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
