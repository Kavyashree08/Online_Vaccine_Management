<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="AddVaccineSlot.aspx.cs" Inherits="VaccineMangmentApp.AdminPanel.AddVaccineSlot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Scripts/jquery.datetimepicker.css" rel="stylesheet" />
    <script src="Scripts/jquery-ui-1.13.2.min.js"></script>
    <script src="Scripts/jquery.datetimepicker.js"></script>
    <link href="Scripts/jquery.datetimepicker.css" rel="stylesheet" />

    <script type="text/javascript">
        $(function () {
            $("#txtAvailableDate").datepicker({
                dateFormat: 'dd-MM-yyyy',
                changeMonth: true,
                changeYear: true

            });
            $("#txtExpireDate").datepicker({
                dateFormat: 'dd-MM-yyyy',
                changeMonth: true,
                changeYear: true,
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-4"></div>
                    <div class="col-4" style="margin-left: 200px">
                        <h3 class="text-danger pl-4">Add Vaccine Slot</h3>
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
                                <label for="exampleInputEmail1">Select Center Name</label>
                                <asp:DropDownList ID="drpCenterName" CssClass="form-control" runat="server" required="required"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Select Vaccine Type</label>
                                <asp:DropDownList ID="drpSelectVaccineType" CssClass="form-control" runat="server" required="required"></asp:DropDownList>
                            </div>

                            <div class="form-group">
                                <label for="exampleInputEmail1">Available Date</label>
                                <input type="text" class="form-control datepicker" id="txtAvailableDate" placeholder="Enter Start Date" runat="server">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Expire Date</label>
                                <input type="text" class="form-control datepicker" id="txtExpireDate" placeholder="Enter Expire Date" runat="server">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Available Slot</label>
                                <input type="number" class="form-control" id="txtSlot" placeholder="Enter Available Slot" runat="server">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Age Limit</label>
                                <input type="number" class="form-control" id="txtAgeLimit" placeholder="Enter Age Limit" runat="server">
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
