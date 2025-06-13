using System;

namespace sorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayi giriniz: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int girilenSayi))
            {
                Console.WriteLine("Bir sayı girmediniz programı sonlandırıyorum.");
                Console.ReadKey();
                return;
            }
            int sonuc = 0;

            if (girilenSayi == 0)
            {
                Console.WriteLine("Girilen sayi ile 0 arasında sayı olmadığı için sonuç 0'dır.");
            }
            else if (girilenSayi > 0)
            {
                for (int i = 1; i <= girilenSayi; i++)
                {
                    sonuc += i;
                    Console.WriteLine($"index = {i}, sonuc = {sonuc}");
                }
            }
            else
            {
                for (int i = -1; i >= girilenSayi; i--)
                {
                    sonuc += i;
                    Console.WriteLine($"index = {i}, sonuc = {sonuc}");
                }
            }

            Console.WriteLine("Girilen sayı ile sıfır arasındaki sayıların toplamı: {0}", sonuc);
            Console.ReadKey();
        }
    }
}