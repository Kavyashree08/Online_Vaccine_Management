<%@ Page Title="" Language="C#" MasterPageFile="~/UserPannel/User.Master" AutoEventWireup="true" CodeBehind="BookVaccineSlot.aspx.cs" Inherits="VaccineMangmentApp.UserPannel.BookVaccineSlot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <style>
        * {
            box-sizing: border-box;
        }

        /* Style the search field */
        form.example input[type=text] {
            padding: 10px;
            font-size: 17px;
            border: 1px solid grey;
            float: left;
            width: 100%;
            background: #f1f1f1;
        }

        /* Style the submit button */
        form.example button {
            float: left;
            width: 20%;
            padding: 10px;
            background: #2196F3;
            color: white;
            font-size: 17px;
            border: 1px solid grey;
            border-left: none; /* Prevent double borders */
            cursor: pointer;
        }

            form.example button:hover {
                background: #0b7dda;
            }

        /* Clear floats */
        form.example::after {
            content: "";
            clear: both;
            display: table;
        }

        .btn-search {
            width: 50%;
            height: 100%;
            margin-left: -24px;
        }
    </style>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

    <!-- The form -->
    <form class="example" runat="server">
        <div class="row mt-4 m-lg-3">
            <div class="col-8">
                <input type="text" runat="server" id="txtSerach" placeholder="Search By City or Pin Code.." name="search">
            </div>
            <div class="col-4">
                <asp:Button type="submit" ID="btnSearch" OnClick="btnSearch_Click" Text="Search" class="btn-primary btn-search " runat="server"></asp:Button>
            </div>

        </div>
        <div class="container-fluid">
            <div class="row">
                <div class="col-4"></div>
                <div class="col-4">
                    <asp:Button type="submit" ID="btnbook" OnClick="btnbook_Click" Text="Book Appoimnet" class="fa fa-search" runat="server"></asp:Button>
                </div>
            </div>
            <div class="row">
                <div class="col-1"></div>
                <div class="col-8">
                    <asp:GridView ID="avalData" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </div>

            </div>
        </div>
    </form>
</asp:Content>
