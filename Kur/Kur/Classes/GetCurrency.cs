using Kur.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Kur.Classes
{
    public class GetCurrency
    {
        ConsoleDbProjeEntities db = new ConsoleDbProjeEntities();

        public void SaveCurrencyDollar()
        {
            ConsoleDbProjeEntities db = new ConsoleDbProjeEntities();
            string today = "https://tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string dolarAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ BanknoteBuying").InnerXml;
            dolarAlis = dolarAlis.Replace(".", ",");

            string dolarSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ BanknoteSelling").InnerXml;
            dolarSatis = dolarSatis.Replace(".", ",");

            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyId = 1;
            t.CurrencyBuying = decimal.Parse(dolarAlis);
            t.CurrencySelling = decimal.Parse(dolarSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();
        }
        public void SaveCurrencyEuro()
        {
            ConsoleDbProjeEntities db = new ConsoleDbProjeEntities();
            string today = "https://tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string euroAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ BanknoteBuying").InnerXml;
            euroAlis = euroAlis.Replace(".", ",");
            string euroSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ BanknoteSelling").InnerXml;
            euroSatis = euroSatis.Replace(".", ",");
            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyId = 2;
            t.CurrencyBuying = decimal.Parse(euroAlis);
            t.CurrencySelling = decimal.Parse(euroSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();
        }
        public void SaveCurrencySterlin()
        {
            ConsoleDbProjeEntities db = new ConsoleDbProjeEntities();
            string today = "https://tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string poundAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ BanknoteBuying").InnerXml;
            poundAlis = poundAlis.Replace(".", ",");
            string poundSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ BanknoteSelling").InnerXml;
            poundSatis = poundSatis.Replace(".", ",");
            TblCurrencyValue t = new TblCurrencyValue();
            t.CurrencyId = 4;
            t.CurrencyBuying = decimal.Parse(poundAlis);
            t.CurrencySelling = decimal.Parse(poundSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyValue.Add(t);
            db.SaveChanges();
        }

    }
}
