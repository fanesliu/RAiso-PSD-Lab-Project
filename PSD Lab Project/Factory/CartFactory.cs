using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Factory
{
    public class CartFactory
    {
        public static Cart MakeCart(int userid, int stationid, int quatity)
        {
            return new Cart()
            {
                UserID = userid,
                StationeryID = stationid,
                Quantity = quatity
            };
        }
    }
}