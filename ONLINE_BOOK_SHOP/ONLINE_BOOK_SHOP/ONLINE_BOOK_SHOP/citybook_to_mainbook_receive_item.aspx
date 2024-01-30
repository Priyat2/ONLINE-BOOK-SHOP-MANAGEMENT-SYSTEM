<%@ Page Title="Book- Confirm Order" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="citybook_to_mainbook_receive_item.aspx.cs" Inherits="ONLINE_BOOK_SHOP.citybook_to_mainbook_receive_item" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>

    <style>
        .content2 {
            padding: 10px 40px 25px 40px;
            min-width: 320px;
        }

        * {
            box-sizing: border-box;
        }

        /* Create three equal columns that floats next to each other */
        .column {
            float: left;
            width: 45.33%;
            padding: 10px;
            /* Should be removed. Only for demonstration */
        }

        table, td {
            font-size: 12px;
            background-color: lightcyan;
        }

        /* Clear floats after the columns */
        .row:after {
            content: "";
            display: table;
            clear: both;
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

                        <div class="panel-body">
                            <span class="form-group form-group-lg-4 form-inline pull-right">
                                <asp:Button ID="btnback" CssClass="btn" Style="background-color: #48C9B0; color: white;" runat="server" Text="Back" OnClick="btnback_Click" />
                            </span>

                            <div>
                                <h3><b>Order Details :</b></h3>
                                <b>Order ID :</b>
                                <asp:Label runat="server" Text="" ID="lblorderid1"></asp:Label>
                                -
                                <asp:Label runat="server" Text="" ID="lbllocation"></asp:Label>

                                <span class="form-group form-group-lg-4 form-inline pull-right"><b>Order Date : </b>
                                    <asp:Label runat="server" Text=" " ID="lbldate"></asp:Label>
                                </span>

                            </div>
                            <hr />
                            <div class="row">

                                <div class="column">

                                    <label><b>Order Quantity :</b></label>
                                    <asp:Label Style="padding-left: 15px;" runat="server" Text="" ID="lbltotalqty"></asp:Label>
                                </div>
                                <div class="column">
                                    <label><b>Order price : </b></label>
                                    <asp:Label runat="server" Text="" ID="lbltotalprice"></asp:Label>
                                </div>
                            </div>
                            <div>
                                <div class="column">
                                    <label><b>Order Description :</b></label>
                                    <asp:Label Style="padding-left: 15px;" runat="server" Text="" ID="lbldesc"></asp:Label>
                                </div>
                                <div class="column">
                                    <label><b>Delivery  : </b></label>
                                    <asp:Label runat="server" Text="" ID="lblremark"></asp:Label>

                                </div>
                            </div>
                            <hr />

                            <asp:HiddenField ID="getid" runat="server" />
                            <div>
                                <asp:Repeater ID="Repeater" runat="server">
                                    <HeaderTemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col" style="display: none;">ID</th>
                                                <th scope="col" style="display: none;">Po Fk ID</th>
                                                <th scope="col" style="display: none;">Item Id</th>
                                                <th scope="col">Name</th>
                                                <th scope="col">Quantity</th>
                                                <th scope="col">Price(per item)</th>
                                                <th scope="col">Total Amount</th>
                                                <th scope="col">Confirm Items</th>
                                                <%--<th scope="col">Confirm By</th>--%>
                                                <th scope="col">Received item</th>
                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td style="display: none;">
                                                <asp:Label ID="lbltrpoid" runat="server" Text='<%# Eval("pk_tr_order_book_id") %>' /></td>
                                            <td style="display: none;">
                                                <asp:Label ID="lblpoid" runat="server" Text='<%# Eval("tr_order_fk_otw_id") %>' /></td>
                                            <td style="display: none;">
                                                <asp:Label ID="lblitemid" runat="server" Text='<%# Eval("tr_order_fk_item_id") %>' /></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.book_item_name")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.tr_order_item_qty")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.tr_order_item_price")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.tr_order_item_total_price")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.tr_order_confm_qty")%></td>
                                           <%-- <td><%# DataBinder.Eval(Container, "DataItem.confm")%></td>--%>
                                            <td>
                                                <asp:TextBox runat="server" ID="txtrecieved" Text='<%# Eval("tr_order_confm_qty") %>'></asp:TextBox></td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </table>
                                    </FooterTemplate>

                                </asp:Repeater>
                                <style>
                                    .hpanel .panel-body {
                                        background-color: #D4F1F4;
                                        border: 1px solid #D4F1F4;
                                        border-radius: 2px;
                                        padding: 20px;
                                    }

                                    table, th, td {
                                        border: 1px solid;
                                        justify-content: center;
                                        text-align: center;
                                    }

                                    th {
                                        background-color: lightseagreen;
                                        color: white;
                                    }
                                </style>
                            </div>
                            <span class="form-group form-group-lg-4 form-inline pull-right">
                                <asp:Button ID="btnsave" CssClass="btn" Style="background-color: #C39BD3; color: whitesmoke;" runat="server" Text="Save" OnClientClick="return confirmSave();" OnClick="btnsave_Click" />
                            </span>

                        </div>
                        <script>
                            function confirmSave() {
                                // Display SweetAlert confirmation
                                Swal.fire({
                                    title: 'Save Data',
                                    text: 'Are you sure you want to save the data?',
                                    icon: 'warning',
                                    showCancelButton: true,
                                    confirmButtonColor: '#3085d6',
                                    cancelButtonColor: '#d33',
                                    confirmButtonText: 'Yes, save it!'
                                }).then((result) => {
                                    // If user clicks 'Yes', proceed with server-side save
                                    if (result.isConfirmed) {
                                        // Call server-side save function
                                        <%= Page.ClientScript.GetPostBackEventReference(btnsave, null) %>;
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
    <!--end main wrappper-->
</asp:Content>
