using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //int j;

            //for (j = 0; j <= 4; j++)
            //{
            //    Console.WriteLine("C# Gelişim Kampı");
            //}

            //for (int j = 2; j <= 15; j++)
            //{ 
            //    Console.WriteLine(j);
            //}

            //for (int j = 4; j <= 40; j += 4)
            //{
            //    Console.WriteLine(j);
            //}

            //Console.WriteLine("Ekrana yazılacak miktarı giriniz: ");
            //int endValue = int.Parse(Console.ReadLine());

            //for(int j = 0; j < endValue; j++)
            //{
            //    Console.WriteLine("Bilim ve Teknoloji!");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapilari

            //for (int j = 0; j <= 80; j++)
            //{
            //    if (j % 6 == 0)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}

            //int sumValue = 0;
            //for (int j = 1; j <= 15; j++)
            //{
            //    sumValue += j;
            //}

            //Console.WriteLine(sumValue);

            //int sumEven = 0;

            //for (int j = 2; j < 30; j++) 
            //{
            //    if (j % 2 == 0) 
            //    { 
            //        sumEven += j;
            //        Console.WriteLine(j);
            //    }   
            //}

            //Console.WriteLine("-------------");
            //Console.WriteLine(sumEven);

            //int counter = 0;
            //for (int j = 1; j <= 40; j++)
            //{
            //    if (j % 5 == 0)
            //    {
            //        counter++;
            //    }
            //}

            //Console.WriteLine(counter);

            //int cell = 1;
            //for (int j = 1; j <= 20; j++)
            //{
            //    cell *= 2;
            //    Console.WriteLine(j + ". Saat Sonunda: " + cell);
            //}

            #endregion

            #region While Döngüsü

            //int j = 1;

            //while (j <= 8)
            //{
            //    Console.WriteLine("Döngüler ile Programlama!");
            //    j++;
            //}

            //int j = 1;
            //while (j <= 8)
            //{
            //    if (j % 2 == 0)
            //    {
            //        Console.WriteLine(j);
            //    }
            //    j++;
            //}

            //int j = 1, toplam = 0;
            //while (j <= 8) 
            //{
            //    toplam += j;
            //    j++;
            //}
            //Console.WriteLine(toplam);

            #endregion

            #region Örnek Soru

            //int sayi, toplam = 0, j, basamak;

            //Console.Write("Lütfen 4 basamaklı bir sayı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());

            //for (j = 0; j < 4; j++)
            //{
            //    basamak = sayi % 10;
            //    sayi = sayi - basamak;
            //    sayi = sayi / 10;
            //    toplam += basamak;
            //}

            //Console.WriteLine("Basamakların Toplamı: " + toplam);

            #endregion
            Console.Read();
        }
    }
}
