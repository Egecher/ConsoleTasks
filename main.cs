using System;

class Program
{
    static void Main()
    {
        const int urunSayisi = 15;
        double toplamFiyat = 0;

        for (int i = 1; i <= urunSayisi; i++)
        {
            double fiyat;

            while (true)
            {
                Console.Write($"Ürün {i} fiyatını girin: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out fiyat) && fiyat >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Geçerli bir pozitif sayı girin.");
                }
            }

            toplamFiyat += fiyat;
        }

        double ortalama = toplamFiyat / urunSayisi;
        Console.WriteLine($"\n15 ürünün ortalama fiyatı: {ortalama:F2} TL");
    }
}
