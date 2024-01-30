<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="vendor/jquery/dist/jquery.min.js"></script>
    <script src="vendor/bootstrap/dist/js/bootstrap.min.js"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

    <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" />
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Orbitron&family=Poppins:ital,wght@0,600;1,300&display=swap');
    </style>
    <link rel="stylesheet" href="styles/login.css" />
    <%--<link rel="icon" type="image/x-icon" href="images/icon.jpg">--%>
    <title>Admin Log In </title>
</head>
<body>

    <%--<div class="logo" style="background-color:aliceblue;">
        <center> <img src="images/book.PNG" alt=""/></center>
    </div>--%>
    <main>
        <section class="Form my-4 mx-5">
            <div class="continer">
                <div class="row no-gutters">
                    <div class="col-lg-5" style="background-color: aliceblue;">
                        <img src="images/book.jpg" alt="" class="img-fluid" width="500" height="600" />
                    </div>
                    <div class="col-lg-7 px-5 pt-2" style="background-color: aliceblue;">
                        <h1 class="font-weight-bold py-3" style="color:blue;">Login To Your Account</h1>
                        <h5 style="color:darkslategrey;">Enter your username & password to login</h5>
                        <form id="form1" runat="server">
                            <div>
                                <div class="form-row">
                                    <div class="col-lg-7">
                                        <p>Enter Username :</p>
                                        <asp:TextBox ID="txtusername" runat="server" placeholder="Enter Username" class="form-control my-3 p-3"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-row">
                                    <div class="col-lg-7">
                                        <p>Enter Password :</p>
                                        <asp:TextBox ID="txtuserpass" TextMode="Password" runat="server" placeholder="Enter Password" class="form-control my-3 p-3"></asp:TextBox>
                                    </div>
                                </div>


                                <div class="form-row">
                                    <div class="col-lg-7">
                                        <asp:Button ID="btnsubmit" class="btn1 mt-3 mb-3" runat="server" Text="Sign In" OnClick="btnsubmit_Click" />
                                    </div>
                                </div>
                                <style>
                                    .btn1 {
                                        font-family: 'Serif';
                                        border: none;
                                        outline: none;
                                        height: 50px;
                                        width: 100%;
                                        background: linear-gradient(45deg, #131086, #0dcaf0);
                                        color: white;
                                        border-radius: 4px;
                                        font-weight: bold;
                                    }
                                </style>
                            </div>
                        </form>
                    </div>
                </div>
            </div>

        </section>
        <hr />
    </main>

</body>
</html>
