using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Factory
{
    public class StationeryFactory
    {
        public static MsStationery CreateStationery(string name, int price)
        {
            return new MsStationery()
            {
                StationeryName = name,
                StationeryPrice = price
            };
        }
    }
}