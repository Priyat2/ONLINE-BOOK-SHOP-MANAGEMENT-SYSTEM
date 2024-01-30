<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="book_item_type.aspx.cs" Inherits="ONLINE_BOOK_SHOP.book_item_type" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .content2 {
            padding: 10px 40px 25px 40px;
            min-width: 320px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="vendor/jquery/dist/jquery.min.js"></script>
    <script src="vendor/bootstrap/dist/js/bootstrap.min.js"></script>
     <div id="wrapper">

        <div class="content2 animate-panel">
            <div class="row">
                <div class="col-lg-12" style="">
                    <div class="hpanel">
                        <h4>Add & Update Items Type</h4>
                        <div class="panel-body">
                             
                           
                             <div class="form-row">


                                <label for="">Select Item Type :</label>
                                <asp:DropDownList runat="server" ID="ddlitemtype" class="form-control"  Width="250px" AutoPostBack="true" OnSelectedIndexChanged="item_SelectedIndexChanged">
                                    <asp:ListItem Value="0">--ADD NEW--</asp:ListItem>
                                </asp:DropDownList>


                                <br />
                                <br />

                                <label for="">Enter Item Type :</label>
                                <asp:TextBox ID="txtitemtype" runat="server" placeholder="Enter Item Type" class="form-control"  Width="250px"></asp:TextBox>

                                <br />
                                <br />

                                <label for="">Select Status :</label>
                                <asp:RadioButton ID="active" runat="server" GroupName="1" Text="Active" style="padding:5px;" />
                                <asp:RadioButton ID="inactive" runat="server" GroupName="1" Text="InActive" style="padding:5px;" />
                                <br />
                                <br />

                                <asp:Button ID="btnsubmit" class="button button2" runat="server"  Text="Submit"  OnClick="btnsubmit_Click2" />

                            </div>

                             </div>
                        <style>
                               .hpanel .panel-body {
                                background: #D4F4C7;
                                border: 1px solid #e4e5e7;
                                border-radius: 2px;
                                padding: 20px;
                            }

                               .button {
                                    background-color: #FE5000; /* Green */
                                    border: none;
                                    color: white;
                                    padding: 11px 4px;
                                    text-align: center;
                                    text-decoration: none;
                                    display: inline-block;
                                    font-size: 16px;
                                    margin: 4px 2px;
                                    transition-duration: 0.4s;
                                    cursor: pointer;
                                }

                                .button2 {
                                    background-color: white;
                                    color: #FE5000;
                                    border: 2px solid #FE5000;
                                }

                                    .button2:hover {
                                        background-color: #FE5000;
                                        color: white;
                                    }

                                .button2 {
                                    width: 100px;
                                }

                                .button2 {
                                    border-radius: 8px;
                                }
                        </style>
                       
                    </div>
                </div>
            </div>
        </div>

    </div>



    <!-- Main Wrapper End-->

</asp:Content>

