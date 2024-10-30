using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD : Create,Read,Update,Delete

            Console.WriteLine("***** MENÜ SİPARİŞ İŞLEM BEDELİ *****");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");

            #region Kategori ekleme işlemi
            //Console.WriteLine("EKLEMEK İSTEDİĞİNİZ KATEGORİ ADI");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-2S32U8I2;initial Catalog=EgitimKampiDb;integrated Security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Tbl_Category (CategoryName) values (@p1)",connection);

            //command.Parameters.AddWithValue("@p1", categoryName);

            //command.ExecuteNonQuery(); // koşulsuz olarak sorguyu çalıştırır. Bunu kullandık mı aşağıdakilere gerek kalmıyor.

            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //DataTable table = new DataTable();

            //adapter.Fill(table);

            //connection.Close();

            //Console.WriteLine("Kategori başarı ile eklendi.");

            #endregion

            #region ürün ekleme işlemi

            //Console.WriteLine("***** EKLEMEK İSTEDİĞİNİZ ÜRÜN ADI");
            //Console.WriteLine();
            //string productName = Console.ReadLine();
            //Console.WriteLine("***** EKLEMEK İSTEDİĞİNİZ ÜRÜN FİYATI");
            //Console.WriteLine();
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("***** EKLEMEK İSTEDİĞİNİZ ÜRÜN STOK DURUMU");
            //Console.WriteLine();
            ////bool productStatus = Convert.ToBoolean(Console.ReadLine()); // bu hata verdi, bende alternatif aşağıyı yazdım.

            //string input = Console.ReadLine();

            //bool productStatus = false;

            //if (input == "1")
            //{
            //    productStatus = true;
            //    Console.WriteLine("Ürün durumu: Aktif");
            //}
            //else if (input == "0")
            //{
            //    productStatus = false;
            //    Console.WriteLine("Ürün durumu: Pasif");
            //}
            //else
            //{
            //    Console.WriteLine("Geçerli bir değer giriniz: 1 veya 0.");
            //}

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-2S32U8I2;initial Catalog=EgitimKampiDb;integrated Security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Tbl_Product (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)",connection);

            //command.Parameters.AddWithValue("@p1",productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", productStatus);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("ÜRÜN EKLENDİ");

            #endregion

            #region ürün listeleme işlemi

            //Console.WriteLine("***** Ürünleri Listele");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("ÜRÜN LİSTESİ");
            //Console.WriteLine();

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-2S32U8I2;initial Catalog=EgitimKampiDb;integrated Security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("select * from Tbl_Product", connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //DataTable table = new DataTable();

            //adapter.Fill(table);

            //foreach (DataRow row in table.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();





            #endregion

            #region ürün silme işlemi

            //Console.WriteLine("SİLMEK İSTEDİĞİNİZ ÜRÜNÜN ID NUMARASINI GİRİNİZ");

            //int productId = Convert.ToInt32(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-2S32U8I2;initial Catalog=EgitimKampiDb;integrated Security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("delete from Tbl_Product where ProductId = @p1",connection);

            //command.Parameters.AddWithValue("@p1", productId);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("SİLME İŞLEMİ GERÇEKLEŞTİ");

            #endregion

            #region ürün güncelleme işlemi

            Console.WriteLine("GÜNCELLENECEK ÜRÜN ID NUMARASINI GİRİNİZ");
            int productId = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("DEĞİŞTİRİLECEK SÜTUNU SEÇ -ProductName = name,-ProductPrice = price,her ikisi de güncellenecekse = nameprice" + " " +
                "GİRİŞİ YAPINIZ");
            string updateOption = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------");

            string productName = null;
            decimal? productPrice = null;
            
            Console.WriteLine();

            if (updateOption == "name")
            {
                Console.WriteLine($"ÜRÜN ID NUMARASI {productId} OLAN ÜRÜNÜN YENİ İSMİNİ GİRİNİZ");
                productName = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------------------------");
            }
            else if (updateOption == "price")
            {
                Console.WriteLine($"ÜRÜN ID NUMARASI {productId} OLAN ÜRÜNÜN YENİ FİYATINI GİRİNİZ");
                productPrice = Convert.ToDecimal(Console.ReadLine());
            }
            else if (updateOption == "nameprice")
            {
                Console.WriteLine($"ÜRÜN ID NUMARASI {productId} OLAN ÜRÜNÜN YENİ İSMİNİ GİRİNİZ");
                productName = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------------------------");

                Console.WriteLine($"ÜRÜN ID NUMARASI {productId} OLAN ÜRÜNÜN YENİ FİYATINI GİRİNİZ");
                productPrice = Convert.ToDecimal(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen tekrar deneyin.");
            }

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-2S32U8I2;initial Catalog=EgitimKampiDb;integrated Security=true");

            connection.Open();

            // SqlCommand command = new SqlCommand("UPDATE Tbl_Product SET ProductName = @urunadi, ProductPrice = @urunfiyatı WHERE ProductId = @urunId", connection);

            if (!string.IsNullOrEmpty(productName))
            {
                SqlCommand command1 = new SqlCommand("UPDATE Tbl_Product SET ProductName = @urunadi WHERE ProductId = @urunId", connection);
                command1.Parameters.AddWithValue("@urunId", productId);
                command1.Parameters.AddWithValue("@urunadi", productName);
                command1.ExecuteNonQuery();
            }

            if (productPrice.HasValue)
            {
                SqlCommand command2 = new SqlCommand("UPDATE Tbl_Product SET ProductPrice = @urunfiyati WHERE ProductId = @urunId", connection);
                command2.Parameters.AddWithValue("@urunId", productId);
                command2.Parameters.AddWithValue("@urunfiyati", productPrice.Value);
                command2.ExecuteNonQuery();
            }

            //SqlCommand command1 = new SqlCommand("update Tbl_Product set ProductName = @urunadi where ProductId = @urunId",connection);
            //SqlCommand command2 = new SqlCommand("update Tbl_Product set ProductPrice = @urunfiyati where ProductId = @urunId",connection);

            //command1.Parameters.AddWithValue("@urunId",productId);
            //command2.Parameters.AddWithValue("@urunId",productId);
            //command1.Parameters.AddWithValue("@urunadi", name);
            //command2.Parameters.AddWithValue("@urunfiyati",price);
            //command1.Parameters.AddWithValue("@urunadi", nameprice);
            //command2.Parameters.AddWithValue("@urunfiyati", nameprice);


            //command1.ExecuteNonQuery();
            //command2.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine($"ÜRÜN ID NUMARASI {productId} OLAN ÜRÜN GÜNCELLENMİŞTİR");

            #endregion
            Console.Read();
        }
    }
}
