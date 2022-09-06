using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Kur.Classes;
using Kur.Model;

namespace Kur
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConsoleDbProjeEntities db =new ConsoleDbProjeEntities();
            GetCurrency getCurrency = new GetCurrency();
            Sale sale = new Sale();
            void CurrencyList()
            {
                Console.WriteLine();
                Console.WriteLine("Döviz Listesi");
                Console.WriteLine();
                var values = db.TblCurrency.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.ID + " " + item.CurrencyName + " " + item.CurrencySymbol);
                }
            }
            void CurrentCurrency()
            {
                Console.WriteLine();
                Console.WriteLine("Güncel Kur Listesi");
                Console.WriteLine();
                var values = db.TblCurrencyValue.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine("Döviz: " + item.TblCurrency.CurrencyName + " Alış:  " + item.CurrencyBuying+" Satış:  "+ item.CurrencySelling);
                }
            }
            void GetCurrencyClass()
            {
                
                getCurrency.SaveCurrencyDollar();
                getCurrency.SaveCurrencyEuro();
                getCurrency.SaveCurrencySterlin();
            }
            Console.WriteLine("Döviz işlemlerine hoşgeldiniz");
            Console.WriteLine();
            Console.WriteLine("Mevcut kullanıcı:  admin" + "   Tarih:"+ DateTime.Now.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine();
            Console.WriteLine("1-Döviz Listesi");
            Console.WriteLine("2-Güncel Kurlar");
            Console.WriteLine("3-Satış Yap");
            Console.WriteLine("4-Müşterilere yapılan satış Hareketleri");
            Console.WriteLine("5-Müşterilerden alınan satış Hareketleri");
            Console.WriteLine("6-Kurları Veri Tabanına Kaydet");
            Console.WriteLine("7-Yardım");
            Console.WriteLine("8-Çıkış Yap");
            Console.WriteLine();
            Console.WriteLine("İşlem Numarası: ");

            string choose;
            choose = Console.ReadLine();

            if (choose == "1" || choose == "01")
            {
                CurrencyList();
            }
            if (choose == "2" || choose == "02")
            {
                CurrentCurrency();
            }
            if (choose == "3" || choose == "03")
            {
                
                Console.WriteLine();
                Console.WriteLine("Müşteri Ad: ");
                string customerName = Console.ReadLine();
                Console.WriteLine("Müşteri Soyad: ");
                string customerSurname = Console.ReadLine();
                Console.WriteLine("Döviz Kod: ");
                int currencyCode = int.Parse(Console.ReadLine());
                Console.WriteLine("İşlem Türü: ");
                string operationType = Console.ReadLine();
                Console.WriteLine("Güncel Kur Değeri: ");
                decimal currentValue = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Alınacak Tutar: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Toplam Ücret: ");
                decimal totalAmount = decimal.Parse(Console.ReadLine());


                sale.MakeSale(customerName, customerSurname, currencyCode, operationType, currentValue, amount, totalAmount);
            }
            if (choose == "4" || choose == "04")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationAlis();

            }
            if (choose == "5" || choose == "05")
            {
                SaleOperation saleOperation = new SaleOperation();
                saleOperation.CustomerSaleOperationSatis();

            }

            if (choose == "6" || choose == "06")
            {
                GetCurrencyClass();
                Console.WriteLine("Dövizler başarılı bir şekilde kaydedildi");

            }
            if (choose == "7" || choose == "07")
            {
                
                Console.WriteLine("Tüm Sorular için mail@mail.com'a mesaj atabilirsiniz.");

            }
            if (choose == "8" || choose == "08")
            {

                Environment.Exit(0);

            }

            Console.ReadLine();
        }
    }
}
