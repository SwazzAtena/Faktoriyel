using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            long faktoriyel = FaktoriyelHesapla(sayi);
            Console.WriteLine($"{sayi}! = {faktoriyel}");

            Console.ReadLine(); // Kullanıcının çıktıyı görmesi için bir tuşa basmasını bekleyin.
        }

        static long FaktoriyelHesapla(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * FaktoriyelHesapla(n - 1);
        }
    }
}
