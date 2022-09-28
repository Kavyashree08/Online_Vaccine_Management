<%@ Page Title="" Language="C#" MasterPageFile="~/Welcome.Master" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="VaccineMangmentApp.ForgetPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
        <style>
        body {
            background-color: antiquewhite
        }
    </style>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-4"></div>
                    <div class="col-4">
                         <h3 class="text-danger pl-4">Forgot Password</h3>
                    <div class="col-4">
                        <img src="Assets/Img/Register.png" height="130px" />
                    </div>
                    </div>
                     <div class="col-4"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <form runat="server">
                           
                            <div class="form-group">
                                <label for="exampleInputEmail1">User Email Address </label>
                                <input type="text" class="form-control" id="txtUserEmailID" placeholder="Enter Email Address" runat="server">
                            </div>
                            <label id="ErrorMsg" runat="server" class="text-danger"></label>
                            <br />
                            <asp:Button type="submit" ID="SaveBtn" class="btn btn-danger" Text="Send" runat="server" OnClick="SaveBtn_Click" />



                        </form>
                    </div>
                </div>

            </div>

        </div>
    </div>

    Already Registered
    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Login.aspx" runat="server">Login here.</asp:HyperLink>

</asp:Content>