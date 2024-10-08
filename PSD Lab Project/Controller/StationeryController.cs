using PSD_Lab_Project.Handler;
using PSD_Lab_Project.Model;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Linq;

namespace PSD_Lab_Project.Controller
{
    public class StationeryController
    {
        public static string validate(string name, string price)
        {
            Regex regex = new Regex("^[0-9]+$");
            String response = "";
            if (name == "")
            {
                response = "Name must be fill";
            }
            else if (name.Length < 3 || name.Length > 50)
            {
                response = "Name must between 3-50 characters";
            }
            else if (price == "")
            {
                response = "Price must be fill";
            }
            else if (regex.IsMatch(price) == false)
            {
                response = "Price must be numeric";
            }
            else if (Convert.ToInt32(price) < 2000)
            {
                response = "Price must be greater or equal to 2000";
            }
            return response;
        }



        public static string doUpdate(string name,string price, int stationid)
        {
            string response = validate(name, price);
            if (response == "")
            {
                response = StationeryHandler.updateStationery(name, Convert.ToInt32(price),stationid);
                return response;
            }
            return response;

        }

        public static string doInsert(string name, string price)
        {
            string response = validate(name, price);
            if (response == "")
            {
                response = StationeryHandler.insertStationery(name, Convert.ToInt32(price));
                return response;
            }
            return response;

        }

        public static int findStationeryId(string name, int price)
        {
            return StationeryHandler.findStationeryId(name, price);
        }

        public static MsStationery findStationery(int id)
        {
            return StationeryHandler.findStationery(id);
        }


        public static List<MsStationery> getAllStationey()
        {
            return StationeryHandler.getAllStationey();
        }

        public static void doDeleteStationery(int id)
        {
            StationeryHandler.doDeleteStationery(id);
        }
    }
}