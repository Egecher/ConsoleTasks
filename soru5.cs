using System;

namespace sorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;

            for (int n = 1; n <= 10; n++)
            {
                int nKare;

                nKare = n * n;
                Console.WriteLine(nKare);

                sonuc += nKare;
            }

            Console.WriteLine("1 den 10'a kadar olan sayıların karelerinin toplamı: {0}", sonuc);
            Console.ReadKey();
        }
    }
}