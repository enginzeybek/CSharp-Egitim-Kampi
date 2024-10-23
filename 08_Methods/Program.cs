using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("İrem Aytepe");
            //    Console.WriteLine("Hakan Altun");
            //    Console.WriteLine("Serel Yereli");
            //}

            //CustomerList();

            //void sum()
            //{
            //    int x = 30;
            //    int y = 20;
            //    int result = x + y;

            //    Console.WriteLine(result);
            //}

            //sum();



            #endregion

            #region void parametreli metodlar

            //void writeCustomerName(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //writeCustomerName("İrem Aytepe");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Adınız: " + name + " " + "Soyadınız: " + surName);
            //}

            //CustomerCard("ENGİN", "ZEYBEK");

            //void Sum(int number1, int number2,int number3) 
            //{
            //    int sonuc = number1 + number2 + number3;

            //    Console.WriteLine(sonuc);
            //}

            //Sum(10, 20, 30);

            #endregion

            #region Değer döndüren metodlar

            //string musteriIsmi()
            //{
            //    return "ENGİN ZEYBEK";
            //}

            //musteriIsmi();

            //string CustomerName()
            //{
            //    Console.Write("İSİM GİRİNİZ: ");

            //    string name = Console.ReadLine();

            //    return name;
            //}

            //string x = CustomerName();

            //Console.WriteLine(x);

            //string studentCard()
            //{
            //    string name = "ENGİN";
            //    string surName = "ZEYBEK";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(studentCard());

            #endregion

            #region Parametreli değer döndüren metodlar

            //string CountryCard(string country,string capital,string flagColor)
            //{
            //    string CardInfo = country + " " + capital + " " + flagColor;

            //    return CardInfo;
            //}

            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı Beyaz"));

            //int avg(int number1,int number2,int number3)
            //{
            //    int avarage = (number1 + number2 + number3) / 3;

            //    return avarage;
            //}

            //int x,y,z;

            //Console.WriteLine("İlk Sayı: ");
            //x = int.Parse(Console.ReadLine());

            //Console.WriteLine("İkinci sayı: ");
            //y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Üçüncü sayı: ");
            //z = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ortalama: " + avg(x,y,z));

            string examResult(string student,int exam1,int exam2)
            {
                int result = (exam1 +  exam2) / 2;

                if (result >= 50)
                {
                    return student + " " + "adlı öğrenci sınavı geçti" + "Ortalama: " + result;
                }
                else
                {
                    return student + " " + "adlı öğrenci sınavdan kaldı" + "Ortalama: " + result;
                }
            }

            Console.WriteLine(examResult("İrem Aytepe", 45, 90));


            #endregion

            Console.Read();
        }
    }
}
