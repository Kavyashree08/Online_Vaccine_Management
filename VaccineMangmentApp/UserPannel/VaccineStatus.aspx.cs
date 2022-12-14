using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VaccineMangmentApp.Database;

namespace VaccineMangmentApp.UserPannel
{
    public partial class VaccineStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var ctx = new VaccineMasterEntities1())
            {
                List<UserModel> userList = new List<UserModel>();
                var lst = ctx.UserMasters.Where(x => (x.UserID == Login.LogUser.UserID && x.UserID!=0)  || x.ID == Login.LogUser.ID);
                var Vaccinebook = ctx.VaccineBookingMasters.FirstOrDefault(x => x.UserID == Login.LogUser.ID);
                foreach (var item in lst)
                {
                    userList.Add(new UserModel
                    {
                        Address = item.Address,
                        Age = item.Age,
                        City = item.City,
                        DOB = item.DOB,
                        EmailID = item.EmailID,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        MobileNo = item.MobileNo,
                        Password = item.Password,
                        VaccineStatus = Vaccinebook?.Startus
                    });
                }
                grdUserDetails.DataSource = userList;
                grdUserDetails.DataBind();


            }
        }
    }
}