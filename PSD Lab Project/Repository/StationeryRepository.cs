using PSD_Lab_Project.Factory;
using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Repository
{
    public class StationeryRepository
    {
        static DatabaseEntities db = DatabaseSingleton.GetInstances();

        public static List<MsStationery> getAllStationery()
        {
            return db.MsStationeries.ToList();
        }

        public static int findStationID(string name, int price)
        {
            return (from x in db.MsStationeries where x.StationeryName == name && x.StationeryPrice == price 
                    select x.StationeryID).FirstOrDefault();
        }

        public static void insertStationery(string name, int price)
        {
            MsStationery stationery = StationeryFactory.CreateStationery(name, price);
            db.MsStationeries.Add(stationery);
            db.SaveChanges();
        }

        public static MsStationery findStationery(int id)
        {
            return db.MsStationeries.Find(id);
        }

        public static void deleteStationery(int id)
        {
            MsStationery stationery = db.MsStationeries.Find(id);
            db.MsStationeries.Remove(stationery);
            db.SaveChanges();
        }

        public static void updateStationery(int id, string name, int price)
        {
            MsStationery stationery = findStationery(id);
            stationery.StationeryName = name;
            stationery.StationeryPrice = price;
            db.SaveChanges();
        }

    }
}