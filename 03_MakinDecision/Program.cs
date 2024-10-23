using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakinDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else Kullanımı

            //string name,password;

            //Console.WriteLine("**********ADMİN PANELİ**********");
            //Console.WriteLine();
            //Console.Write("Kullanıcı adını giriniz: ");
            //name = Console.ReadLine();

            //Console.Write("Şifrenizi giriniz: ");
            //password = Console.ReadLine();

            //if (name=="admin" & password=="abcd")
            //{
            //    Console.Write("Şifre doğru.");
            //}
            //else 
            //{
            //    Console.Write("Şifre yanlış.");
            //}

            //Console.WriteLine("**********Öğrenci Bilgi Sistemi**********");
            //Console.WriteLine();

            //string lesson, result;
            //double exam1, exam2, exam3, average;

            //Console.Write("Ders adı giriniz: ");
            //lesson = Console.ReadLine();
            //Console.Write("1.sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2.sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3.sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Ortalamanız: " + average);
            //Console.WriteLine();

            //if (average > 0 & average < 50)
            //{
            //    result = "Dersten kaldınız.";

            //}
            //if (average>=50 & average<=100)
            //{
            //    result = "Dersten geçtiniz.";
            //}
            //else
            //{
            //    result = "Hata!";
            //}
            //Console.WriteLine(result);
            #endregion

            #region Mod İşlemleri

            //int number1, number2, result;

            //Console.Write("1.Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: "+result);


            //int number;
            //Console.Write("Bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Girdiğiniz sayı çift sayıdır.");
            //}
            //else
            //{
            //    Console.Write("Girdiğiniz sayı tek sayıdır.");
            //}

            #endregion

            #region Char  Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen takımınızın sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'b' || team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            //if (team == 'f' || team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'g' || team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //else
            //{
            //    Console.Write("Hatalı giriş.");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("**************C# EĞİTİM KAMPI 03**************");
            //Console.WriteLine();

            //Console.WriteLine("-----------------MENÜ-----------------");
            //Console.WriteLine("1-ANA YEMEKLER");
            //Console.WriteLine("2-ÇORBALAR");
            //Console.WriteLine("3-İÇECEKLER");
            //Console.WriteLine("4-TATLILAR");
            //Console.WriteLine("--------------------------------------");

            //Console.Write("Bir seçim yapınız: ");
            //int choose = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (choose==1)
            //{
            //    Console.WriteLine("-----------------Ana Yemekler-----------------");
            //    Console.WriteLine("Kebab");
            //    Console.WriteLine("Ciğer");
            //    Console.WriteLine("Patates Köfte");
            //    Console.WriteLine("Izgara");
            //    Console.WriteLine("Pizza");
            //    Console.WriteLine("-----------------Ana Yemekler-----------------");
            //}
            //if (choose==2)
            //{
            //    Console.WriteLine("-----------------Çorbalar-----------------");
            //    Console.WriteLine("Mercimek Çorbası");
            //    Console.WriteLine("Ezogelin Çorbası");
            //    Console.WriteLine("Sebze Çorbası");
            //    Console.WriteLine("Yoğurt Çorbası");
            //    Console.WriteLine("-----------------Çorbalar-----------------");
            //}
            //if (choose == 3)
            //{
            //    Console.WriteLine("-----------------İçecekler-----------------");
            //    Console.WriteLine("Kola");
            //    Console.WriteLine("Ayran");
            //    Console.WriteLine("Çay");
            //    Console.WriteLine("Fanta");
            //    Console.WriteLine("-----------------İçecekler-----------------");
            //}
            //if (choose == 4)
            //{
            //    Console.WriteLine("-----------------Tatlılar-----------------");
            //    Console.WriteLine("Sütlaç");
            //    Console.WriteLine("Muhallebi");
            //    Console.WriteLine("Puding");
            //    Console.WriteLine("-----------------Tatlılar-----------------");
            //}

            #endregion

            #region Switch Case

            //int monthNumber;
            //Console.Write("Bir mevsim numarası giriniz:");
            //monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
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
            //    default: Console.Write("HATA!"); break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi
            //char symbol;
            //double number1, number2, result;

            //Console.Write("1.Sayıyı giriniz:");
            //number1 = double.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı giriniz:");
            //number2 = double.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.Write("Toplam: " + result); break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.Write("Fark: " + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.Write("Çarpım: " + result); break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.Write("Bölüm: " + result); break;

            //    default: Console.Write("Hatalı giriş!"); break;

            //}
            #endregion


            Console.Read();
        }
    }
}
