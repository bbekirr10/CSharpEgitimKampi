using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //
            //Geriye Değer Döndürmeyen Metotlar
            //Customer--> Listele,Ekle,Sil,Güncelleme

            //void customerName()
            //{
            //    Console.WriteLine("Bekir Yavuz");
            //    Console.WriteLine("Bekir Yavuz");
            //    Console.WriteLine("Bekir Yavuz");
            //    Console.WriteLine("Ayşe Çınar");
            //    Console.WriteLine("Ayşe Çınar");
            //    Console.WriteLine("Ayşe Çınar");
            //}
            //customerName();
            //customerName();

            //void sum()
            //{
            //    int x = 5;
            //    int z = 10;
            //    int result = x + z;
            //    Console.Write(result);
            //}
            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void customerList(string customerName, string customerSurname)
            //{
            //    Console.WriteLine("Müşteri:"+customerName+" "+customerSurname);
            //}
            //customerList("Bekir","Yavuz");
            //customerList("Ali","Çınar");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            //void sum(int number1, int number2,  int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.Write(result);
            //}
            //sum(10,20,30);
            #endregion

            #region  Geriye Değer Döndüren Metotlar

            //string customer()
            //{
            //    return "Bekir Yavuz";
            //}
            //customer();

            //string studentCard()
            //{
            //    string name = "Bekir";
            //    string surname = "Yavuz";

            //    return name + " " + surname;
            //}
            //Console.Write(studentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string countryCard(string countryName, string capital, string countryFlag)
            //{
            //    string countryInfo = "Ülke:" + countryName + " - Başkent:" + capital + " - Bayrak:" + countryFlag;
            //    return countryInfo;
            //}
            //Console.Write("Ülke adı giriniz:");
            //string cName = Console.ReadLine();

            //Console.Write("Başkentini giriniz:");
            //string cCapital = Console.ReadLine();

            //Console.Write("Bayrak renklerini giriniz:");
            //string cFlag = Console.ReadLine();

            //Console.WriteLine(countryCard(cName,cCapital,cFlag));

            //Console.Write(countryCard("Türkiye","Ankara","Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(10,20)); 
            //Console.WriteLine(Sum(30,40)); 
            //Console.WriteLine(Sum(30,20)); 

            #endregion

            #region Örnek
         
            string examResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result>=50)
                {
                    return student+ " isimli öğrenci sınavı geçti "+"Ortalama:"+result;
                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi " + "Ortalama:" + result;
                }
            }
            Console.WriteLine(examResult("Bekir Yavuz",50,30,20));
            Console.WriteLine(examResult("Bekir Yavuz",10,50,50));
            Console.WriteLine(examResult("Bekir Yavuz",80,20,50));
            #endregion

            Console.Read();
        }
    }
}
