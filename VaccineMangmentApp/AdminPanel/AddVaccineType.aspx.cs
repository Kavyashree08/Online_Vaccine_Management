using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VaccineMangmentApp.Database;

namespace VaccineMangmentApp.AdminPanel
{
    public partial class AddVaccineType : System.Web.UI.Page
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
                    if (string.IsNullOrEmpty(txtName.Value) || string.IsNullOrWhiteSpace(txtName.Value))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Enter Vaccine Name')", true);
                    }
                    else if (string.IsNullOrEmpty(txtType.Value) || string.IsNullOrWhiteSpace(txtType.Value))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Enter Vaccine Type')", true);
                    }
                    else if (ctx.VaccineMasters.Any(x => x.Name == txtName.Value || x.Type == txtType.Value))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vaccine Name and Type Already Exists')", true);
                    }
                    else
                    {
                        ctx.VaccineMasters.Add(new VaccineMaster
                        {
                            Name = txtName.Value,
                            Type = txtType.Value
                        });
                        ctx.SaveChanges();
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Data Saved Succefully')", true);
                    }
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('internal Server Error')", true);
            }
        }
    }
}