<%@ Page Title="Book Center- Place Order" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Citybookwh_to_mainbookwh.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Citybookwh_to_mainbookwh" %>

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
                        <h4>Purchase From Book Center</h4>
                        <div class="panel-body">

                            <asp:HiddenField ID="hdnpoid" runat="server" />

                            <div>
                                <table>

                                    <tr>
                                        <td>
                                            <label for="">Select Book Item Name : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 25px;">
                                            <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlitemname" AutoPostBack="true" class="form-control" OnSelectedIndexChanged="ddlitemname_SelectedIndexChanged1">
                                                <asp:ListItem Value="0">-Select Items-</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator5" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlitemname"
                                                ErrorMessage="Please Select Item Name" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">Book Item Unit :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 25px;">
                                            <asp:Label ID="lblunits" runat="server" Text=""></asp:Label></td>

                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Item Quantity : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 25px;">
                                            <asp:TextBox ID="txtqty" runat="server" placeholder="Enter Item Quantity" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="hardware" ControlToValidate="txtqty" ErrorMessage="Enter Item Quantity"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>



                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">In Stock Quantity :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 25px;">
                                            <asp:Label ID="lblqty" runat="server" Text=""></asp:Label></td>

                                    </tr>

                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">Warehouse In Stock Quantity :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 25px;">
                                            <asp:Label ID="lblmainqty" runat="server" Text=""></asp:Label></td>

                                    </tr>



                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">Sale Cost :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 25px;">
                                            <asp:Label ID="lblsalecost" runat="server" Text=""></asp:Label></td>

                                    </tr>

                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">Purchase Cost :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 25px;">
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
                                                                <th style="display: none;">book ID </th>
                                                                <th style="text-align: center;">Name </th>
                                                                <th style="text-align: center;">Quantity</th>
                                                                <th style="text-align: center;">Price </th>
                                                                <th style="text-align: center;">Action </th>

                                                            </tr>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <tr id="rptrCallHistoryTr" class="dg_alt_item">
                                                                <td style="display: none; background-color: lightgoldenrodyellow">
                                                                    <asp:Label ID="orderid" runat="server" Text='<%# Eval("pk_tr_order_book_id") %>' />
                                                                </td>

                                                                <td style="display: none; background-color: lightgoldenrodyellow">
                                                                    <asp:Label ID="lblwh" runat="server" Text='<%# Eval("tr_order_cre_by") %>' />
                                                                </td>

                                                                <td style="text-align: center; background-color: lightgoldenrodyellow"><%# Eval("book_item_name") %> </td>

                                                                <td style="text-align: center; background-color: lightgoldenrodyellow">
                                                                    <asp:TextBox ID="txtquantity1" runat="server" Text='<%# Eval("tr_order_item_qty") %>'></asp:TextBox>
                                                                </td>

                                                                <td style="text-align: center; background-color: lightgoldenrodyellow">
                                                                    <asp:Label ID="lblprice" runat="server" Text='<%# Eval("tr_order_Item_price") %>'></asp:Label></td>

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
                            <%--<script>
                                    function next(id) {
                                        window.open('view_rec_bookwh_to_citybookwh_by_item.aspx?id=' + id + '')
                                    }
                             </script>--%>
                        </div>
                    </div>
                    <%--   </div>--%>
                </div>
            </div>

        </div>
    </div>


    <!-- Main Wrapper End-->

</asp:Content>
