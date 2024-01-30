<%@ Page Title="Book Supplier- Add Book Supplier vs Item" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="splr_vs_book_items.aspx.cs" Inherits="ONLINE_BOOK_SHOP.splr_vs_book_items" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        table , td{
            font-size:12px;
        }

                .content2 {
            padding: 10px 40px 25px 40px;
            min-width: 320px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="vendor/jquery/dist/jquery.min.js"></script>
    <script src="vendor/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- Main Wrapper -->
    <div id="wrapper">

        <div class="content2 animate-panel">
            <div class="row">
                <div class="col-lg-12" style="">
                    <div class="hpanel">
                       <h4>Add Supplier and Items</h4>
                        <div class="panel-body">
                             
                           
                            <asp:HiddenField ID="getid" runat="server" />
                            <div>
                                <table>
                                <%--    <tr>
                                        <td>
                                            <label for="">Select City  : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList runat="server" ID="ddlcity" Style="width: 250px;" class="form-control">
                                                <asp:ListItem Value="0">--Select City--</asp:ListItem>
                                                <asp:ListItem Value="125">Mumbai</asp:ListItem>
                                                <asp:ListItem Value="128">Pune</asp:ListItem>
                                                <asp:ListItem Value="126">Banglore</asp:ListItem>
                                                <asp:ListItem Value="127">Gujrat</asp:ListItem>
                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="Req_ID" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlcity"
                                                ErrorMessage="Please Select City" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>--%>

                                    <tr>
                                        <td>
                                            <label for="">Select Supplier : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList runat="server" ID="ddlsuplier" style="width:280px;" class="form-control">
                                                <asp:ListItem Value="0">--Select Supplier--</asp:ListItem>
                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator1" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlsuplier"
                                                ErrorMessage="Please Select Supplier" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Select Item : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList runat="server" ID="ddlitem" style="width:280px;" class="form-control">
                                                <asp:ListItem Value="0">--Select Item--</asp:ListItem>
                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator2" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlitem"
                                                ErrorMessage="Please Select Item" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                </table>
                            </div>
                            <br />
                            <span style="padding-right:370px;">
                                <asp:Button ID="btnsubmit" class="button button2" runat="server" ValidationGroup="hardware" Text="Submit" OnClick="btnsubmit_Click" />

                            </span>
                            
                        </div>

                          <style>
                            .hpanel .panel-body {
                                background: #a2b0ca;
                                border: 1px solid #f2e7c3;
                                border-radius: 2px;
                                padding: 20px;
                            }

                             .button {
                                    background-color: #99C221; /* Green */
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
                                    color: #99C221;
                                    border: 2px solid #99C221;
                                }

                                    .button2:hover {
                                        background-color: #99C221;
                                        color: white;
                                    }

                                .button2 {
                                    width: 90px;
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
