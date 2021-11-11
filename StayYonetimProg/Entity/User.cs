using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StayYonetimProg.Entity
{
    public class User
    {
        public int id { set; get; }
        public string natId { set; get; }
        public string name { set; get; }
        public string surname { set; get; }
        public string email { set; get; }
        public string password { set; get; }

        public UserType userType { set; get; }
        public Department department { set; get; }
        public string mobilePhone { set; get; }
        
    }
}