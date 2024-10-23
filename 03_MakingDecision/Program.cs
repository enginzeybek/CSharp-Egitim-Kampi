using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region if karar yapısı

			//Console.Write("LÜTFEN ŞİFRE GİRİNİZ: ");
			//string password;
			//password = Console.ReadLine();
			//if (password == "abcde")
			//{
			//	Console.WriteLine("Şifre doğru");
			//}
			//else
			//{
			//	Console.WriteLine("Şifre yanlış");
			//}

			//string capital, country;

			//Console.Write("Başkenti giriniz: ");

			//capital = Console.ReadLine();

			//Console.Write("Ülkeyi giriniz: ");

			//country = Console.ReadLine();

			//Console.WriteLine("------------");

			//Console.WriteLine("BAŞKENT: " +  capital + " " + "ÜLKE: " + country);

			//if(capital == "ANKARA" & country == "TÜRKİYE")
			//{
			//	Console.WriteLine("BİLGİ DOĞRUDUR");
			//}
			//else
			//{
			//	Console.WriteLine("BİLGİ YANLIŞTIR");
			//}

			//int number;

			//Console.Write("Sayı giriniz: ");

			//number = int.Parse(Console.ReadLine());

			//if(number == 5)
			//{
			//	Console.WriteLine("SAYI DOĞRU");
			//}
			//else
			//{
			//	Console.WriteLine("SAYI YANLIŞ");
			//}

			//int exam1, exam2, ortalama;

			//Console.Write("ilk sınav notu: ");

			//exam1 = int.Parse(Console.ReadLine());

			//Console.Write("ikinci sınav notu: ");

			//exam2 = int.Parse(Console.ReadLine());

			//Console.WriteLine("-----------------");

			//ortalama = (exam1 + exam2) / 2;

			//Console.WriteLine("Ortalama: " + ortalama);

			//Console.WriteLine("-------------------");

			//         if (ortalama < 45)
			//         {
			//	Console.WriteLine("KALDI");
			//         }
			//else if(ortalama >= 45 & ortalama < 85)
			//{
			//	Console.WriteLine("İYİ");
			//}
			//else
			//{
			//	Console.WriteLine("PEK İYİ");
			//}

			//string city;

			//string sonuc;

			//Console.WriteLine("LÜTFEN ŞEHİR GİRİŞİ YAPINIZ");

			//city = Console.ReadLine();

			//         if (city == "BURSA" | city == "İSTANBUL" | city == "ANKARA")
			//         {
			//	sonuc = "Eşleşti";
			//         }
			//         else
			//         {
			//	sonuc = "Eşleşmedi";
			//         }

			//Console.WriteLine(sonuc);

			//Console.Write("KULLANICI ADI GİRİNİZ: ");

			//string userName = Console.ReadLine();

			//         if (userName != "ADMİN")
			//         {
			//	Console.WriteLine("BU KULLANICI KABUL EDİLEMEZ");
			//         }
			//else
			//{
			//	Console.WriteLine("KULLANICI EŞLEŞTİ");
			//}


			//Console.Read();
			#endregion

			#region Mod işlemleri

			//int number;

			//number = 26;

			//int result = number % 5;

			//Console.WriteLine(result);

			//Console.Write("BİRİNCİ SAYI: ");

			//int number1 = int.Parse(Console.ReadLine());

			//Console.Write("İKİNCİ SAYI: ");

			//int number2 = Convert.ToInt32(Console.ReadLine());

			//int result = number1 % number2;

			//Console.WriteLine("Bölümden kalan: " + result);

			//         if (result != 1)
			//         {
			//	Console.WriteLine("Çift Sayı");
			//         }
			//else if (result != 0)
			//{
			//	Console.WriteLine("Tek Sayı");
			//}

			#endregion

			#region Char değişkenler ile karar yapıları

			//char team;

			//Console.WriteLine("TAKIM SEMBOLU: ");

			//team = char.Parse(Console.ReadLine());

			//Console.WriteLine("------------------");

			//         if (team == 'g' | team == 'G')
			//         {
			//	Console.WriteLine("GALATASARAY");
			//         }
			//else if (team == 'f' | team == 'F')
			//{
			//	Console.WriteLine("FENERBAHÇE");
			//}
			//else if (team == 'b' | team == 'B')
			//{
			//	Console.WriteLine("BEŞİKTAŞ");
			//}

			#endregion

			#region Örnek proje uygulaması

			//Console.WriteLine("***** E&Z RESTORAN *****");
			//Console.WriteLine();
			//Console.WriteLine("---------------------------");
			//Console.WriteLine("1-ANA YEMEKLER");
			//Console.WriteLine("2-ÇORBALAR");
			//Console.WriteLine("3-PİZZALAR");
			//Console.WriteLine("4-İÇECEKLER");
			//Console.WriteLine("5-TATLILAR");
			//Console.WriteLine();
			//Console.WriteLine("---------------------------");

			//int menuItem;

			//Console.Write("Menü seçimi: ");

			//menuItem = Convert.ToInt16(Console.ReadLine());

			//         if (menuItem == 1)
			//         {
			//	Console.WriteLine("KURFASULYE");
			//	Console.WriteLine("PİLAV");
			//         }
			//else if(menuItem == 2)
			//{
			//	Console.WriteLine("EZOGELİN");
			//	Console.WriteLine("TARHANA");
			//}
			//else if (menuItem == 3)
			//{
			//	Console.WriteLine("PEYNİRLİ");
			//	Console.WriteLine("KARIŞIK");
			//}
			//else if (menuItem == 4)
			//{
			//	Console.WriteLine("AYRAN");
			//	Console.WriteLine("KOLA");
			//}
			//else if (menuItem == 5)
			//{
			//	Console.WriteLine("BAKLAVA");
			//	Console.WriteLine("SÜTLAÇ");
			//	Console.WriteLine("TAVUK GÖĞSÜ");
			//}

			#endregion

			#region Switch case
			//int number;

			//Console.WriteLine("AY İÇİN BİR NUMARA GİRİNİZ");

			//number = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("------------------------------");

			//switch (number)
			//{
			//	case 1: 
			//		Console.WriteLine("OCAK");
			//		break;
			//	case 2: 
			//		Console.WriteLine("ŞUBAT");
			//		break;
			//	case 3:
			//		Console.WriteLine("MART");
			//		break;
			//	case 4:
			//		Console.WriteLine("NİSAN");
			//		break;
			//	case 5:
			//		Console.WriteLine("MAYIS");
			//		break;
			//	case 6:
			//		Console.WriteLine("HAZİRAN");
			//		break;
			//	case 7:
			//		Console.WriteLine("TEMMUZ");
			//		break;
			//	case 8:
			//		Console.WriteLine("AĞUSTOS");
			//		break;
			//	case 9:
			//		Console.WriteLine("EYLÜL");
			//		break;
			//	case 10:
			//		Console.WriteLine("EKİM");
			//		break;
			//	case 11:
			//		Console.WriteLine("KASIM");
			//		break;
			//	case 12:
			//		Console.WriteLine("ARALIK");
			//		break;
			//	default: 
			//		Console.WriteLine("GEÇERLİ BİR RAKAM GİRİN");
			//		break;
			//}

			Console.Write("BİRİNCİ SAYI: ");

			int number1 = int.Parse(Console.ReadLine());

			Console.Write("İKİNCİ SAYI: ");

			int number2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("İŞLEMİ SEÇ");

			char islem = char.Parse(Console.ReadLine());

			int result = 0;

			switch (islem)
			{
				case '+': result = number1 + number2;
					break;
				case '-': result = number1 - number2;
					break;
				case '*': result = number1 * number2;
					break;
				case '/': result = number1 / number2;
					break;
				case '%': result = number1 % number2;
					break;
				default: Console.WriteLine("GEÇERLİ İŞARET GİRİNİZ");
					break;
			}

			Console.Write("Sonuç: " + result);





			#endregion

			Console.Read();
			
		}
	}
}
