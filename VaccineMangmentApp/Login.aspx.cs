using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VaccineMangmentApp.Database;

namespace VaccineMangmentApp
{
    public partial class Login : System.Web.UI.Page
    {
        public static UserMaster LogUser=new UserMaster();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new VaccineMasterEntities1())
                {
                    var username = UserId.Text;
                    var password = Password.Text;
                    var user = ctx.UserMasters.FirstOrDefault(x => (x.MobileNo == username || x.EmailID == username) && x.Password == password);
                    if (user != null)
                    {
                        if (!user.IsAdmin)
                        {
                            LogUser = user;
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User Login Succuessuly')", true);
                            Response.Redirect("~/UserPannel/Home.aspx");
                        }
                        else
                        {
                            LogUser = user;
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Admin Login Succuessuly')", true);
                            Response.Redirect("~/AdminPanel/Home.aspx");
                        }
                       
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User Not Exits in Database Please Register')", true);
                    }
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Internal Server Error')", true);
            }

        }
    }
}