<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" MasterPageFile="~/Welcome.Master" Inherits="VaccineMangmentApp.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
    <style>
        body {
            background-color: white
        }
    </style>
    <link href="Scripts/jquery.datetimepicker.css" rel="stylesheet" />
    <script src="Scripts/jquery-ui-1.13.2.min.js"></script>
    <script src="Scripts/jquery.datetimepicker.js"></script>
    <link href="Scripts/jquery.datetimepicker.css" rel="stylesheet" />
    <script type="text/javascript">
        $(function () {
            $("#txtDateTime").datepicker({
                dateFormat: 'dd-MM-yyyy',
                changeMonth: true,
                changeYear: true

            });
        });
    </script>
    <body style="background-image:url('Content/B2.jpg');background-repeat:no-repeat;background-size:cover">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-4"></div>
                    <div class="col-4" style="margin-left: 200px">
                        <h3 class="text-danger pl-4">Register</h3>
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
                                <label for="exampleInputEmail1">First Name</label>
                                <input type="text" class="form-control" id="txtFirstName" placeholder="Enter First Name" runat="server" required="required">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Last Name</label>
                                <input type="text" class="form-control" id="txtLastName" placeholder="Enter Last Name" runat="server">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Email Id </label>
                                <input type="text" class="form-control" id="txtEmailId" placeholder="Enter Email ID" runat="server">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Date of Birth</label>
                                <%-- <asp:TextBox ID="txtDateTime"  runat="server" CssClass="datepicker"Text='<%# Eval("BirthDate", "{0:dd-MMMM-yyyy}") %>' />--%>
                                <input type="text" class="form-control datepicker" id="txtDateTime" placeholder="Enter Birth Date" runat="server">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Age</label>
                                <input type="number" class="form-control" id="txtAge" placeholder="Enter Age" runat="server">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Customer Password</label>
                                <input type="password" class="form-control" id="txtPassword" placeholder="Enter Password" runat="server" required="required">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Address</label>
                                <input type="text" class="form-control" id="txtAddress" placeholder="Enter Address" runat="server">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">City</label>
                                <input type="text" class="form-control" id="txtCity" placeholder="Enter City" runat="server">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Mobile No</label>
                                <input type="text" class="form-control" id="txtMobileNo" placeholder="Enter Mobile Number" runat="server">
                            </div>
                           
                            <br />
                            <label id="ErrorMsg" runat="server" class="text-danger"></label>
                            <br />
                            <asp:Button type="submit" ID="SaveBtn" class="m-lg-2  btn btn-danger" Text="Register" runat="server" OnClick="SaveBtn_Click" />
                        </form>
                    </div>
                </div>

            </div>

        </div>
    </div>

    Already Registered
    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Login.aspx" runat="server">Login here.</asp:HyperLink>
</body>
</asp:Content>
