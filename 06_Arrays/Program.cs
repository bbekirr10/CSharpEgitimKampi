using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] names = new string[5];
            //names[0] = "Bekir";
            //names[1] = "Ali";
            //names[2] = "Muhammet";
            //names[3] = "Mehmet";
            //names[4] = "Ayşe";
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[4]);

            //int[] numbers = new int[6];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[3] = 3;
            //numbers[4] = 4;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[5]);

            //string[] cities = {"Ankara","Paris","Londra","Milano"};
            //Console.WriteLine(cities[0]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Siyah", "Beyaz", "Kırmızı", "Sarı", "Lacivert" };

            //for (int i=0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 10, 20,30,40,50,35,32,561,999,17,15,24,21 };
            //Console.WriteLine("İkiye tam bölünen sayılar....");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = {'a','b','c','d','+','-','*','/' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myNumber = {10,20,5,55,35,32,61,81,625,501,803,2,14 };
            //int maxNumber = myNumber[0];

            //for (int i = 0; i<myNumber.Length; i++)
            //{
            //    if (myNumber[i] > maxNumber)
            //    {
            //        maxNumber = myNumber[i];
            //    }
            //}
            //Console.Write(maxNumber);

            //string[] persons = {"Ali","Veli","Mehmet","Ayşe","Hakan","Mete","Alparslan"};
            //Console.Write(persons.Length);

            //int[] numbers = {10,2,5,3,21,1,53,92,82,111 };
            //Array.Sort(numbers);
            //for (int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 10, 2, 5, 3, 21, 1, 53, 92, 82, 111 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotlar

            //string[] names = { "Ayşe","Mehmet","Murat","Selim","Selin","Sude","Cengiz" };
            //int index = Array.IndexOf(names,"Cengiz");
            //Console.Write(index);

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //Console.Write("Dizinin en büyük elemanı:" + numbers.Max() + " Dizinin en küçük elemanı:" + numbers.Min()) ;
            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string [5];

            //for (int i=0; i<cities.Length; i++)
            //{
            //    Console.Write($"{i+1}.Şehri Giriniz:");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("-----------------------");
            //Console.WriteLine();

            //Console.WriteLine("Girdiğiniz şehirlerin listesi....");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = {10,20,30,40,50};
            //int sum = 0;
            //for (int i=0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.Write(sum);

            int[] numbers = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            Console.WriteLine("Çift Sayılar");
            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Tek Sayılar");
            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion

            Console.Read();
        }
    }
}
