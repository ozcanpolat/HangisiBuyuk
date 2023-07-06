using System;

namespace HangisiBuyuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen 2 sayıdan hangisi büyüktür?

            Console.Write("Birinci sayıyı giriniz :");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz :");
            int sayi2 = int.Parse(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine("Girilen birinci sayı daha büyüktür.");
            }
            else
            {
                Console.WriteLine("Girilen ikinci sayı daha büyüktür. ");
            }
        }
    }
}
