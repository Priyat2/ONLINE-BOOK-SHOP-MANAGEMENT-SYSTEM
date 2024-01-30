<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Change_Password.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Change_Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="vendor/jquery/dist/jquery.min.js"></script>
    <script src="vendor/bootstrap/dist/js/bootstrap.min.js"></script>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
  
    <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css"/>
    <style> @import url('https://fonts.googleapis.com/css2?family=Orbitron&family=Poppins:ital,wght@0,600;1,300&display=swap'); </style>
    <link rel="stylesheet" href="styles/login.css"/>
     <link rel="icon" type="image/x-icon" href="images/icon.jpg"/>
    <title>Forgot Password</title>
</head>
<body>
    <div class="logo">
      <center> <img src="images/logo.jpeg" alt=""/></center>
      </div>
    <main>
         <section class="Form my-4 mx-5">
             <div class="continer">
                 <div class="row no-gutters">
                     <div class="col-lg-5">
                        <img src="images/forgot-password.jpg" alt="" class="img-fluid"/>
                     </div>
                     <div class="col-lg-7 px-5 pt-1">
                         <h1 class="font-weight-bold py-3">Change Password</h1>
                         <h5>Enter Your Old Password & Change Password</h5>
                         <form id="form1" runat="server">
                              <div>
                                  <div class="form-row">
                                      <div class="col-lg-7">
                                         <p>Enter Old Password :</p>
                                         <asp:TextBox ID="oldpass" runat="server" placeholder="Enter Old Password" class="form-control my-3 p-3"></asp:TextBox>
                                      </div>
                                  </div>

                                  <div class="form-row">
                                     <div class="col-lg-7">
                                        <p>Enter New Password :</p>
                                        <asp:TextBox ID="newpass"  runat="server" placeholder="********" class="form-control my-3 p-3"></asp:TextBox>
                                     </div>
                                  </div>

                                  <div class="form-row">
                                     <div class="col-lg-7">
                                        <p>Confirm New Password :</p>
                                        <asp:TextBox ID="newpasscon"  runat="server"  placeholder="********" class="form-control my-3 p-3"></asp:TextBox>
                                     </div>
                                  </div>

                                  <div class="form-row">
                                     <div class="col-lg-7">
                                        <asp:Button id="btnsubmit" class="btn1 mt-3 mb-3"  runat="server" Text="Save" OnClick="btnsubmit_Click"   />
                                     </div>
                                  </div>
                              </div>
                           </form>  
                     </div>
                 </div>
               </div>
        
            </section>
        <hr/>
    </main>
</body>
</html>
