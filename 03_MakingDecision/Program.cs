using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else Yapısı

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "1234")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şİfre Yanlış!");
            //}

            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "berlin" & country == "almanya")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;

            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 10)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average <= 60)
            //{
            //    result = "Sonuç vasat";
            //}
            //if(average > 60 & average <= 75)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 75 & average <= 90)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 90)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;

            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "berlin" | city == "roma" | city == "paris" | city == "madrid")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "user123")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}

            #endregion

            #region Mod işlemleri

            //int number = 30;
            //int result = number % 4;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else {
            //    Console.WriteLine("Sayı tektir");
            //}

            #endregion

            #region Char değişkenleri karar yapıları

            //char team;
            //Console.Write("Lütfen takımınızın sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'a' | team == 'A')
            //{
            //    Console.WriteLine("Arsenal");
            //}
            //if (team == 'm' | team == 'M')
            //{
            //    Console.WriteLine("Manchester United");
            //}
            //if (team == 'c' | team == 'C')
            //{
            //    Console.WriteLine("Chelsea");
            //}

            #endregion

            #region Örnek Uygulama Projesi
            //Console.WriteLine("C# Öğrenme Projesi Restoran");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Burgerler");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Lütfen detayı görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Izgara Tavuk");
            //    Console.WriteLine("2- Kuzu Pirzola");
            //    Console.WriteLine("3- Sebzeli Pilav");
            //    Console.WriteLine("4- Fırında Lazanya");
            //    Console.WriteLine("5- Karnıyarık");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Domates Çorbası");
            //    Console.WriteLine("2- Tavuk Suyu Çorbası");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Burgerler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Cheese Burger");
            //    Console.WriteLine("2- Chicken Burger");
            //    Console.WriteLine("3- Double Burger");
            //    Console.WriteLine("----------Burgerler----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Gazoz");
            //    Console.WriteLine("2- Şalgam");
            //    Console.WriteLine("3- Soda");
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Sütlaç");
            //    Console.WriteLine("2- Künefe");
            //    Console.WriteLine("3- Dondurma");
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthnumber = int.Parse(Console.ReadLine());

            //switch (monthnumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi yaptınız"); break;
            //}

            #endregion

            #region Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapıcağınız işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol) {

            //    case '+': 
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-': 
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result); 
            //        break;

            //    case '*': 
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result); 
            //        break;

            //    case '/': 
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result); 
            //        break;

            //    default: Console.Write("Hatalı veri girişi."); break;
            //}

            #endregion

            Console.Read();
        }
    }
}
