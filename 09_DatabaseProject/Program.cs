using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net

            Console.WriteLine("***** C# VERİ TABANLI ÜRÜN-CATEGORY BİLGİ SİSTEMİ *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("LÜTFEN GETİRMEK İSTEDİĞİNİZ TABLO NUMARASINI GİRİNİZ: ");
            tableNumber = Console.ReadLine();

            Console.WriteLine("-----------------------------------------------");

            SqlConnection connection = new 
                SqlConnection("Data Source=LAPTOP-2S32U8I2;initial Catalog=EgitimKampiDb;integrated Security=true");

            connection.Open();

            SqlCommand command = new SqlCommand("select * from Tbl_Category",connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
