using PSD_Lab_Project.Handler;
using PSD_Lab_Project.Model;
using PSD_Lab_Project.Module;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Linq;

namespace PSD_Lab_Project.Controller
{
    public class UserController
    {
        public static string validateLogin(string username, string password)
        {
            String response = "";
            if (username.Equals("")) response = "Username must be filled";
            else if (password.Equals("")) response = "Password must be filled";
            return response;
        }

        public static string validateRegister(string username, string dob, string gender, string address, string password, string phone)
        {
            String response = "";
            DateTime Today = DateTime.Now;
            string pattern = @"^(?=.*[a-zA-Z])(?=.*\d).+$";
            Regex regex = new Regex(pattern);

            if (username == "") response = "Name must be fill!";
            else if (dob == "") response = "DOB must be fill!";
            else if (address == "") response = "Address must be fill!";
            else if (password == "") response = "Password must be fill!";
            else if (phone == "") response = "Phone must be fill";
            else if (username.Length < 5 || username.Length > 50) response = "Name should be between 5 and 50 characters";
            else if (Math.Truncate(Today.Subtract(Convert.ToDateTime(dob)).TotalDays / 365) < 1) response = "Must be atleast 1 year age";
            else if (gender != "Male" && gender != "Female") response =  "Please select a gender";
            else if (!regex.IsMatch(password)) response =  "Password must be alphanumeric";
            return response;
        }

        public static Response<MsUser> doLogin(string username, string password)
        {
            Response<MsUser> response = new Response<MsUser>();
            response.message = validateLogin(username, password);
            response.status = false;
            response.payload = null;
            if (response.message == "")
            {
                response = UserHandler.doLogin(username, password);
                return response;
            }
            return response;

        }

        public static Response<MsUser> doRegister(string username, string dob, string gender, string address, string password, string phone)
        {
            Response<MsUser> response = new Response<MsUser>();
            response.message = validateRegister(username, dob, gender, address, password, phone);
            response.status = false;
            response.payload = null;
            if (response.message == "")
            {
                response = UserHandler.doRegister(username, Convert.ToDateTime(dob), gender, address, password, phone);
                return response;
            }
            return response;

        }

        public static Response<MsUser> doUpdate(int id, string username, string dob, string gender, string address, string password, string phone)
        {
            Response<MsUser> response = new Response<MsUser>();
            response.message = validateRegister(username, dob, gender, address, password, phone);
            response.status = false;
            response.payload = null;
            if (response.message == "")
            {
                response = UserHandler.doUpdate(id, username, Convert.ToDateTime(dob), gender, address, password, phone);
                return response;
            }
            return response;

        }

        public static MsUser findUserbyUsername(string username)
        {
            return UserHandler.findUserbyUsername(username);
        }
    }
}