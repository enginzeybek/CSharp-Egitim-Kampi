using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			#region double veri tipi

			//double number;

			//number = 4.85;

			//Console.WriteLine(number);

			//Console.WriteLine("***** Fiyat Listesi *****");
			//Console.WriteLine();

			//double applePrice, orangePrice, peanutPrice, mandalinPrice;

			//applePrice = 14.85;
			//orangePrice = 26.78;
			//peanutPrice = 18.13;
			//mandalinPrice = 7.96;

			//Console.WriteLine("----- Elma birim fiyatı:" + applePrice + "₺");
			//Console.WriteLine("----- Portakal birim fiyatı:" + orangePrice + "₺");
			//Console.WriteLine("----- Fıstık birim fiyatı:" + peanutPrice + "₺");
			//Console.WriteLine("----- Mandalina birim fiyatı:" + mandalinPrice + "₺");

			//Console.WriteLine();
			//Console.WriteLine();

			//double appleGram, orangeGram, peanutGram, mandalinGram;

			//appleGram = 1.485;
			//orangeGram = 2.678;
			//peanutGram = 1.813;
			//mandalinGram = 0.796;

			//double appleTotalPrice = applePrice * appleGram;

			//Console.WriteLine("----- Elma toplam fiyatı:" + appleTotalPrice + "₺");

			//double orangeTotalPrice = orangePrice * orangeGram;

			//Console.WriteLine("----- Portakal toplam fiyatı:" + orangeTotalPrice + "₺");

			//double peanutTotalPrice = peanutGram * peanutPrice;

			//Console.WriteLine("----- Fıstık toplam fiyatı:" + peanutTotalPrice + "₺");

			//double mandalinTotalPrice = mandalinGram * mandalinPrice;

			//Console.WriteLine("----- Mandalina toplam fiyatı:" + mandalinTotalPrice + "₺");

			//double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + 
			//	peanutTotalPrice + mandalinTotalPrice;

			//Console.WriteLine();
			//Console.WriteLine();

			//Console.WriteLine("TOPLAM ALIŞVERİŞ TUTARINIZ:" + shoppingTotalPrice + "₺");


			//Console.Read();

			#endregion

			#region char değişkenler

			//char symbol;

			//symbol = '+';

			//Console.WriteLine(symbol);

			//Console.Read();

			#endregion

			#region Klavyeden string veri girişleri

			//Console.WriteLine("***** HAVA YOLLARI YOLCU BİLGİSİ *****");
			//Console.WriteLine();

			//string passengerName, passengerSurname, passengerCity, passengerAge, passengerIdentityNumber;

			//Console.WriteLine("İsminiz");

			//passengerName = Console.ReadLine();

			//Console.WriteLine("Soy İsminiz");

			//passengerSurname = Console.ReadLine();

			//Console.WriteLine("Yaşadığınız Şehir");

			//passengerCity = Console.ReadLine();

			//Console.WriteLine("Yaşınız");

			//passengerAge = Console.ReadLine();

			//Console.WriteLine("T.C. Numaranız");

			//passengerIdentityNumber = Console.ReadLine();

			//Console.WriteLine("------------------------");

			//Console.WriteLine(passengerName + " " + passengerSurname + " " + passengerCity
			//	+ " " + passengerAge + " " + passengerIdentityNumber);

			//Console.Read();

			#endregion

			#region Klavyeden int veri girişleri

			//int shoePrice, computerPrice, chairPrice, tvPrice;

			//shoePrice = 78;
			//computerPrice = 1200;
			//chairPrice = 550;
			//tvPrice = 1000;

			//int shoeCount, computerCount, chairCount, tvCount;

			//Console.WriteLine("Ayakkabı Sayısını giriniz");

			//shoeCount = int.Parse(Console.ReadLine());

			//Console.WriteLine("Bilgisayar Sayısını giriniz");

			//computerCount = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("Sandalye Sayısını giriniz");

			//chairCount = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("TV Sayısını giriniz");

			//tvCount = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("------------------------------");

			//Console.WriteLine(shoeCount + " " + computerCount + " " + chairCount + " " + tvCount);

			//int shoeTotal, computerTotal, chairTotal, tvTotal;

			//shoeTotal = shoePrice * shoeCount;
			//computerTotal = computerPrice * computerCount;
			//chairTotal = chairPrice * chairCount;
			//tvTotal = tvPrice * tvCount;

			//Console.WriteLine("----------------------------------");

			//Console.WriteLine("Toplam ayakkabı fiyatı:" + shoeTotal + "Toplam bilgisayar fiyatı:" + computerTotal
			//	+ "toplam koltuk fiyatı:" +  chairTotal + "toplam TV fiyatı:" +  tvTotal);

			//Console.Read();

			#endregion

			#region Klavyeden double veri girişleri

			//double exam1, exam2, exam3, result;

			//Console.WriteLine("-----------------");

			//Console.WriteLine("Birinci notu giriniz");

			//exam1 = double.Parse(Console.ReadLine());

			//Console.WriteLine("İkinci notu giriniz");

			//exam2 = Convert.ToDouble(Console.ReadLine());

			//Console.WriteLine("üçüncü notu giriniz");

			//exam3 = Convert.ToDouble(Console.ReadLine());

			//Console.WriteLine("---------------------------");

			//result = (exam1 + exam2 + exam3) / 3;

			//Console.WriteLine("Sonuç:" + result);

			//Console.WriteLine("----------------------");

			//if(result <= 50)
			//{
			//	Console.WriteLine("Kaldı");
			//}
			//else
			//{
			//	Console.WriteLine("Geçti");
			//}

			//Console.Read();
			#endregion

			#region Klavyeden char veri girişleri

			char gender;
			Console.Write("Cinsiyet Giriniz: ");
			gender = char.Parse(Console.ReadLine());

			Console.WriteLine("Seçilen cinsiyet:" + gender);

			Console.Read();
			#endregion
		}
	}
}
