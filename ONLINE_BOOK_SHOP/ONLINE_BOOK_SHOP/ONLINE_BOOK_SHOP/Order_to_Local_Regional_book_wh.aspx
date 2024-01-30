<%@ Page Title="Local- Receive Order" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Order_to_Local_Regional_book_wh.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Order_to_Local_Regional_book_wh" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>

     
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
    <style>
        table, th, td {
            /*border: 1px solid;*/
            justify-content: center;
            text-align: center;
        }

        th {
            background-color: #99C221;
            color: white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <!-- Main Wrapper -->
     <div id="wrapper">
       <div class="content2 animate-panel">
            <div class="row">
                <div class="col-lg-12" style="">
                    <div class="hpanel">
                         <h4>Purchase From Local</h4>
                        <div class="panel-body">
                           
                            <asp:HiddenField ID="hdnpoid" runat="server" />

                            <div>
                                <table>
                                   
                                     <tr>
                                        <td>
                                            <label for="">Select Item Name : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlitemname" AutoPostBack="true" class="form-control" OnSelectedIndexChanged="ddlitemname_SelectedIndexChanged1">
                                                <asp:ListItem Value="0">-Select Book Item-</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;" class="auto-style1">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator5" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlitemname"
                                                ErrorMessage="Please Select Item Name" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    
                                       <tr style="padding: 15px;">
                                        <td>
                                            <label for="">Item Unit :</label></td>
                                        <td style="padding-left: 80px; padding-bottom:25px;">
                                            <asp:Label ID="lblunits" runat="server" Text=""></asp:Label></td>

                                    </tr>

                                      <tr>
                                        <td>
                                            <label for="">Enter Item Quantity : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtqty" runat="server" placeholder="Enter Item Quantity" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ValidationGroup="hardware" ControlToValidate="txtqty" ErrorMessage="Enter Item Quantity"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                     <tr>
                                        <td>
                                            <label for="">Enter Local Shop : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtlocal" runat="server" placeholder="Enter Local Shop" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="hardware" ControlToValidate="txtlocal" ErrorMessage="Enter Local Shop"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>
                                 
                                       <tr>
                                        <td>
                                            <label for="">Enter Purchase Cost : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtpurchasecost" runat="server" placeholder="Enter Purchase Cost" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="hardware" ControlToValidate="txtpurchasecost" ErrorMessage="Enter Purchase Cost"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                      <tr>
                                        <td>
                                            <label for="">Discount(%) : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtdiscount" runat="server" Text="0" placeholder="Enter Discount"  class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="hardware" ControlToValidate="txtdiscount" ErrorMessage="Enter Discount"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                     <tr>
                                        <td>
                                            <label for="">Enter GST : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtGSTs" runat="server" Text="0" placeholder="Enter GST" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="hardware" ControlToValidate="txtGSTs" ErrorMessage="Enter GST"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                     
                                          <tr>
                                        <td>
                                            <label for="">Enter Expiry Date : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtexdt" runat="server" Text="0" placeholder="Enter Expiry Date" TextMode="Date" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ValidationGroup="hardware" ControlToValidate="txtexdt" ErrorMessage="Select Date"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                      <tr style="padding: 15px;">
                                        <td>
                                            <label for="">In Stock Quantity :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:Label ID="lblqty" runat="server" Text=""></asp:Label></td>

                                    </tr>

                                </table>
                               </br>

                                  <span style="padding-left:10px;">
                                  <asp:Button ID="btnsave" CssClass="btn btn-warning" runat="server" ValidationGroup="hardware" Text="Save"  OnClick="btnsave_Click" /></span>

                            </div>


                        </div>
                    </div>

                       <div id="panelid" visible="false" runat ="server">
                         <h4>Order Product List</h4>
                        <div class="panel-body">


                            <div class="row">
                                <div class="col-lg-12">


                                    <div class="card">
                                        <div class="card-body">
                                        
                                           

                                            <div class="row g-3">
                                                <table class="table table-striped table-bordered table-hover">
                                                    <asp:Repeater ID="repeater" runat="server">
                                                        <HeaderTemplate>
                                                            <tr>
                                                                <th style="display: none;">ID </th> 
                                                                <th style="display: none;">Item ID </th>                                             
                                                                <th style="text-align: center;">Name </th>                                            
                                                                 <th style="text-align: center;">Quantity</th>
                                                                <th style="display: none;"">Local Shop</th>                                                                
                                                                <th style="text-align: center;">Price per pc</th>
                                                                <th style="text-align: center;">Discount(%)</th>
                                                                <th style="text-align: center;">GST(%)</th>   
                                                                <th style="text-align: center;">Total Price </th>                                                            
                                                                <th style="text-align: center;">Action </th>

                                                            </tr>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <tr id="rptrCallHistoryTr" class="dg_alt_item">
                                                                <td style="display: none">
                                                                    <asp:Label ID="localorderid" runat="server" Text='<%# Eval("pk_trlo_id") %>' />

                                                                </td>

                                                                   <td style="display: none">
                                                                    <asp:Label ID="lblitem_id" runat="server" Text='<%# Eval("trlo_fk_item_id") %>' />

                                                                </td>
                                                      
                                                                <td style="text-align: center; background-color:#f2e7c3;" ><%# Eval("book_item_name") %> </td>

                                                                 <td style="text-align: center; background-color:#f2e7c3;">
                                                                 <asp:TextBox ID="txtqty" runat="server" CssClass="form-control"  Text='<%# Eval("trlo_item_qty") %>'></asp:TextBox></td>

                                                                 <td style="display: none">
                                                                    <asp:TextBox ID="txtlocal" runat="server" CssClass="form-control"  Text='<%# Eval("trlo_local_shop") %>'></asp:TextBox>
                                                                </td>

                                                                <td style="text-align: center; background-color:#f2e7c3;">
                                                                    <asp:TextBox ID="txtprice" runat="server" CssClass="form-control" Text='<%# Eval("trlo_item_price") %>'></asp:TextBox>
                                                                </td>

                                                                 <td style="text-align: center; background-color:#f2e7c3;">
                                                                    <asp:TextBox ID="txtdiscount" runat="server" CssClass="form-control" Text='<%# Eval("trlo_discount_percent") %>'></asp:TextBox>
                                                                </td>

                                                                 <td style="text-align: center; background-color:#f2e7c3;">
                                                                    <asp:TextBox ID="txtGST" runat="server" CssClass="form-control"  Text='<%# Eval("trlo_tax_percent") %>'></asp:TextBox>
                                                                </td>

                                                                  <td style="text-align: center; background-color:#f2e7c3;">
                                                                    <asp:Label ID="lblfinalprice" runat="server" Text='<%# Eval("final_price") %>'></asp:Label></td>

                                                               

                                                                <td style="text-align: center; background-color:#f2e7c3;">
                                                                    <asp:LinkButton ID="lnkDelete" Text="Delete" class="button6 button7" runat="server" OnClientClick="return confirm('Do you want to delete this Order?');"
                                                                        OnClick="DeleteCustomer" />
                                                                </td>

                                                            </tr>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </table>
                                            </div>
                                            <asp:Button ID="btnUpdateCart" Text="Update Order" class="button3 button1"  ValidationGroup="02"
                                                runat="server" OnClientClick="return confirmUpdate();" OnClick="btnUpdateCart_Click" />

                                            <span class="form-group form-group-lg-4 form-inline pull-right">
                                                <asp:Button ID="btnplace" class="button4 button5" runat="server" Text="Receive Order" OnClientClick="return confirmReceiveOrder();" OnClick="btnplace_Click" />
                                            </span>



                                        </div>
                                        <style>
                                            .hpanel .panel-body {
                                                background: #f2e7c3;
                                                border: 1px solid #e4e5e7;
                                                border-radius: 2px;
                                                padding: 20px;
                                            }


                                            .button3 {
                                                background-color: #0dcaf0; /* Green */
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

                                            .button1 {
                                                background-color: white;
                                                color: #0dcaf0;
                                                border: 2px solid #0dcaf0;
                                            }

                                                .button1:hover {
                                                    background-color: #0dcaf0;
                                                    color: white;
                                                }

                                            .button1 {
                                                width: 140px;
                                            }

                                            .button1 {
                                                border-radius: 8px;
                                            }

                                            .button4 {
                                                background-color: #198754; /* Green */
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

                                            .button5 {
                                                background-color: white;
                                                color: #198754;
                                                border: 2px solid #198754;
                                            }

                                                .button5:hover {
                                                    background-color: #198754;
                                                    color: white;
                                                }

                                            .button5 {
                                                width: 140px;
                                            }

                                            .button5 {
                                                border-radius: 8px;
                                            }

                                            .button6 {
                                                background-color: #ff2400; /* Green */
                                                border: none;
                                                color: white;
                                                padding: 7px 2px;
                                                text-align: center;
                                                text-decoration: none;
                                                display: inline-block;
                                                font-size: 16px;
                                                margin: 4px 2px;
                                                transition-duration: 0.4s;
                                                cursor: pointer;
                                            }

                                            .button7 {
                                                background-color: white;
                                                color: #ff2400;
                                                border: 2px solid #ff2400;
                                            }

                                                .button7:hover {
                                                    background-color: #ff2400;
                                                    color: white;
                                                }

                                            .button7 {
                                                width: 100px;
                                            }

                                            .button7 {
                                                border-radius: 8px;
                                            }
                                        </style>
                                    </div>
                                    <script>
                                        function confirmUpdate() {
                                            // Display SweetAlert confirmation
                                            Swal.fire({
                                                title: 'Update Order',
                                                text: 'Are you sure you want to update the order?',
                                                icon: 'warning',
                                                showCancelButton: true,
                                                confirmButtonColor: '#3085d6',
                                                cancelButtonColor: '#d33',
                                                confirmButtonText: 'Yes, update it!'
                                            }).then((result) => {
                                                // If user clicks 'Yes', proceed with server-side update
                                                if (result.isConfirmed) {
                                              // Call server-side update function
                                              <%= Page.ClientScript.GetPostBackEventReference(btnUpdateCart, null) %>;
                                                }
                                                });

                                            // Prevent postback
                                            return false;
                                        }

                                        function confirmReceiveOrder() {
                                            // Display SweetAlert confirmation
                                            Swal.fire({
                                                title: 'Receive Order',
                                                text: 'Are you sure you want to receive the order?',
                                                icon: 'warning',
                                                showCancelButton: true,
                                                confirmButtonColor: '#3085d6',
                                                cancelButtonColor: '#d33',
                                                confirmButtonText: 'Yes, receive it!'
                                            }).then((result) => {
                                                // If user clicks 'Yes', proceed with server-side receive order
                                                if (result.isConfirmed) {
                                                 // Call server-side receive order function
                                                  <%= Page.ClientScript.GetPostBackEventReference(btnplace, null) %>;
                                            }
                                             });

                                            // Prevent postback
                                            return false;
                                        }

                                       
                                    </script>

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
