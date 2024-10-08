using PSD_Lab_Project.Factory;
using PSD_Lab_Project.Handler;
using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace PSD_Lab_Project.Repository
{
    public class HeaderRepo
    {
        static DatabaseEntities db = DatabaseSingleton.GetInstances();

        public static int makeHeader(int userid, DateTime today)
        {
            TransactionHeader transactionHeader = TransactionHeaderFactory.MakeHeader(userid, today);
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();
            return transactionHeader.TransactionID;
        }

        public static List<TransactionHeader> getTransaction(int userid)
        {
            return (from x in db.TransactionHeaders where x.UserID == userid select x).ToList();
        }

        public static List<TransactionHeader> getAllTransaction()
        {
            return db.TransactionHeaders.ToList();
        }
    }
}