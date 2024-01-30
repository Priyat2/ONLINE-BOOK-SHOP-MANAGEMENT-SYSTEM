<%@ Page Title="Supplier- Place Order" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Main_center_book_purchase_order.aspx.cs" Inherits="Warehouse.Main_center_book_purchase_order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
            color: white;
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
    <div id="wrapper">


        <div class="content2 animate-panel">
            <div class="row">
                <div class="col-lg-12" style="">
                    <div class="hpanel">
                        <h4>Purchase From Supplier</h4>
                        <div class="panel-body">

                            <asp:HiddenField ID="hdnpoid" runat="server" />

                            <div>
                                <table>
                                  

                                    <tr>
                                        <td>
                                            <label for="">Select Supplier : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;" >
                                            <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlsupplier" class="form-control" >
                                                <asp:ListItem Value="0">--Select Supplier--</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator1" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlsupplier"
                                                ErrorMessage="Please Select Supplier" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <%--         <tr>
                                        <td>
                                            <label for="">Select Item Type : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlitemtype" class="form-control">
                                                <asp:ListItem Value="0">--Select Item Type--</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator3" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlitemtype"
                                                ErrorMessage="Please Select Item Type" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>--%>

                                    <tr>
                                        <td>
                                            <label for="">Select Item Name : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlitemname" AutoPostBack="true" class="form-control" OnSelectedIndexChanged="ddlitemname_SelectedIndexChanged1">
                                                <asp:ListItem Value="0">-Select Book Item-</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
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

                                  <%--  <tr>
                                        <td>
                                            <label for="">Enter Product Description : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtprodesc" runat="server" TextMode="MultiLine" placeholder="Enter Product Description" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="hardware" ControlToValidate="txtprodesc" ErrorMessage="Enter Product Description"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>--%>



                                    <tr>
                                        <td>
                                            <label for="">Enter Item Quantity : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtqty" runat="server" placeholder="Enter Item Quantity" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="hardware" ControlToValidate="txtqty" ErrorMessage="Enter Item Quantity"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                        <tr>
                                        <td>
                                            <label for="">GST : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlgst" class="form-control">
                                                <asp:ListItem Value="0">--Select GST--</asp:ListItem>
                                                <asp:ListItem Value="10">10%</asp:ListItem>
                                                <asp:ListItem Value="12">12%</asp:ListItem>
                                                <asp:ListItem Value="18">18%</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator3" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlgst"
                                                ErrorMessage="Please Select GST" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label for="">Discount(%) : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtdiscount" runat="server" Text="0" placeholder="Enter Discount" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="hardware" ControlToValidate="txtdiscount" ErrorMessage="Enter Item Quantity"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">In Stock Quantity :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:Label ID="lblqty" runat="server" Text=""></asp:Label></td>

                                    </tr>



                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">Sale Cost :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:Label ID="lblsalecost" runat="server" Text=""></asp:Label></td>

                                    </tr>

                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">Purchase Cost :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:Label ID="lblpurchasecost" runat="server" Text=""></asp:Label></td>

                                    </tr>
                                </table>
                                <br />
                                <br />
                                <span style="padding-right: 400px;">
                                    <asp:Button ID="btnadd" CssClass="btn btn-warning" runat="server" ValidationGroup="hardware" Text="Add Product" OnClick="btnadd_Click" /></span>


                            </div>


                        </div>
                    </div>

                    <div id="hidepanel" runat="server" visible="false">

                        <h4>Order Product list</h4>
                        <div class="panel-body">


                            <div class="row">
                                <div class="col-lg-12">


                                    <div class="card">
                                        <div class="card-body">
                                            <%-- <span class="form-group form-group-lg-4 form-inline pull-right">
                                                <asp:Button ID="btnshow" CssClass="btn" style="background-color:#9FE2BF; color:green;" runat="server" Text="Show Order" OnClick="btnshow_Click" />
                                            </span>--%>



                                            <div class="row g-3">
                                                <table class="table table-striped table-bordered table-hover">
                                                    <asp:Repeater ID="repeater" runat="server">
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
                                                                <td style="display: none; background-color: lightgoldenrodyellow">
                                                                    <asp:Label ID="orderid" runat="server" Text='<%# Eval("pk_trpo_id") %>' />
                                                                </td>

                                                                <td style="display: none; background-color: lightgoldenrodyellow">
                                                                     <asp:Label ID="lblwh" runat="server" Text='<%# Eval("trpo_wh_id") %>' />
                                                                </td>

                                                                <td style="display: none; background-color: lightgoldenrodyellow">
                                                                    <asp:Label ID="lblsplr" runat="server" Text='<%# Eval("trpo_splr_id") %>' />
                                                                </td>

                                                                 <td style="display: none; background-color: lightgoldenrodyellow">
                                                                    <asp:Label ID="lbldesc" runat="server" Text='<%# Eval("trpo_desc") %>' />
                                                                </td>


                                                                <td style="text-align: center; background-color: lightgoldenrodyellow"><%# Eval("book_item_name") %> </td>

                                                                <td style="text-align: center; background-color: lightgoldenrodyellow">
                                                                    <asp:TextBox ID="txtquantity1" runat="server" Text='<%# Eval("tr_order_item_qty") %>'></asp:TextBox>
                                                                </td>

                                                                 <asp:HiddenField ID="hdstatus" runat="server" Value='<%# Eval("trpo_tax_percent") %>' />
                                                                <td style="text-align: center;">
                                                                    <asp:DropDownList runat="server" ID="ddlgstre" class="form-control">
                                                                        <asp:ListItem Value="10">10</asp:ListItem>
                                                                        <asp:ListItem Value="12">12</asp:ListItem>
                                                                        <asp:ListItem Value="18">18</asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>

                                                                <td style="text-align: center; background-color: lightgoldenrodyellow">
                                                                    <asp:TextBox ID="txtdiscount" runat="server" Text='<%# Eval("trpo_discount_percent") %>'></asp:TextBox>
                                                                    </td>

                                                                 <td style="text-align: center; background-color: lightgoldenrodyellow">
                                                                    <asp:Label ID="lblprice" runat="server" Text='<%# Eval("trpo_item_price") %>'></asp:Label></td>
                                                                    </td>

                                                                <td style="text-align: center; background-color: lightgoldenrodyellow">
                                                                     <asp:Label ID="lblfinalprice" runat="server" Text='<%# Eval("final_price") %>'></asp:Label></td>
                                                                    </td>

                                                                <td style="text-align: center; background-color: lightgoldenrodyellow">
                                                                    <asp:LinkButton ID="lnkDelete" Text="Delete" class="button6 button7" runat="server" OnClientClick="return confirm('Do you want to delete this Order?');"
                                                                        OnClick="DeleteCustomer" />
                                                                </td>

                                                                <%-- <td>
                                                              <asp:LinkButton ID="lnkDelete" runat="server" OnClientClick='<%# "next(" + Eval("pk_tr_order_book_id") + "); " %>'  Text='<img src="images/delete1.png" style="width: 30px; height: 30px;">'></asp:LinkButton></td>
                                                                --%>
                                                            </tr>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </table>
                                            </div>
                                            <asp:Button ID="btnUpdateCart" Text="Update Order" class="button3 button1" ValidationGroup="02"
                                                runat="server" OnClientClick="return confirmUpdate();" OnClick="btnUpdateCart_Click" />

                                            <span class="form-group form-group-lg-4 form-inline pull-right">
                                                <asp:Button ID="btnplace" class="button4 button5" runat="server" Text="Place Order" OnClientClick="return confirmReceiveOrder();" OnClick="btnplace_Click" />
                                            </span>

                                        </div>
                                        <style>
                                            .hpanel .panel-body {
                                                background: #F2E7C3;
                                                border: 1px solid #F2E7C3;
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
                                                width: 140px;
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
                    <%--   </div>--%>
                </div>
            </div>

        </div>
    </div>


    <!-- Main Wrapper End-->

</asp:Content>