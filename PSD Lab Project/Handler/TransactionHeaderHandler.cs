using PSD_Lab_Project.Model;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Handler
{
    public class TransactionHeaderHandler
    {
        public static int makeTransactionHeader(int userid)
        {
            return HeaderRepo.makeHeader(userid, DateTime.Now);
        }
        public static List<TransactionHeader> getTransaction(int userid)
        {
            return HeaderRepo.getTransaction(userid);
        }

        public static List<TransactionHeader> getAllTransaction()
        {
            return HeaderRepo.getAllTransaction();
        }

    }
}