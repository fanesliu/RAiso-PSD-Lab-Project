using PSD_Lab_Project.Handler;
using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Controller
{
    public class TransactionController
    {
        public static void doTransaction(int userid)
        {
            int headerid = TransactionHeaderHandler.makeTransactionHeader(userid);
            TransactionDetailHandler.checkout(userid, headerid);
        }

        public static List<TransactionHeader> getTransactionHeader(int userid)
        {
            return TransactionHeaderHandler.getTransaction(userid); 
        }

        public static List<object> getTransactionDetail(int transactionid)
        {
            return TransactionDetailHandler.getTransaction(transactionid);
        }

        public static List<TransactionHeader> getAllTransaction()
        {
            return TransactionHeaderHandler.getAllTransaction();
        }
    }
}