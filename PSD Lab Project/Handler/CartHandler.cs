using PSD_Lab_Project.Factory;
using PSD_Lab_Project.Model;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Handler
{
    public class CartHandler
    {
        public static string insertCart(int userid, int stationid, int quantity)
        {
            Cart cart = CartRepository.findCart(userid, stationid);
            if(cart == null)
            {
                CartRepository.insertCart(userid, stationid, quantity);
            }
            else
            {
                CartRepository.updateCart(userid, stationid, quantity + cart.Quantity);
            }
            return "Successfully inserted to cart";
        }

        public static List<object> getCart(int userid)
        {
            return CartRepository.getCart(userid);
        }

        public static void deleteCart(int userid, string stationname, int stationprice, int quantity) 
        {
            int stationid = StationeryRepository.findStationID(stationname,stationprice);
            CartRepository.deleteCart(userid, stationid, quantity);
        }

        public static int findCartQuantity(int userid, int stationid)
        {
            return CartRepository.findQuantity(stationid, userid);
        }

        public static string doUpdate(int userid, int stationid, int quantity)
        {
            CartRepository.updateCart(userid, stationid, quantity);
            return "Successfully update cart";
        }
    }
}