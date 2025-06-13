using System;

namespace sorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aralığını toplamak istediğiniz sayilardan 1. sayiyi giriniz: ");
            int inputSayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aralığını toplamak istediğiniz sayilardan 2. sayiyi giriniz: ");
            int inputSayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc;

            if (inputSayi1 == inputSayi2)
            {
                if (inputSayi1 % 2 == 0)
                {
                    sonuc = inputSayi1 + inputSayi2;
                    Console.WriteLine($"Girdiğiniz sayılar birbirine eşittir. Toplam: {sonuc}");
                }
                else
                {
                    Console.WriteLine("sayi tektir");
                }
            }
            else if (inputSayi1 < inputSayi2)
            {
                sonuc = 0;
                for (int i = inputSayi1; i < inputSayi2; i++)
                {
                    sonuc += i;
                    Console.WriteLine($"Index = {i}, sonuc = {sonuc}");
                }
                Console.WriteLine("Girdiğiniz sayılar arasındaki sayıların toplamı {0}", sonuc);
            }
            else
            {
                sonuc = 0;
                for (int i = inputSayi1 -1; i >= inputSayi2; i--)
                {
                    sonuc += i; 
                    Console.WriteLine($"Index = {i}, sonuc = {sonuc}");
                }
                Console.WriteLine("Girdiğiniz sayılar arasındaki sayıların toplamı {0}", sonuc);
            }
        }
    }
}