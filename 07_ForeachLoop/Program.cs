using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //List<string> city = new List<string>() { "İstanbul", "Ankara", "İzmir", "Bursa", "Adana" };



            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("------------");

            //for (int i = 0; i < city.Count; i++)
            //{
            //    Console.WriteLine(city[i]);
            //}

            //List<int> numbers = new List<int>() { 45, 89, 74, 12, 6, 56 };

            //numbers.Sort();
            //numbers.Reverse();

            //for (int i = 0; i <= numbers.Count - 1; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("-----------");

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            // Çift sayılar

            //List<int> numbers = new List<int>() { 45, 89, 74, 12, 6, 56,44,92,47,28 };

            //numbers.Sort();

            //foreach (int item in numbers)
            //{
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //int[] numbers = new int[] { 45, 89, 74, 12, 6, 56, 44, 92, 47, 28 };

            //int sum = 0;

            //foreach (var item in numbers)
            //{
            //    sum += item;
            //}
            //Console.WriteLine("Toplam: " + sum);

            //string word = "MERHABA";

            //foreach (char item in word)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Örnek sınav sistemi uygulaması

            Console.WriteLine("***** Örnek Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();

            // Öğrenci sayısını alma
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Sınıfınızda kaç öğrenci var");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            //Öğrenci isimlerini ve ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz.");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav sonucu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz.");
                    double value = Convert.ToDouble(Console.ReadLine());
                    totalExamResult += value; // notları topluyoruz.
                }

                studentExamAvg[i] = totalExamResult / 3;
            }

            // Sınav ortalamaları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                // Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} Geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} Kaldı");
                }
            }






            #endregion

            Console.Read();
        }
    }
}
