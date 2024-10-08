using PSD_Lab_Project.Handler;
using PSD_Lab_Project.Model;
using PSD_Lab_Project.Module;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Controller
{
    public class CartController
    {
        public static string validateInsert(string quantity)
        {
            String response = "Quantity must be more than zero";
            if (quantity == "") response = "Quantity mus be fill";
            else if (Convert.ToInt32(quantity) > 0) response = "";
            return response;
        }

        public static string doInsert(int userid, int stationid, string quantity)
        {

            string response = validateInsert(quantity);
            if (response == "")
            {
                response = CartHandler.insertCart(userid,stationid, Convert.ToInt32(quantity));
                return response;
            }
            return response;

        }

        public static string doUpdate(int userid, int stationid, string quantity)
        {

            string response = validateInsert(quantity);
            if (response == "")
            {
                response = CartHandler.doUpdate(userid, stationid, Convert.ToInt32(quantity));
                return response;
            }
            return response;

        }

        public static List<object> getCart(int userid)
        {
            return CartHandler.getCart(userid);
        }

        public static void deleteCart(int userid, string stationname, int stationprice, int quantity)
        {
            CartHandler.deleteCart(userid,stationname, stationprice, quantity);
        }

        public static int findCartQuantity(int userid, int stationid)
        {
            return CartHandler.findCartQuantity(stationid, userid);
        }
    }
}