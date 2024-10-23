using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.WriteLine("***** C# VERİTABANLI ÜRÜN-KATEGORİ BİLGİ SİSTEMİ *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("1)Kategoriler");
            Console.WriteLine("2)Ürünler");
            Console.WriteLine("3)Siparişler");
            Console.WriteLine("4)Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz:");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------");

            Console.Read();
        }
    }
}
