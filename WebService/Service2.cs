using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Service2 : IService2
    {
        public string GetString()
        {
            return "abcded";
        }
    }
}