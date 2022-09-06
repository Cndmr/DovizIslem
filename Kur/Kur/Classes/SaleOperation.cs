using Kur.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kur.Classes
{
    public class SaleOperation
    {
        ConsoleDbProjeEntities db = new ConsoleDbProjeEntities();

        public void CustomerSaleOperationAlis()
        {
            var values = db.TblOperation.Where(x => x.OperationType == "alış").ToList();
            foreach (var item in values)
            {
                Console.WriteLine("ID: "+item.ID+"Müşteri: "+ item.CostumerName + " "+ item.CostumerSurname+" Döviz: "+ item.TblCurrency.CurrencyName+" işlem türü: "
                    +item.OperationType+" Kur birim Tutarı: "+item.CurrentValue +" Alınan Tutar: "+item.Amount+"Toplam Tutar: "+item.TotalPrice);

            }
        }
        

        public void CustomerSaleOperationSatis()
        {
            var values = db.TblOperation.Where(x => x.OperationType == "Satış").ToList();
            foreach (var item in values)
            {
                Console.WriteLine("ID: " + item.ID + "Müşteri: " + item.CostumerName + " " + item.CostumerSurname + " Döviz: " + item.TblCurrency.CurrencyName + " işlem türü: "
                    + item.OperationType + " Kur birim Tutarı: " + item.CurrentValue + " Alınan Tutar: " + item.Amount + "Toplam Tutar: " + item.TotalPrice);

            }
        }


    }
}
