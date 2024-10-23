using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Yazdırma Komutları

			//Console.WriteLine("Merhaba Dünya");

			//Console.Write("Hello World");

			//Console.WriteLine("***** Yemek Kategorileri *****");

			//Console.WriteLine();

			//Console.WriteLine("1-Çorbalar");

			//Console.WriteLine("2-Ana Yemekler");

			//Console.WriteLine("3-Soğuk Başlangıçlar");
			//Console.WriteLine("4-Salatalar");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("6-İçecekler");
			//Console.WriteLine();
			//Console.WriteLine("***** Yemek Kategorileri *****");

			#endregion

			#region String Değişkenler

			//string

			//string name;

			//name = "İrem Aytepe";

			//Console.Write(name);

			//string customerName, customerRegion;

			//customerName = "Engin Zeybek";

			//customerRegion = "Uşak";

			//Console.WriteLine("**** Rezervasyon Kartı *****");

			//Console.WriteLine();

			//Console.WriteLine("Adı:" + " " + customerName + " " + "Şehri:"+ " " + customerRegion);


			#endregion

			#region int değişkenler

			int number = 24;

			Console.WriteLine(number);

			int hamburgerPrice = 300;

			int hamburgerCount = 3;

			int totalPrice = hamburgerPrice * hamburgerCount;

			Console.WriteLine();

			Console.WriteLine("-------------");

			Console.WriteLine("Toplam Fiyat:" + totalPrice + "TL");

			Console.WriteLine("-------------");



			#endregion



			Console.Read();



		}
	}
}
