using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail MakeHeaderDetail(int transactionid, int stationid, int quantity)
        {
            return new TransactionDetail()
            {
                TransactionID = transactionid,
                StationeryID = stationid,
                Quantity = quantity
            };
        }
    }
}