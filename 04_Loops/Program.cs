using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Merhaba");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}



            //for (int i = 1; i < 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Ekrana sayı giriniz: ");

            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("YAŞASIN CUMHURİYET");
            //}




            #endregion

            #region For ile karar yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalValue = 0;

            //for (int i = 1; i < 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int ciftToplam = 0;

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ciftToplam += i;

            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("+---------------");

            //Console.WriteLine(ciftToplam);

            // 1 ile 50 arasında 7 bölünebilen kaç adet sayı var.

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count ++;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("+--------------------");
            //Console.Write(count);

            //int bakteri = 1;
            //for (int i = 0; i < 24; i++)
            //{
            //    bakteri *= 2; // Her saat başında bakteri sayısını ikiye katla
            //}

            //Console.WriteLine("24 saat sonra bakteri sayısı: " + bakteri);




            #endregion

            #region While Döngüsü

            //int i = 0;

            //while (i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // 1 ile 10 arasında 3'e tam bölünen sayılar

            //int sayi = 1;

            //while (sayi <= 10)
            //{
            //    if (sayi % 3 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }

            //    sayi++;
            //}

            // 1 ile 10 arasındaki sayıların toplamı

            //int i = 1;
            //int toplam = 0;

            //while (i <= 10)
            //{
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine(toplam);



            #endregion

            #region Örnek sınav sorusu
            // klavyeden girilen 3 basamaklı sayının rakamları toplamını yazınız.

            Console.WriteLine("ÜÇ BASAMAKLI SAYI GİRİNİZ");

            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            int ones, tens, hundreds;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;
            
            sum = ones + tens + hundreds;

            Console.WriteLine(ones + "+" + tens + "+" + hundreds + "=" + sum);


            
            #endregion

            Console.Read();
        }
    }
}
