using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _09_databaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            basla:// goto etiketi için oluşturuldu.
            int secim;
            Console.WriteLine("1 - Defterler");
            Console.WriteLine("2 - Kalemler");
            Console.WriteLine("3 - Silgiler");
            Console.WriteLine("4 - Kayıtlı Siparişler");
            Console.Write("Lütfen görmek istediğiniz tablonun numarasını giriniz: ");
            secim = Convert.ToInt32(Console.ReadLine());

            string baglanti = "Data Source=ACER-ASPIRE;Initial Catalog=c#_bootcamp;Integrated Security=True;Encrypt=False";//SQL bağlantı linki

            if (secim == 1)
            {
                string sorgu = "select * from product where productCategoryID = 1";//Query işlemi
                SqlConnection connection = new SqlConnection(baglanti);
                connection.Open();
                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine();
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write("  |  " + item.ToString());
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else if (secim == 2)
            {
                string sorgu = "select * from product where productCategoryID = 2";//Query işlemi
                SqlConnection connection = new SqlConnection(baglanti);
                connection.Open();
                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine();
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write("  |  " + item.ToString());
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else if (secim == 3)
            {
                string sorgu = "select * from product where productCategoryID = 3";//Query işlemi
                SqlConnection connection = new SqlConnection(baglanti);
                connection.Open();
                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine();
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write("  |  " + item.ToString());
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else if (secim == 4)
            {
                string sorgu = "select * from orders";//Query işlemi
                SqlConnection connection = new SqlConnection(baglanti);
                connection.Open();
                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine();
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write("  |  " + item.ToString());
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Yanlış seçim...");
                Console.WriteLine();
                goto basla; //Bu etiket koşul yanlış olunca programı tekrardan başlatır.
            }
        }
    }
}
