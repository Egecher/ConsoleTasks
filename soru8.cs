using System;

namespace sorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayiyi giriniz: ");
            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int inputSayi1))
            {
                Console.Write("Bir sayı girmediniz programı sonlandırıyorum.");
                Console.ReadKey();
                return;
            }

            Console.Write("2. sayiyi giriniz: ");
            string input2 = Console.ReadLine();
            if (!int.TryParse(input2, out int inputSayi2))
            {
                Console.Write("Bir sayı girmediniz programı sonlandırıyorum.");
                Console.ReadKey();
                return;
            }

            if (inputSayi1 == inputSayi2)
            {
                if (inputSayi1 % 2 == 0)
                {
                    Console.WriteLine($"Girdiğiniz sayılar birbirine eşittir. Çift sayı: {inputSayi1}");
                }
                else
                {
                    Console.WriteLine("Sayı tektir");
                }
            }
            else if (inputSayi1 < inputSayi2)
            {
                Console.Write("{0} ile {1} arasındaki çift sayılar: ", inputSayi1, inputSayi2);
                for (int i = inputSayi1; i <= inputSayi2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i}");
                        if (i + 2 <= inputSayi2) Console.Write(",");
                    }
                }
            }
            else
            {
                Console.Write("{0} ile {1} arasındaki çift sayılar: ", inputSayi1, inputSayi2);
                for (int i = inputSayi1; i >= inputSayi2; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i}");
                        if (i - 2 >= inputSayi2) Console.Write(",");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}