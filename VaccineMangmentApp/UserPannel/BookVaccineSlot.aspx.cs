using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VaccineMangmentApp.Database;

namespace VaccineMangmentApp.UserPannel
{
    public partial class BookVaccineSlot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Login.LogUser.ID == 0)
            {
                Response.Redirect("../Login.aspx");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<BookSlotMaster> bsM = new List<BookSlotMaster>();
            using (var ctx = new VaccineMasterEntities1())
            {
                try
                {
                    if (txtSerach.Value == "")
                    {
                        var list = ctx.BookingSlotMasters.ToList();
                        if (list == null || list.Count() <= 0)
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No Vaccine Available At this Center')", true);
                        }
                        else
                        {
                            foreach (var item in list)
                            {
                                bsM.Add(new BookSlotMaster
                                {
                                    CenterName = item.CenterName,
                                    AgeLimit = item.AgeLimit,
                                    AvailabeVaccine = item.AvailabeVaccine,
                                    AvailableDate = item.AvailableDate,
                                    CenterID = item.CenterID,
                                    ExpireDate = item.ExpireDate,
                                    VaacineID = item.VaacineID,
                                    VacineName = item.VacineName,
                                    ID = item.ID
                                });
                            }
                            avalData.DataSource = bsM;
                            avalData.AutoGenerateSelectButton = true;
                            avalData.DataBind();
                        }
                    }
                    else
                    {
                        var id = int.Parse(txtSerach.Value);
                        var center = ctx.VaccineCenterMasters.FirstOrDefault(x => x.PinCode == id);
                        var list = ctx.BookingSlotMasters.Where(x => x.CenterID == center.ID);
                        if (list == null || list.Count() <= 0)
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No Vaccine Available At this Center')", true);
                        }
                        else
                        {
                            foreach (var item in list)
                            {
                                bsM.Add(new BookSlotMaster
                                {
                                    CenterName = item.CenterName,
                                    AgeLimit = item.AgeLimit,
                                    AvailabeVaccine = item.AvailabeVaccine,
                                    AvailableDate = item.AvailableDate,
                                    CenterID = item.CenterID,
                                    ExpireDate = item.ExpireDate,
                                    VaacineID = item.VaacineID,
                                    VacineName = item.VacineName,
                                    ID = item.ID
                                });
                            }
                            avalData.DataSource = bsM;
                            avalData.AutoGenerateSelectButton = true;
                            avalData.DataBind();
                        }
                    }
                }
                catch (Exception ex)
                {

                    var city = txtSerach.Value;
                    var center = ctx.VaccineCenterMasters.FirstOrDefault(x => x.City == city);
                    var list = ctx.BookingSlotMasters.Where(x => x.CenterID == center.ID).ToList();
                    if (list == null || list.Count() <= 0)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No Vaccine Available At this Center')", true);
                    }
                    else
                    {
                        avalData.DataSource = list;
                        avalData.AutoGenerateSelectButton = true;
                        avalData.DataBind();
                    }
                }

            }
        }

        protected void btnbook_Click(object sender, EventArgs e)
        {
            try
            {
                var data = avalData.SelectedRow.Cells[1].Text;
                bool isValid = true;
                using (var ctx = new VaccineMasterEntities1())
                {
                    var VaccineBookingMasters = ctx.VaccineBookingMasters.Where(x => x.UserID == Login.LogUser.ID);
                    if (VaccineBookingMasters != null)
                    {
                        if (VaccineBookingMasters.Any(x => x.Startus == "Booked"))
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Already Booked')", true);
                            isValid = false;
                        }
                        if (VaccineBookingMasters.Count() > 2)
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' user is Fully Vaccinated')", true);
                            isValid = false;
                        }
                        if (Login.LogUser.Age < 10)
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('this age is not allowed')", true);
                            isValid = false;
                        }
                    }
                    if (isValid == true)
                    {
                        int id = int.Parse(data);
                        var book = ctx.BookingSlotMasters.FirstOrDefault(x => x.ID == id);
                        ctx.VaccineBookingMasters.Add(new VaccineBookingMaster
                        {
                            BookedDate = book.AvailableDate,
                            CenterName = book.CenterName,
                            CenterID = book.CenterID,
                            Startus = "Booked",
                            ModifiedDate = DateTime.Now,
                            City = book.VaccineCenterMaster.City,
                            VaccineID = book.VaacineID,
                            VaccineName = book.VacineName,
                            UserID = Login.LogUser.ID,
                            UserName = Login.LogUser.FirstName + " " + Login.LogUser.LastName,
                            IsDeleted = false,
                        });
                        ctx.SaveChanges();
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Vaccine Booked Succefully')", true);
                    }

                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Someting went wrong..try agin')", true);

            }

        }
    }
}