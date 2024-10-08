using PSD_Lab_Project.Factory;
using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Repository
{
    public class UserRepo
    {
        static DatabaseEntities db = DatabaseSingleton.GetInstances();

        public static void updateUser(int id, string username, DateTime dob, string gender, string address, string password, string phone)
        {
            MsUser user = getUserbyid(id);
            user.UserName = username;
            user.UserDOB = dob;
            user.UserGender = gender;
            user.UserAddress = address;
            user.UserPassword = password;
            user.UsePhone = phone;
            db.SaveChanges();
        }

        public static MsUser getUser(string username)
        {
            return (from x in db.MsUsers where x.UserName == username select x).FirstOrDefault();

        }
        public static MsUser getUserbyid(int id)
        {
            return (from x in db.MsUsers where x.UserId == id select x).FirstOrDefault();
        }

        public static void insertCustomer(string username, DateTime dob, string gender, string address, string password, string phone)
        {
            MsUser user = CustomerFactory.MakeCustomer(username, dob, gender, address, password, phone);
            db.MsUsers.Add(user);
            db.SaveChanges();
        }
    }
}