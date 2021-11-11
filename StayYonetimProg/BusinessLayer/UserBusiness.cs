using StayYonetimProg.AccessLayer;
using StayYonetimProg.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace StayYonetimProg.BusinessLayer
{
    public class UserBusiness
    {
        public User Login(string email, string password)
        {
            string sql = "select * from Users u "  + 
            "left join Firms f on f.contact = u.id " + 
            "left join Departments d on d.id = u.department " +
            "inner join UserTypes ut on ut.id = u.userType " + 
            "where email = '" + email + "' and password = '" + password + "'";

            DataAccessLayer access = new DataAccessLayer();
            DataTable dt = access.getResultData(sql);

            if(dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                User usr = new User();
                usr.email = dt.Rows[0]["email"].ToString();
                usr.name = dt.Rows[0]["name"].ToString();
                usr.surname = dt.Rows[0]["surname"].ToString();
                usr.userType = new UserType();
                usr.userType.id = Convert.ToInt16(dt.Rows[0][21].ToString());
                usr.userType.shortCode = dt.Rows[0][22].ToString();

                return usr;
            }

        }
        public void KullaniciKayit()
        {

        }

        public void KullaniciGuncelle()
        {

        }
    }
}