using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VaccineMangmentApp.Database;

namespace VaccineMangmentApp.AdminPanel
{
    public partial class AddVaccineSlot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var ctx = new VaccineMasterEntities1())
            {
                foreach (var item in ctx.VaccineCenterMasters.ToList())
                {
                    drpCenterName.Items.Add(item.Name);
                }
                foreach (var item in ctx.VaccineMasters.ToList())
                {
                    drpSelectVaccineType.Items.Add(item.Name);
                }
            }
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new VaccineMasterEntities1())
                {
                    var center = ctx.VaccineCenterMasters.FirstOrDefault(x => x.Name == drpCenterName.SelectedItem.Text);
                    var vaccine = ctx.VaccineMasters.FirstOrDefault(x => x.Name == drpSelectVaccineType.SelectedItem.Text);
                    var avalDate = DateTime.Parse(txtAvailableDate.Value);
                    var expDate = DateTime.Parse(txtExpireDate.Value);
                    var slot = int.Parse(txtSlot.Value);
                    var agelimit = int.Parse(txtAgeLimit.Value);
                    if (string.IsNullOrEmpty(txtAvailableDate.Value) || slot < 0 || agelimit < 6)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Enter Valid Details')", true);
                    }
                    else
                    {
                        var book = ctx.BookingSlotMasters.FirstOrDefault(x => (x.AvailableDate == avalDate && x.ExpireDate == expDate));
                        if (book != null)
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Slot Already Exists')", true);
                        }
                        else
                        {
                            ctx.BookingSlotMasters.Add(new BookingSlotMaster
                            {
                                CenterID = center.ID,
                                VaacineID = vaccine.ID,
                                VacineName = vaccine.Name,
                                CenterName = center.Name,
                                AgeLimit = agelimit,
                                AvailableDate = avalDate,
                                ExpireDate = expDate,
                                AvailabeVaccine = slot,
                            });
                            ctx.SaveChanges();
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Slot Saved in Database')", true);
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