﻿<%@ Page Title="Supplier- Purchase Order" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Book_Purchase_Order.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Book_Purchase_Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>

 <style>
        table, td {
            font-size: 12px;
        }

        .auto-style1 {
            height: 48px;
        }

        th {
            background-color: #99C221;
            font-weight: bold;
            color:white;
        }

        .content1 {
            padding: 10px 40px 40px 40px;
            min-width: 320px;
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
    <asp:ScriptManager ID="smid1" runat="server" EnableCdn="true"></asp:ScriptManager>

    <div id="wrapper">
        <div class="content2 animate-panel">
            <div class="row">
                <div class="col-lg-12">
                    <div class="hpanel">
                        <h4>Book Purchase From Supplier</h4>
                        <div class="panel-body">
                            <asp:HiddenField ID="hdnpoid" runat="server" />
                                 <div>
                            <table>

                               
                                <tr>
                                    <td style="padding: 15px">
                                        <label for="">Select Supplier : <span style="color: red;">*</span></label></td>
                                    <td style="padding-left: 80px; padding-bottom: 15px;" class="auto-style1">
                                        <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlsupplier" class="form-control" AutoPostBack="true">
                                            <asp:ListItem Value="0">-Select Supplier-</asp:ListItem>

                                        </asp:DropDownList>
                                    </td>
                                    <td style="padding: 15px" class="auto-style1">
                                        <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator1" Display="Dynamic"
                                            runat="server" ControlToValidate="ddlsupplier"
                                            ErrorMessage="Please Select Supplier" ValidationGroup="hardware" ForeColor="Red">
                                        </asp:RequiredFieldValidator>
                                    </td>
                                </tr>


                                <tr>
                                    <td style="padding: 15px">
                                        <label for="">Select Item Name : <span style="color: red;">*</span></label></td>
                                    <td style="padding-left: 80px; padding-bottom: 15px;">
                                        <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlitemname" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlitemname_SelectedIndexChanged1">
                                            <asp:ListItem Value="0">-Select Item-</asp:ListItem>

                                        </asp:DropDownList>
                                    </td>
                                    <td style="padding: 15px">
                                        <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator5" Display="Dynamic"
                                            runat="server" ControlToValidate="ddlitemname"
                                            ErrorMessage="Please Select Item Name" ValidationGroup="hardware" ForeColor="Red">
                                        </asp:RequiredFieldValidator>
                                    </td>
                                </tr>

                                <tr>
                                    <td style="padding: 15px;">
                                        <label for="">Item Unit :</label></td>
                                    <td style="padding-left: 80px; padding-bottom: 15px;">
                                        <asp:Label ID="lblunits" runat="server" Text=""></asp:Label>
                                    </td>

                                </tr>


                                <tr>
                                    <td style="padding: 15px;">
                                        <label for="">Enter Item Quantity : <span style="color: red;">*</span></label></td>
                                    <td style="padding-left: 80px; padding-bottom: 15px;">
                                        <asp:TextBox ID="txtqty" runat="server" placeholder="Enter Item Quantity" class="form-control"></asp:TextBox>
                                    </td>
                                    <td style="padding: 15px;">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="hardware" ControlToValidate="txtqty" ErrorMessage="Enter Item Quantity"
                                            ForeColor="Red">
                                        </asp:RequiredFieldValidator>
                                    </td>
                                </tr>

                                <tr>
                                    <td style="padding: 15px;">
                                        <label for="">GST : <span style="color: red;">*</span></label></td>
                                    <td style="padding-left: 80px; padding-bottom: 15px;">
                                        <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlgst" class="form-control">
                                            <asp:ListItem Value="0">--Select GST--</asp:ListItem>
                                            <asp:ListItem Value="10">10%</asp:ListItem>
                                            <asp:ListItem Value="12">12%</asp:ListItem>
                                            <asp:ListItem Value="18">18%</asp:ListItem>

                                        </asp:DropDownList>
                                    </td>
                                    <td style="padding: 15px;">
                                        <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator3" Display="Dynamic"
                                            runat="server" ControlToValidate="ddlgst"
                                            ErrorMessage="Please Select GST" ValidationGroup="hardware" ForeColor="Red">
                                        </asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding: 15px;">
                                        <label for="">Discount(%) : <span style="color: red;">*</span></label></td>
                                    <td style="padding-left: 80px; padding-bottom: 15px;">
                                        <asp:TextBox ID="txtdiscount" runat="server" Text="0" placeholder="Enter Discount" class="form-control"></asp:TextBox>
                                    </td>
                                    <td style="padding: 15px;">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="hardware" ControlToValidate="txtdiscount" ErrorMessage="Enter Discount"
                                            ForeColor="Red">
                                        </asp:RequiredFieldValidator>
                                    </td>
                                </tr>



                                <tr>
                                    <td style="padding: 15px;">
                                        <label for="">In Stock Quantity :</label></td>
                                    <td style="padding-left: 80px; padding-bottom: 15px;">
                                        <asp:Label ID="lblqty" runat="server" Text=""></asp:Label>
                                    </td>

                                </tr>


                                <tr>
                                    <td style="padding: 15px;">
                                        <label for="">Sale Cost :</label></td>
                                    <td style="padding-left: 80px; padding-bottom: 15px;">
                                        <asp:Label ID="lblsalecost" runat="server" Text=""></asp:Label>
                                    </td>

                                </tr>

                                <tr>
                                    <td style="padding: 15px;">
                                        <label for="">Purchase Cost :</label></td>
                                    <td style="padding-left: 80px; padding-bottom: 15px;">
                                        <asp:Label ID="lblpurchasecost" runat="server" Text=""></asp:Label>
                                    </td>

                                </tr>

                            </table>
                                                   

                             <span style="padding-left:15px;"><asp:Button ID="btnadd" CssClass="btn btn-info" runat="server" ValidationGroup="hardware" Text="ADD" OnClick="btnadd_Click" /></span>

                             </div>
                                 </div>


                        </div>
                    </div>
                          <div class="hpanel" id="hidepanel"  runat="server" visible="false">
                        <h4>Order Product list</h4>

                        <div class="panel-body">
                             <div class="row">
                                 <div class="col-lg-12">


                                    <div class="card">
                            <div class="card-body">
                                
                                <div class="row g-3">

                                    <table class="table table-striped table-bordered table-hover">
                                        <asp:Repeater ID="repeater1" runat="server" OnItemDataBound="OnItemDataBound">
                                            <HeaderTemplate>

                                                <tr>
                                                   

                                                    <th style="display: none;">ID </th>
                                                                <th style="display: none;">Center ID </th>
                                                                <th style="display: none;">Supplier ID </th>
                                                                <th style="display: none;">Desc </th>
                                                                <th style="text-align: center;">Name </th>
                                                                <th style="text-align: center;">Quantity</th>
                                                                <th style="text-align: center;">GST(%)</th>
                                                                <th style="text-align: center;">Discount(%)</th>
                                                                <th style="text-align: center;">Price per pc </th>
                                                                <th style="text-align: center;">Total Price </th>
                                                                <th style="text-align: center;">Action </th>

                                                </tr>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr id="rptrCallHistoryTr" class="dg_alt_item">
                                                                <td style="display: none">
                                                                    <asp:Label ID="orderid" runat="server" Text='<%# Eval("pk_trpo_id") %>' />
                                                                </td>

                                                                <td style="display: none">
                                                                    <asp:Label ID="lblwh" runat="server" Text='<%# Eval("trpo_wh_id") %>' />
                                                                </td>

                                                                <td style="display: none">
                                                                    <asp:Label ID="lblsplr" runat="server" Text='<%# Eval("trpo_splr_id") %>' />
                                                                </td>

                                                                <td style="display: none">
                                                                    <asp:Label ID="lbldesc" runat="server" Text='<%# Eval("trpo_desc") %>' />
                                                                </td>

                                                                <td style="text-align: center;"><%# Eval("item_name") %> </td>

                                                                <td style="text-align: center;">
                                                                    <asp:TextBox ID="txtquantity1" runat="server" Text='<%# Eval("trpo_item_qty") %>'></asp:TextBox>
                                                                </td>

                                                                <asp:HiddenField ID="hdstatus" runat="server" Value='<%# Eval("trpo_tax_percent") %>' />
                                                                <td style="text-align: center;">
                                                                    <asp:DropDownList runat="server" ID="ddlgstre" class="form-control">
                                                                        <asp:ListItem Value="10">10</asp:ListItem>
                                                                        <asp:ListItem Value="12">12</asp:ListItem>
                                                                        <asp:ListItem Value="18">18</asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>

                                                                <td style="text-align: center;">
                                                                    <asp:TextBox ID="txtdiscount" runat="server" Text='<%# Eval("trpo_discount_percent") %>'></asp:TextBox>
                                                                </td>

                                                                <td style="text-align: center;">
                                                                    <asp:Label ID="lblprice" runat="server" Text='<%# Eval("trpo_item_price") %>'></asp:Label></td>

                                                                 <td style="text-align: center;">
                                                                    <asp:Label ID="lblfinalprice" runat="server" Text='<%# Eval("final_price") %>'></asp:Label></td>

                                                                <td style="text-align: center;">
                                                                    <asp:LinkButton ID="lnkDelete" Text="Delete" CssClass="btn btn-danger" runat="server" OnClientClick="return confirm('Do you want to delete this Order?');"
                                                                        OnClick="DeleteCustomer" />
                                                                </td>

                                                            </tr>
                                            </ItemTemplate>

                                        </asp:Repeater>
                                        </table>
                                         
                                                <asp:Button ID="btnUpdateCart" Text="Update Order" CssClass="btn" Style="background-color: #FF7F50; color: white;"
                                                    ValidationGroup="02" runat="server" OnClick="btnUpdateCart_Click" />
                                                <span class="form-group form-group-lg-4 form-inline pull-right">
                                                    <asp:Button ID="btnplace" CssClass="btn btn-warning " runat="server" Text="Place Order" OnClick="btnplace_Click" Width="143px" />

                                                </span>
                                          
                                                
                            
                                        </div>

                                    </div>
                                        <style>
                                             .hpanel .panel-body {
                                background: #a2b0ca;
                                border: 1px solid #f2e7c3;
                                border-radius: 2px;
                                padding: 20px;
                            }
                                        </style>
                                    

                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>


    <!-- Main Wrapper End-->

   
</asp:Content>
