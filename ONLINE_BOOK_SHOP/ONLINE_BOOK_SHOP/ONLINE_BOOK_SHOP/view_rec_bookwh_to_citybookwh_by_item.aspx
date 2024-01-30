<%@ Page Title="Book- Order Details" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="view_rec_bookwh_to_citybookwh_by_item.aspx.cs" Inherits="ONLINE_BOOK_SHOP.view_rec_bookwh_to_citybookwh_by_item" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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


        /* Clear floats after the columns */
        .row:after {
            content: "";
            display: table;
            clear: both;
        }

         table, td {
            font-size: 12px;
            background-color:lightcyan;
        }

          th {
            background-color: #75E6DA;
            font-weight: bold;
            color:black;
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
                        <h4>Order Details</h4>
                        <div class="panel-body">
                            <asp:HiddenField ID="getid" runat="server" />

                            <div>

                                <b>Order ID :</b>
                                <asp:Label runat="server" Text=" " ID="lblorderid1"></asp:Label>
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
                                    <asp:Label Style="padding-left: 20px;" runat="server" Text="" ID="lbltotalqty"></asp:Label>
                                </div>
                                <div class="column">
                                    <label><b>Order price : </b></label>
                                    <asp:Label runat="server" Text="" ID="lbltotalprice"></asp:Label>
                                </div>
                            </div>
                            <div>
                                <div class="row">
                                    <div class="column">
                                        <label><b>Order Description :</b></label>
                                        <asp:Label Style="padding-left: 20px;" runat="server" Text="" ID="lbldesc"></asp:Label>
                                    </div>
                                    <div>
                                        <label><b>Delivery Remark :</b></label>
                                        <asp:Label runat="server" Text="" ID="lblremark"></asp:Label>
                                    </div>
                                </div>
                                <%-- <hr />--%>
                            </div>
                        </div>
                    </div>
                    <br />


                  <%-- <div class="hpanel">--%>
    <div>

        <h4>Item Ordered List</h4>
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
                                                <th style="text-align: center;">Book Item Name</th>
                                                <th style="text-align: center;">Quantity</th>
                                                <th style="text-align: center;">Price(per item) </th>
                                                <th style="text-align: center;">Total Amount </th>
                                                <th style="text-align: center;">Confirm Item </th>
                                                <th style="text-align: center;">Receive Item </th>
                                            </tr>

                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <tr id="rptrCallHistoryTr" class="dg_alt_item">
                                                <td class="td1"><%# DataBinder.Eval(Container, "DataItem.book_item_name")%></td>
                                                <td class="td1"><%# DataBinder.Eval(Container, "DataItem.tr_order_item_qty")%></td>
                                                <td class="td1"><%# DataBinder.Eval(Container, "DataItem.tr_order_Item_price")%></td>
                                                <td class="td1"><%# DataBinder.Eval(Container, "DataItem.tr_order_item_total_price")%></td>
                                                <td class="td1"><%# DataBinder.Eval(Container, "DataItem.tr_order_confm_qty")%></td>
                                                <td class="td1"><%# DataBinder.Eval(Container, "DataItem.tr_order_receive_qty")%></td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </table>

                                <style>
                                    .hpanel .panel-body {
                                        background-color:#D4F1F4;
                                        border: 1px solid #D4F1F4;
                                        border-radius: 2px;
                                        padding: 20px;
                                    }
                                </style>
                                <style>
                                    .table1,
                                    .th1,
                                    .td1 {
                                        border: 1px solid;
                                        justify-content: center;
                                        text-align: center;
                                    }

                                    .color {
                                        background-color: #99C221;
                                        color: #99C221;
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


                </div>
            </div>
            </div>
        </div>
            <!-- Main Wrapper End-->

           
</asp:Content>
