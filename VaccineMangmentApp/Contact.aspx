<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Welcome.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="VaccineMangmentApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="mybody" runat="server">
    <style>
        body {
            background-color: cadetblue
        }
    </style>
   <div class="container">
        <h3 class="text-danger pl-4">Contact Us:</h3>
        <p>Please get in touch with us using the Address and Contact below.<br />
            We'll get back to you as soon as possible.
         </p>
        <br />
        <h3 class="text-warning">Address:</h3>
        <div class="col-2">
        <p>Rasoolpur,Hayaghat,City:-Darbhanga,State:-Bihar,Pin:846004</p>

        </div>
        <h4>Contact No:</h4><p class="text-danger">7488197514</p><br/>
         <h4>Email:</h4><p class="text-danger">nazranashaheen06@gmail.com</p>

    </div>
</asp:Content>