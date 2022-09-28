using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VaccineMangmentApp.Database;

namespace VaccineMangmentApp.AdminPanel
{
    public partial class AddVaccineCenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new VaccineMasterEntities1())
                {
                    var cName = txtName.Value;
                    var Cpincode = int.Parse(txtPinCode.Value);
                    var cAddress = txtAddress.Value;
                    var cCity = txtcity.Value;
                    if (string.IsNullOrEmpty(cName) || txtPinCode.Value.Length < 5 || cAddress.Length < 15 || cCity.Length < 2)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Enter Valid Details')", true);
                    }
                    else
                    {
                        var center = ctx.VaccineCenterMasters.FirstOrDefault(x => (x.Name == cName || x.PinCode == Cpincode));
                        if (center != null)
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Center Already Exists')", true);
                        }
                        else
                        {
                            ctx.VaccineCenterMasters.Add(new VaccineCenterMaster
                            {
                                Address = cAddress,
                                PinCode = Cpincode,
                                City = cCity,
                                Name = cName,
                                CreatedDate = DateTime.Now,
                                ModifiedDate = DateTime.Now
                            });
                            ctx.SaveChanges();
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Center Saved in Database')", true);
                        }
                    }
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Internal Server Error')", true);
            }

        }
    }
}