using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_Lab_Project.Module
{
    public class Response<T>
    {
        public string message;
        public bool status;
        public T payload;
    }
}