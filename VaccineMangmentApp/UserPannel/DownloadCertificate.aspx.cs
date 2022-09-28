using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VaccineMangmentApp.Database;

namespace VaccineMangmentApp.UserPannel
{
    public partial class DownloadCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var ctx = new VaccineMasterEntities1())
            {
                var user = ctx.VaccineBookingMasters.FirstOrDefault(x => x.UserID == Login.LogUser.ID);
                if (user != null && user.Startus == "done")
                {
                    txtName.Text = Login.LogUser.FirstName + " " + Login.LogUser.LastName;
                    txtdob.Text = Login.LogUser.DOB.ToShortDateString();
                    txtdate.Text = DateTime.Now.ToShortDateString();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vaccination Status is not done')", true);

                }
            }
        }
    }
}