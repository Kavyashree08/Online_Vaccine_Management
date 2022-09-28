using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VaccineMangmentApp.Database;

namespace VaccineMangmentApp.UserPannel
{
    public partial class AddFamillyMenber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            var FirstName = txtFirstName.Value;
            var LastName = txtLastName.Value;
            var emailId = txtEmailId.Value;
            var address = txtAddress.Value;
            var age = txtAge.Value;
            var DOB = txtDateTime.Value;
            var password = txtPassword.Value;
            var mobileNo = txtMobileNo.Value;
            var city = txtCity.Value;
            int age1 = int.Parse(age);
            if (FirstName == "" || LastName == "" || emailId == "" || age == "" || DOB == "" || password == "" || mobileNo == "" || city == "" || age == "0")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid Details')", true);

                ErrorMsg.InnerText = "Fill All Field Properly";
            }
            if (age1 < 5)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Age Not Allwoed for vaccination')", true);

                ErrorMsg.InnerText = "Age Not Allwoed for vaccination";
            }
            if (password.Length <= 6)
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Enter Valid Password length must be Greater than 6')", true);

                ErrorMsg.InnerText = "Please Enter Valid Password length must be Greater than 6";
            }
            if (!Regex.Match(address, @"^[A-Za-z0-9'\.\-\s\,]*$").Success)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid address')", true);

                ErrorMsg.InnerText = "Invalid address";
                return;
            } // end if
            if (!Regex.Match(mobileNo, @"^[0-9]{10}$").Success)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid Phone no')", true);

                ErrorMsg.InnerText = "Invalid Phone no";
                return;
            } // end if
            if (Regex.Match(emailId, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$").Success)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid Email Address')", true);

                ErrorMsg.InnerText = "Invalid Email Address";
                return;
            } // end if
            else
            {
                try
                {

                    using (var ctx = new VaccineMasterEntities1())
                    {
                        if (!ctx.UserMasters.Any(x => x.EmailID == emailId || x.MobileNo == mobileNo))
                        {
                            ctx.UserMasters.Add(new UserMaster
                            {
                                Address = address,
                                Age = int.Parse(age),
                                City = city,
                                DOB = DateTime.Parse(DOB),
                                EmailID = emailId,
                                FirstName = FirstName,
                                LastName = LastName,
                                IsAdmin = false,
                                MobileNo = mobileNo,
                                Password = password,
                                UserID = Login.LogUser.ID,

                            });
                            ctx.SaveChanges();
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Used Added Successfully')", true);
                            ErrorMsg.InnerText = "User saved Successfully";
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User Already Registerd')", true);
                            ErrorMsg.InnerText = "User Already Registerd";
                        }

                    }
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter All Details')", true);
                    ErrorMsg.InnerText = "Please Enter All Details";
                }
            }

        }
    }
}