using System;

namespace Cocomoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cocomo Hesaplayıcı");
            Console.WriteLine("-------------------");
            while (true)
            {
                Console.WriteLine("İstenilen satır sayısını giriniz: ");
                Console.WriteLine("___________________________________ ");
                int satirSayisi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nAyrık Proje");
                Console.WriteLine("___________________________________ ");
                double a = 2.4;
                double b = 1.05;
                double c = 2.5;
                double d = 0.38;
                var KLOC = satirSayisi;
                var isGücü = a * Math.Pow(KLOC, b);
                var gelistirmeSüresi = c * Math.Pow(isGücü, d);
                var ortpersonelSayisi = isGücü / gelistirmeSüresi;
                var verimlilik = KLOC / isGücü;
                Console.WriteLine("İş Gücü = {0}", isGücü);
                Console.WriteLine("Geliştirme Süresi = {0}", gelistirmeSüresi);
                Console.WriteLine("Ortalama Personel Sayısı = {0}", ortpersonelSayisi);
                Console.WriteLine("Verimlilik = {0}", verimlilik);
                Console.WriteLine();
                Console.WriteLine("Yarı Ayrık Proje");
                Console.WriteLine("___________________________________ ");
                a = 3.0;
                b = 1.12;
                c = 2.5;
                d = 0.35;
                KLOC = satirSayisi;
                isGücü = a * Math.Pow(KLOC, b);
                gelistirmeSüresi = c * Math.Pow(isGücü, d);
                ortpersonelSayisi = isGücü / gelistirmeSüresi;
                verimlilik = KLOC / isGücü;
                Console.WriteLine("İş Gücü = {0}", isGücü);
                Console.WriteLine("Geliştirme Süresi = {0}", gelistirmeSüresi);
                Console.WriteLine("Ortalama Personel Sayısı = {0}", ortpersonelSayisi);
                Console.WriteLine("Verimlilik = {0}", verimlilik);
                Console.WriteLine();
                Console.WriteLine("Gömülü Sistem");
                Console.WriteLine("___________________________________ ");
                a = 3.6;
                b = 1.2;
                c = 2.5;
                d = 0.32;
                KLOC = satirSayisi;
                isGücü = a * Math.Pow(KLOC, b);
                gelistirmeSüresi = c * Math.Pow(isGücü, d);
                ortpersonelSayisi = isGücü / gelistirmeSüresi;
                verimlilik = KLOC / isGücü;
                Console.WriteLine("İş Gücü = {0}", isGücü);
                Console.WriteLine("Geliştirme Süresi = {0}", gelistirmeSüresi);
                Console.WriteLine("Ortalama Personel Sayısı = {0}", ortpersonelSayisi);
                Console.WriteLine("Verimlilik = {0}", verimlilik);
                Console.WriteLine();
            }
        }
    }
}
