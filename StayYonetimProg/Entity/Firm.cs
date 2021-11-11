using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StayYonetimProg.Entity
{
    public class Firm
    {
        public int id { set; get;}
        public string name { set; get; }
        public string description { set; get; }
        public string address { set; get; }
        public string phoneNumber { set; get; }
        public string firmOpenDate { set; get; }
        public User contact { set; get; }

    }
}