using System;
namespace _enum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***ENUM GUNLER***");

            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            Console.WriteLine("***ENUM HAVA DURUMU***");

            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Disariya cikmak icin havanin birazdaha isinmasini bekleyelim");
            }
            else if (sicaklik >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Disariya cikmak icin cok sicak bir gun");
            }
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hadi disariya cikalim");
            }
        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Sali,
        Carsamba,
        Persembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}