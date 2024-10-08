using PSD_Lab_Project.Model;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Handler
{
    public class TransactionDetailHandler
    {
        public static void checkout(int userid, int transactionid)
        {
            List<Cart> cart = CartRepository.getAllCartByID(userid);
            DetailRepo.makeDetail(cart, transactionid);
        }

        public static List<object> getTransaction(int transactionid)
        {
            return DetailRepo.getTransaction(transactionid);
        }
    }
}