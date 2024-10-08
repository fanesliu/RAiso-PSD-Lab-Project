using PSD_Lab_Project.Factory;
using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Repository
{
    public class CartRepository
    {
        static DatabaseEntities db = DatabaseSingleton.GetInstances();

        public static int findQuantity(int stationID, int userid)
        {
            return (from x in db.Carts where x.UserID == userid && x.StationeryID == stationID select x.Quantity).FirstOrDefault();
        }
        public static void deleteCart(int userid, int stationeryid, int quantity)
        {
            Cart cart = (from x in db.Carts where x.UserID == userid && x.StationeryID == stationeryid && x.Quantity == quantity select x).FirstOrDefault();
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
        public static void insertCart(int userid, int stationid, int quantity)
        {
            Cart cart = CartFactory.MakeCart(userid, stationid, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static void updateCart(int userid, int stationid, int quantity)
        {
            Cart cart = (from x in db.Carts where x.UserID == userid && x.StationeryID == stationid select x).FirstOrDefault();
            db.Carts.Remove(cart);
            db.SaveChanges();
            cart.Quantity = quantity;
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static List<Cart> getAllCartByID(int id)
        {
            return (from x in db.Carts where x.UserID == id select x).ToList();
        }

        public static Cart findCart(int userid, int stationid)
        {
            return (from x in db.Carts where x.UserID == userid && x.StationeryID == stationid select x).FirstOrDefault();
        }

        public static List<object> getCart(int userid)
        {
            var cart = (from x in db.Carts join MsStationeries in db.MsStationeries on x.StationeryID equals MsStationeries.StationeryID 
                        where x.UserID == userid
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