using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader MakeHeader(int userid, DateTime TransactionDate)
        {
            return new TransactionHeader()
            {
                UserID = userid,
                TransactionDate = TransactionDate
            };
        }
    }
}