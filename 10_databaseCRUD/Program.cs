using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_databaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baglanti = "Data Source=ACER-ASPIRE;Initial Catalog=c#_bootcamp;Integrated Security=True;Encrypt=False";//SQL bağlantı linki
            int secim;
            basla:
            Console.WriteLine("1 - Tabloları Düzenle");
            Console.Write("Lütfen yapmak istediğiniz işlemin numarasını giriniz: ");
            secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("1 - Defterler");
                Console.WriteLine("2 - Kalemler");
                Console.WriteLine("3 - Silgiler");
                Console.WriteLine("4 - Kayıtlı Siparişler");
                Console.Write("Düzenleyeceğiniz tablonun numarasını giriniz: ");
                secim = Convert.ToInt32(Console.ReadLine());
                string productID;
                string productName;
                String productPrice;
                string productCount;

                if (secim == 1)
                {
                    Console.WriteLine("1 - Ekle");
                    Console.WriteLine("2 - Sil");
                    Console.WriteLine("3 - Güncelle");
                    Console.WriteLine("4 - Kontrol et");
                    Console.Write("Kategoride yapacağınız işlem numarasını giriniz : ");
                    secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        #region Ekleme İşlemi
                        string sorgu = "insert into product (productCategoryID,productName,productPrice,productCount) values (@p1,@p2,@p3,@p4)"; //Query işlemi

                        Console.WriteLine("----- Defter Ekleme İşlemi -----");
                        Console.Write("Ürünün Adı : ");
                        productName = Console.ReadLine();
                        Console.Write("Ürünün Fiyatı : ");
                        productPrice = Console.ReadLine();
                        Console.Write("Ürün Adeti : ");
                        productCount = Console.ReadLine();

                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", 1);
                        command.Parameters.AddWithValue("@p2", productName);
                        command.Parameters.AddWithValue("@p3", productPrice);
                        command.Parameters.AddWithValue("@p4", productCount);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Console.WriteLine("Ekleme işlemi başarılı...");
                        Console.ReadKey();
                        #endregion
                    }
                    else if (secim == 2)
                    {
                        #region Silme İşlemi
                        string sorgu = "delete from product where productID = (@p1)"; //Query işlemi

                        Console.WriteLine("----- Defter Silme İşlemi -----");
                        Console.Write("Sileceğiniz ürünün ID'sini giriniz : ");
                        productID = Console.ReadLine();
                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();

                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", productID);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Console.WriteLine("Silme işlemi başarılı...");
                        Console.ReadKey();
                        #endregion
                    }
                    else if (secim == 3)
                    {
                        #region Güncelleme İşlemi
                        string sorgu = "update product set productName=(@productName), productPrice=(@productPrice), productCount=(@productCount) where productID = (@p1)"; //Query işlemi

                        Console.WriteLine("----- Defter Güncelleme İşlemi -----");
                        Console.Write("Güncelleyeceğiniz ürünün ID'sini giriniz : ");
                        productID = Console.ReadLine();
                        Console.Write("Ürünün Adı : ");
                        productName = Console.ReadLine();
                        Console.Write("Ürünün Fiyatı : ");
                        productPrice = Console.ReadLine();
                        Console.Write("Ürünün Adeti : ");
                        productCount = Console.ReadLine();
                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", productID);
                        command.Parameters.AddWithValue("@productName", productName);
                        command.Parameters.AddWithValue("@productPrice", productPrice);
                        command.Parameters.AddWithValue("@productCount", productCount);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Console.WriteLine("Güncelleme işlemi başarılı...");
                        Console.ReadKey();
                        #endregion
                    }
                    else if (secim == 4)
                    {
                        #region Kontrol Etme / Read İşlemi
                        string sorgu = "select * from product where productID = (@p1)";//Query işlemi

                        Console.WriteLine("----- Defter Ürünleri Kontrol Etme -----");
                        Console.Write("Kontrol edeceğiniz ürünün ID'sini giriniz : ");
                        productID = Console.ReadLine();

                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", productID);
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
                        #endregion
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Seçim Lütfen Tekrar Deneyiniz..!");
                        Console.WriteLine();
                        goto basla;
                    }
                }
                else if (secim == 2)
                {
                    Console.WriteLine("1 - Ekle");
                    Console.WriteLine("2 - Sil");
                    Console.WriteLine("3 - Güncelle");
                    Console.WriteLine("4 - Kontrol et");
                    Console.Write("Kategoride yapacağınız işlem numarasını giriniz : ");
                    secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        #region Ekleme İşlemi
                        string sorgu = "insert into product (productCategoryID,productName,productPrice,productCount) values (@p1,@p2,@p3,@p4)"; //Query işlemi

                        Console.WriteLine("----- Kalem Ekleme İşlemi -----");
                        Console.Write("Ürünün Adı : ");
                        productName = Console.ReadLine();
                        Console.Write("Ürünün Fiyatı : ");
                        productPrice = Console.ReadLine();
                        Console.Write("Ürün Adeti : ");
                        productCount = Console.ReadLine();

                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", 1);
                        command.Parameters.AddWithValue("@p2", productName);
                        command.Parameters.AddWithValue("@p3", productPrice);
                        command.Parameters.AddWithValue("@p4", productCount);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Console.WriteLine("Ekleme işlemi başarılı...");
                        Console.ReadKey();
                        #endregion
                    }
                    else if (secim == 2)
                    {
                        #region Silme İşlemi
                        string sorgu = "delete from product where productID = (@p1)"; //Query işlemi

                        Console.WriteLine("----- Kalem Silme İşlemi -----");
                        Console.Write("Sileceğiniz ürünün ID'sini giriniz : ");
                        productID = Console.ReadLine();
                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();

                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", productID);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Console.WriteLine("Silme işlemi başarılı...");
                        Console.ReadKey();
                        #endregion
                    }
                    else if (secim == 3)
                    {
                        #region Güncelleme İşlemi
                        string sorgu = "update product set productName=(@productName), productPrice=(@productPrice), productCount=(@productCount) where productID = (@p1)"; //Query işlemi

                        Console.WriteLine("----- Kalem Güncelleme İşlemi -----");
                        Console.Write("Güncelleyeceğiniz ürünün ID'sini giriniz : ");
                        productID = Console.ReadLine();
                        Console.Write("Ürünün Adı : ");
                        productName = Console.ReadLine();
                        Console.Write("Ürünün Fiyatı : ");
                        productPrice = Console.ReadLine();
                        Console.Write("Ürünün Adeti : ");
                        productCount = Console.ReadLine();
                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", productID);
                        command.Parameters.AddWithValue("@productName", productName);
                        command.Parameters.AddWithValue("@productPrice", productPrice);
                        command.Parameters.AddWithValue("@productCount", productCount);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Console.WriteLine("Güncelleme işlemi başarılı...");
                        Console.ReadKey();
                        #endregion
                    }
                    else if (secim == 4)
                    {
                        #region Kontrol Etme / Read İşlemi
                        string sorgu = "select * from product where productID = (@p1)";//Query işlemi

                        Console.WriteLine("----- Kalem Ürünleri Kontrol Etme -----");
                        Console.Write("Kontrol edeceğiniz ürünün ID'sini giriniz : ");
                        productID = Console.ReadLine();

                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", productID);
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
                        #endregion
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Seçim Lütfen Tekrar Deneyiniz..!");
                        Console.WriteLine();
                        goto basla;
                    }
                }
                else if (secim == 3)
                {
                    Console.WriteLine("1 - Ekle");
                    Console.WriteLine("2 - Sil");
                    Console.WriteLine("3 - Güncelle");
                    Console.WriteLine("4 - Kontrol et");
                    Console.Write("Kategoride yapacağınız işlem numarasını giriniz : ");
                    secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        #region Ekleme İşlemi
                        string sorgu = "insert into product (productCategoryID,productName,productPrice,productCount) values (@p1,@p2,@p3,@p4)"; //Query işlemi

                        Console.WriteLine("----- Silgi Ekleme İşlemi -----");
                        Console.Write("Ürünün Adı : ");
                        productName = Console.ReadLine();
                        Console.Write("Ürünün Fiyatı : ");
                        productPrice = Console.ReadLine();
                        Console.Write("Ürün Adeti : ");
                        productCount = Console.ReadLine();

                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", 1);
                        command.Parameters.AddWithValue("@p2", productName);
                        command.Parameters.AddWithValue("@p3", productPrice);
                        command.Parameters.AddWithValue("@p4", productCount);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Console.WriteLine("Ekleme işlemi başarılı...");
                        Console.ReadKey();
                        #endregion
                    }
                    else if (secim == 2)
                    {
                        #region Silme İşlemi
                        string sorgu = "delete from product where productID = (@p1)"; //Query işlemi

                        Console.WriteLine("----- Silgi Silme İşlemi -----");
                        Console.Write("Sileceğiniz ürünün ID'sini giriniz : ");
                        productID = Console.ReadLine();
                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();

                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", productID);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Console.WriteLine("Silme işlemi başarılı...");
                        Console.ReadKey();
                        #endregion
                    }
                    else if (secim == 3)
                    {
                        #region Güncelleme İşlemi
                        string sorgu = "update product set productName=(@productName), productPrice=(@productPrice), productCount=(@productCount) where productID = (@p1)"; //Query işlemi

                        Console.WriteLine("----- Silgi Güncelleme İşlemi -----");
                        Console.Write("Güncelleyeceğiniz ürünün ID'sini giriniz : ");
                        productID = Console.ReadLine();
                        Console.Write("Ürünün Adı : ");
                        productName = Console.ReadLine();
                        Console.Write("Ürünün Fiyatı : ");
                        productPrice = Console.ReadLine();
                        Console.Write("Ürünün Adeti : ");
                        productCount = Console.ReadLine();
                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", productID);
                        command.Parameters.AddWithValue("@productName", productName);
                        command.Parameters.AddWithValue("@productPrice", productPrice);
                        command.Parameters.AddWithValue("@productCount", productCount);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Console.WriteLine("Güncelleme işlemi başarılı...");
                        Console.ReadKey();
                        #endregion
                    }
                    else if (secim == 4)
                    {
                        #region Kontrol Etme / Read İşlemi
                        string sorgu = "select * from product where productID = (@p1)";//Query işlemi

                        Console.WriteLine("----- Silgi Ürünleri Kontrol Etme -----");
                        Console.Write("Kontrol edeceğiniz ürünün ID'sini giriniz : ");
                        productID = Console.ReadLine();

                        SqlConnection connection = new SqlConnection(baglanti);
                        connection.Open();
                        SqlCommand command = new SqlCommand(sorgu, connection);
                        command.Parameters.AddWithValue("@p1", productID);
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
                        #endregion
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Seçim Lütfen Tekrar Deneyiniz..!");
                        Console.WriteLine();
                        goto basla;
                    }
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
                    Console.WriteLine("Yanlış Seçim Lütfen Tekrar Deneyiniz..!");
                    Console.WriteLine();
                    goto basla;
                }
            }
        }
    }
}
