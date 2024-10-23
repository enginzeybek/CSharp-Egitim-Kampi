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
            #region Temel Array Örnekleri
            //string[] colors = new string[4];

            //colors[0] = "Yellow";
            //colors[1] = "Blue";
            //colors[2] = "Purple";
            //colors[3] = "Black";

            //Console.WriteLine(colors.Length);
            //Console.WriteLine(colors.FirstOrDefault());
            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];

            //cities[0] = "London";
            //cities[1] = "Ankara";
            //cities[2] = "Dubai";
            //cities[3] = "Paris";
            //cities[4] = "Washington";

            //Console.WriteLine(cities[4]);

            //int[] number = new int[10];

            //number[0] = 50;
            //number[1] = 100;
            //number[2] = 150;
            //number[3] = 200;
            //number[4] = 250;
            //number[9] = 500;

            //Console.WriteLine(number[5]);

            //string[] cities = { "Bakü", "Moskova", "Erivan", "Pekin" };

            //Console.WriteLine(cities[0]);

            //Console.WriteLine(cities.Length);

            #endregion

            #region Array tüm elemanları listeleme
            //string[] colors = { "Kırmızı", "Sarı", "Yeşil", "Mavi", "Turuncu", "Beyaz", "Siyah" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120, 132, 144, 156, 168, 180, 192, 204,7 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] chars = { 'a', 'b', 'c', '+', '-', '*', '/' };

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            // Dizideki en büyük eleman

            //int[] numbers = {10, 20, 30,40,50,60,70,80,90,100,554};

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers.Max());
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 554 };

            //int maxNumber = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //int[] numbers = { 48, 4, 98, 32, 12, 122, 78, 322 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 48, 4, 98, 32, 12, 122, 78, 322 };

            //Array.Sort(numbers);
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi metodları
            //string[] names = { "Ali", "Veli", "Zeynep", "İrem", "Engin", "Aslı" };

            //int index = Array.IndexOf(names, "Veli");

            //Console.WriteLine(index);

            //int[] numbers = { 1, 82, 78, 54, 96, 321, 12, 47 };

            //int maxNumber = numbers.Max();


            //Console.WriteLine(maxNumber + " " + numbers.Min());


            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1} şehiri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            // Dizideki tüm elemanların toplamı

            //int[] numbers = { 10, 20, 30, 40, 50,};

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine("Toplam: " + sum);



            #endregion

            Console.Read();
        }
    }
}
