using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaccineMangmentApp.UserPannel
{
    public class BookSlotMaster
    {
        public int ID { get; set; }
        public int CenterID { get; set; }
        public int VaacineID { get; set; }
        public string CenterName { get; set; }
        public string VacineName { get; set; }
        public System.DateTime AvailableDate { get; set; }
        public System.DateTime ExpireDate { get; set; }
        public int AvailabeVaccine { get; set; }
        public int AgeLimit { get; set; }
    }
}