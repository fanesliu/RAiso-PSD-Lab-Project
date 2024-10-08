using PSD_Lab_Project.Model;
using PSD_Lab_Project.Module;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;

namespace PSD_Lab_Project.Handler
{
    public class UserHandler
    {
        public static Response<MsUser> doLogin(String username, String password)
        {
            MsUser user = UserRepo.getUser(username);
            if (user == null)
            {
                return new Response<MsUser>
                {
                    message = "User not found",
                    status = false,
                    payload = null
                };
            }
            else if (user.UserPassword != password)
            {
                return new Response<MsUser>
                {
                    message = "Password does not match",
                    status = false,
                    payload = null
                };
            }
            else if (user != null)
            {
                return new Response<MsUser>
                {
                    message = "Success",
                    status = true,
                    payload = user
                };
            }
            return new Response<MsUser>
            {
                message = "Unexpected Error",
                status = false,
                payload = null
            };

        }

        public static Response<MsUser> doRegister(string username, DateTime dob, string gender, string address, string password, string phone)
        {
            MsUser user = UserRepo.getUser(username);
            if (user == null)
            {
                UserRepo.insertCustomer(username, dob, gender, address, password, phone);
                return new Response<MsUser>
                {
                    message = "User was successfully register",
                    status = true,
                    payload = null
                };
            }
            return new Response<MsUser>
            {
                message = "Username already exist",
                status = false,
                payload = null
            };
        }

        public static MsUser findUserbyUsername(string username)
        {
            return UserRepo.getUser(username);
        }
        public static Response<MsUser> doUpdate(int id, string username, DateTime dob, string gender, string address, string password, string phone)
        {
            MsUser user = UserRepo.getUser(username);
            if (user == null || user.UserId == id)
            {
                UserRepo.updateUser(id, username, dob, gender, address, password, phone);
                return new Response<MsUser>
                {
                    message = "User was successfully update",
                    status = true,
                    payload = null
                };
            }
            return new Response<MsUser>
            {
                message = "Username already exist",
                status = false,
                payload = null
            };
        }

    }
}