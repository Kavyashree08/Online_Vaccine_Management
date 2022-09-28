using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaccineMangmentApp.UserPannel
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public System.DateTime DOB { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string MobileNo { get; set; }
        public string VaccineStatus { get; set; }
    }
}