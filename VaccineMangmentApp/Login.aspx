<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VaccineMangmentApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Libraries/css/bootstrap.css" />
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        form {
            border: 3px solid #f1f1f1;
        }

        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        button:hover {
            opacity: 0.8;
        }

        .cnbtn {
            background-color: #ec3f3f;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 49%;
        }

        .lgnbtn {
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 50%;
        }

        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
        }

        img.avatar {
            width: 40%;
            border-radius: 50%;
        }

        .container {
            padding: 16px;
        }

        span.psw {
            float: right;
            padding-top: 16px;
        }
        /* Change styles for span and cancel button on extra small screens */
        @media screen and (max-width: 300px) {
            span.psw {
                display: block;
                float: none;
            }

            .cnbtn {
                width: 100%;
            }
        }

        .frmalg {
            margin: auto;
            width: 40%;
        }
    </style>
</head>
<body style="background-image:url('Content/B2.jpg');background-repeat:no-repeat;background-size:cover">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-4">
             <%--   <img src="Content/login.JPG"    />--%>
            </div>
        </div>
        <div class="row">
            
            <div class="col-12">
                <form id="form1" runat="server" class="frmalg">
                    <div class="container" style="background-color:white">
                        <center>
                        <h3>Login Page </h3>
                    </center>
                        <label for="uname"><b>UserId</b></label>
                        <asp:TextBox runat="server" ID="UserId" placeholder="Enter Id"></asp:TextBox>
                        <label for="psw"><b>Password</b></label>
                        <asp:TextBox runat="server" ID="Password" TextMode="Password" placeholder="Enter Password"></asp:TextBox>
                        <asp:Button runat="server" ID="btn_Login" OnClick="btn_Login_Click" CssClass="lgnbtn" Text="Login" />
                        <asp:Button runat="server" ID="btn_cancel" Text="Cancel" class="cnbtn" />
                        <br />
                        Forgot Password
                    <asp:HyperLink ID="HyperLink2" NavigateUrl="~/ForgetPassword.aspx" runat="server">Forgot Password</asp:HyperLink>
                        <br />
                        New User
                    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Registration.aspx" runat="server">Register here.</asp:HyperLink>
                        <br />
                        <asp:Label ID="InfoMsg" runat="server" Text=""></asp:Label>
                    </div>
                </form>
            </div>
        </div>
</body>
</html>
