using PSD_Lab_Project.Model;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Handler
{
    public class StationeryHandler
    {
        public static List<MsStationery> getAllStationey()
        {
            return StationeryRepository.getAllStationery();
        }

        public static void doDeleteStationery(int id)
        {
            StationeryRepository.deleteStationery(id);
        }

        public static MsStationery findStationery(int id)
        {
            return StationeryRepository.findStationery(id);
        }
        public static int findStationeryId(string name, int price)
        {
            return StationeryRepository.findStationID(name, price);
        }
        public static string updateStationery(string name, int price, int stationid)
        {
            StationeryRepository.updateStationery(stationid, name, price);
            return "Successfully Updated";
        }

        public static string insertStationery(string name, int price)
        {
            StationeryRepository.insertStationery(name, price);
            return "Successfully Inserted";
        }
    }
}