using Kur.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kur.Classes
{
    public class Sale
    {
        ConsoleDbProjeEntities db = new ConsoleDbProjeEntities();
        public void MakeSale(string customerName,string customerSurname,int currencyCode,string operationType,decimal currentValue,decimal amount,decimal totalPrice)
        {

            TblOperation t = new TblOperation();
            t.CostumerName= customerName;
            t.CostumerSurname = customerSurname;
            t.CurrencyID = currencyCode;
            t.OperationType = operationType;
            t.CurrentValue = currentValue;
            t.Amount = amount;
            t.TotalPrice = totalPrice;
            t.Date = DateTime.Parse(DateTime.Now.ToLongDateString());
            db.TblOperation.Add(t);
            db.SaveChanges();
            Console.WriteLine("Satış işlemi başarılı bir şekilde gerçekleşti.");

        }
    }
}
