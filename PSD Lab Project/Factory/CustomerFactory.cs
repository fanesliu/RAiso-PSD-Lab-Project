using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Factory
{
    public class CustomerFactory
    {
        public static MsUser MakeCustomer(string username, DateTime dob, string gender, string address, string password, string phone)
        {
            return new MsUser()
            {
                UserName = username,
                UserDOB = dob,
                UserGender = gender,
                UserAddress = address,
                UserPassword = password,
                UsePhone = phone,
                UserRole = "Customer"
            };
        }
    }
}