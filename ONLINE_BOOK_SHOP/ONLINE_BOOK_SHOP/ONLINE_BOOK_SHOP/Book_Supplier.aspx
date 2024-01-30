<%@ Page Title="Supplier- Add Supplier" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Book_Supplier.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Book_Supplier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table, td {
            font-size: 12px;
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
                        <h4>Add Supplier Details</h4>
                        <div class="panel-body">
                           
                            <br />
                            <asp:HiddenField ID="getid" runat="server" />

                            <div>
                                <table>
                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier Name : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtsuplname" runat="server"  placeholder="Enter Supplier Name" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ValidationGroup="hardware" ControlToValidate="txtsuplname" ErrorMessage="Enter Supplier Name"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier Short Name : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtshortname" runat="server" placeholder="Enter Supplier Short Name" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ValidationGroup="hardware" ControlToValidate="txtshortname" ErrorMessage="Enter Supplier Short Name"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier Code : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtsuplcode" runat="server" placeholder="Enter Supplier Code" class="form-control"></asp:TextBox>
                                        </td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ValidationGroup="hardware" ControlToValidate="txtsuplcode" ErrorMessage="Enter Supplier Code"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier Description : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtsupldesc" runat="server" TextMode="MultiLine" placeholder="Enter Supplier Description" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="hardware" ControlToValidate="txtsupldesc" ErrorMessage="Enter Supplier Description"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Select Supplier Type : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList runat="server" ID="ddlsupltype" class="form-control">
                                                <asp:ListItem Value="0">--Select Type--</asp:ListItem>
                                                <asp:ListItem Value="wholesaler">wholesaler</asp:ListItem>
                                                <asp:ListItem Value="manufacturers">manufacturers</asp:ListItem>
                                                
                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="Req_ID" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlsupltype"
                                                ErrorMessage="Please Select Supplier Type" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier Address : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtsupladd" runat="server" TextMode="MultiLine" placeholder="Enter Supplier Address" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="hardware" ControlToValidate="txtsupladd" ErrorMessage="Enter Supplier Address"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                             <tr>
                                        <td>
                                            <label for="">Select Country : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList runat="server" ID="ddlsuplcountry" class="form-control">
                                                <asp:ListItem Value="0">--Select Country--</asp:ListItem>
                                                <asp:ListItem Value="1">India</asp:ListItem>
                                              
                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator5" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlsuplcountry"
                                                ErrorMessage="Please Select Country" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                   <%--  <tr>
                                        <td>
                                            <label for="">Select  State : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList runat="server" ID="ddlsuplstate" class="form-control" AutoPostBack="true"  OnSelectedIndexChanged="ddlitemname_SelectedIndexChanged1">
                                                <asp:ListItem Value="0">--Select State--</asp:ListItem>
                                                
                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator3" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlsuplstate"
                                                ErrorMessage="Please Select State" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>--%>

                                  <%--  <tr>
                                        <td>
                                            <label for="">Select City : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList runat="server" ID="ddlsuplcity" class="form-control" >
                                                <asp:ListItem Value="0">--Select City--</asp:ListItem>
                                                
                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator2" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlsuplcity"
                                                ErrorMessage="Please Select City" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                   --%>
                           

                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier Contact Number : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtsuplcontact" runat="server" placeholder="Enter Supplier Contact Number" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ValidationGroup="hardware" ControlToValidate="txtsuplcontact" ErrorMessage="Enter  Supplier Contact Number"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier Phone Number : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtsuplphone" runat="server" placeholder="Enter Supplier Phone Number" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ValidationGroup="hardware" ControlToValidate="txtsuplphone" ErrorMessage="Enter Supplier Phone Number"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier Email : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtsuplemail" runat="server" placeholder="Enter Supplier Email" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ValidationGroup="hardware" ControlToValidate="txtsuplemail" ErrorMessage="Enter Supplier Email"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier Image Path : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtimagepath" runat="server" placeholder="Enter Supplier Image Path" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ValidationGroup="hardware" ControlToValidate="txtimagepath" ErrorMessage="Enter Supplier Image Path"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Web Address : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtwebadd" runat="server" placeholder="Enter Web Address" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ValidationGroup="hardware" ControlToValidate="txtwebadd" ErrorMessage="Enter Web Address"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Zip Code : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtzipcode" runat="server" placeholder="Enter Zip Code" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ValidationGroup="hardware" ControlToValidate="txtzipcode" ErrorMessage="Enter Zip Code"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier Fax No. : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtsuplfax" runat="server" placeholder="Enter Supplier Fax No." class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ValidationGroup="hardware" ControlToValidate="txtsuplfax" ErrorMessage="Enter Supplier Fax No."
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Terms : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtterms" runat="server" placeholder="Enter Terms" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ValidationGroup="hardware" ControlToValidate="txtterms" ErrorMessage="Enter Terms"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Supplier License : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtsupllincense" runat="server" placeholder="Enter Supplier License" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ValidationGroup="hardware" ControlToValidate="txtsupllincense" ErrorMessage="Enter Supplier License"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Authorised Person : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtauthoper" runat="server" placeholder="Enter Authorised Person" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ValidationGroup="hardware" ControlToValidate="txtauthoper" ErrorMessage="Enter Authorised Person"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Taxation Date : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txttaxdate" runat="server" placeholder="Enter Taxation Date" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ValidationGroup="hardware" ControlToValidate="txttaxdate" ErrorMessage="Enter Taxation Date"
                                                ForeColor="Red"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>

                                       <tr>
                                        <td>
                                            <label for="">Enter GST No. : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtgstno" runat="server" placeholder="Enter GST No." class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ValidationGroup="hardware" ControlToValidate="txtgstno" ErrorMessage="Enter GST No."
                                                ForeColor="Red"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Discount : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtdiscount" runat="server" placeholder="Enter Discount" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ValidationGroup="hardware" ControlToValidate="txtdiscount" ErrorMessage="Enter Discount"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>
                                </table>
                            </div>


                            <asp:Button ID="btnsubmit" class="button button2" runat="server" ValidationGroup="hardware" Text="Submit" OnClick="btnsubmit_Click" />



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

