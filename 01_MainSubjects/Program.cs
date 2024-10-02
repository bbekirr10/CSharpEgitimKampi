using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("--------YEMEK MENÜ LİSTESİ--------");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemek");
            //Console.WriteLine("3-Salatalar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("--------YEMEK MENÜ LİSTESİ--------");

            #endregion

            #region String Değişkenler
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail;
            //string customerDistrict, customerCity;

            //customerName = "Bekir";
            //customerSurname = "Yavuz";
            //customerPhone = "900 500 40 50";
            //customerEmail = "deneme@gmail.com";
            //customerDistrict = "Kadıköy";
            //customerCity = "İstanbul";

            //Console.WriteLine("*****MÜŞTERİ BİLGİ*****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri:"+customerName+" "+customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email:" + customerEmail);
            //Console.WriteLine("Adres:"+customerDistrict+"/"+customerCity);
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();

            //customerName = "Furkan";
            //customerSurname = "Yavuz";
            //customerPhone = "800 600 50 40";
            //customerEmail = "test@gmail.com";
            //customerDistrict = "Sapanca";
            //customerCity = "Sakarya";


            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email:" + customerEmail);
            //Console.WriteLine("Adres:" + customerDistrict + "/" + customerCity);
            //Console.WriteLine("-----------------------------------------");

            #endregion

            #region İnt Değişkenler


            int soupPrice = 100;
            int pizzaPrice = 250;
            int sweetPrice = 150;
            int saladPrice = 70;
            int cokePrice = 45;
            int waterPrice = 10;

            Console.WriteLine("****************************");
            Console.WriteLine("-----MENÜ FİYAT LİSTESİ------");
            Console.WriteLine("Çorba: " + soupPrice + "TL");
            Console.WriteLine("Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("Tatlı: "+sweetPrice+"TL");
            Console.WriteLine("Salata: " + saladPrice + "TL");
            Console.WriteLine("Kola: " + cokePrice + "TL");
            Console.WriteLine("Su: " + waterPrice + "TL");
            Console.WriteLine("****************************");

            int soupCount = 1;
            int pizzaCount = 2;
            int sweetCount = 3;
            int saladCount = 1;
            int cokeCount = 2;
            int waterCount = 1;

            int totalSoupPrice;
            int totalPizzaPrice;
            int totalSweetPrice;
            int totalSaladPrice;
            int totalCokePrice;
            int totalWaterPrice;

            totalSoupPrice = soupCount * soupPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalSweetPrice = sweetCount * sweetPrice;
            totalSaladPrice = saladCount * saladPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;

            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine("-----Hesap-----");
            Console.WriteLine("Çorba Tutarı: " + totalSoupPrice+ "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice+ "TL");
            Console.WriteLine("Tatlı Tutarı: " + totalSweetPrice+ "TL");
            Console.WriteLine("Salata Tutarı: " + totalSaladPrice+ "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice+ "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice+ "TL");

            int totalPrice = totalSoupPrice + totalPizzaPrice + totalSweetPrice + totalSaladPrice + totalCokePrice + totalWaterPrice;
            Console.WriteLine("Toplam Tutar: "+totalPrice+  "TL");
            Console.WriteLine("****************************");
            #endregion

            Console.Read();
        }
    }
}
