<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="AddVaccineType.aspx.cs" Inherits="VaccineMangmentApp.AdminPanel.AddVaccineType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
        <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-4"></div>
                    <div class="col-4" style="margin-left: 200px">
                        <h3 class="text-danger pl-4">Add Vaccine</h3>
                        <div class="col-4">
                            <img src="/Assets/Img/Register.png" height="130px" />
                        </div>
                    </div>
                    <div class="col-4"></div>
                </div>
                <div class="row">
                    <div class="col-4"></div>
                    <div class="col-4">
                        <form runat="server">
                            <div class="form-group">
                                <label for="exampleInputEmail1">Vaccine Name</label>
                                <input type="text" class="form-control" id="txtName" placeholder="Enter Vaccine Name" runat="server" required="required">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Vaccine Type</label>
                                <input type="text" class="form-control" id="txtType" placeholder="Enter Vaccine Type" runat="server">
                            </div>
                            
                            <br />
                            <label id="ErrorMsg" runat="server" class="text-danger"></label>
                            <br />
                            <asp:Button type="submit" ID="SaveBtn" class="m-lg-2  btn btn-danger" Text="Save" runat="server" OnClick="SaveBtn_Click" />
                        </form>
                    </div>
                </div>

            </div>

        </div>
    </div>

</asp:Content>
