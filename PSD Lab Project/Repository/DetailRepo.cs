using PSD_Lab_Project.Factory;
using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Repository
{
    public class DetailRepo
    {
        static DatabaseEntities db = DatabaseSingleton.GetInstances();

        public static void makeDetail(List<Cart> cart, int headerid)
        {
            foreach (Cart cartItem in cart)
            {
                TransactionDetail detail = TransactionDetailFactory.MakeHeaderDetail(headerid, cartItem.StationeryID, cartItem.Quantity);
                db.TransactionDetails.Add(detail);
                db.Carts.Remove(cartItem);
                db.SaveChanges();
            }
        }

        public static List<object> getTransaction(int transactionid)
        {
            var cart = (from x in db.TransactionDetails
                        join MsStationeries in db.MsStationeries on x.StationeryID equals MsStationeries.StationeryID       
                        where x.TransactionID == transactionid
                        select new
                        {
                            StationeryName = MsStationeries.StationeryName,
                            StationeryPrice = MsStationeries.StationeryPrice,
                            Quantity = x.Quantity
                        }
                        ).ToList<object>();
            return cart;
        }
    }
}