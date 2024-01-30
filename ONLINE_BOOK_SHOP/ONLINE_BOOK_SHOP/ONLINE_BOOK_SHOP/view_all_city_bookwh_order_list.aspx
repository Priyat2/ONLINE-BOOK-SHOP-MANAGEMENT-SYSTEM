<%@ Page Title="Warehouse- Order Details" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="view_all_city_bookwh_order_list.aspx.cs" Inherits="ONLINE_BOOK_SHOP.view_all_city_bookwh_order_list" %>
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
                            <asp:HiddenField ID="getid" runat="server" />
                            <%--<span class="form-group form-group-lg-4 form-inline pull-right">
                                <asp:Button ID="btnback" CssClass="btn" Style="background-color: #48C9B0; color: white;" runat="server" Text="Back" OnClick="btnback_Click" />
                            </span>--%>
                            <div>
                                <h3><b>Order Details :</b></h3>
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
                                        <asp:Label Style="padding-left: 15px;" runat="server" Text="" ID="lbltotalqty"></asp:Label>
                                </div>
                                <div class="column">
                                    <label><b>Order price : </b></label>
                                    <asp:Label runat="server" Text="" ID="lbltotalprice"></asp:Label>
                                </div>
                            </div>

                               <div class="row">
                                  <div class="column">
                                    <label><b>Order Description :</b></label>
                                    <asp:Label Style="padding-left: 15px;" runat="server" Text="" ID="lbldesc"></asp:Label>
                                 </div>
                                  <div class="column">
                                    <label><b>Delivery Remark :</b></label>
                                        <asp:Label Style="padding-left: 15px;" runat="server" Text="" ID="lblremark"></asp:Label>
                                   </div>

                                </div>
                       
                        <hr />


                        <div>
                            <asp:Repeater ID="Repeater" runat="server">
                                <HeaderTemplate>
                                    <table cellpadding="2" cellspacing="1" class="table table1  table-hover">
                                        <tr>

                                            <th class="color th1" scope="col">Book Item Name</th>
                                            <th class="color th1" scope="col">Quantity</th>
                                            <th class="color th1" scope="col">Price(per item)</th>

                                            <th class="color th1" scope="col">Total Amount</th>
                                            <th class="color th1" scope="col">Confirm Item</th>


                                        </tr>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <tr>

                                        <td class="td1"><%# DataBinder.Eval(Container, "DataItem.book_item_name")%></td>
                                        <td class="td1"><%# DataBinder.Eval(Container, "DataItem.tr_order_item_qty")%></td>
                                        <td class="td1"><%# DataBinder.Eval(Container, "DataItem.tr_order_Item_price")%></td>

                                        <td class="td1"><%# DataBinder.Eval(Container, "DataItem.tr_order_item_total_price")%></td>
                                        <td class="td1"><%# DataBinder.Eval(Container, "DataItem.tr_order_confm_qty")%></td>

                                    </tr>
                                </ItemTemplate>
                                <FooterTemplate>
                                    </table>
                                </FooterTemplate>

                            </asp:Repeater>
                            <style>
                                .table1, .th1, .td1 {
                                    border: 1px solid;
                                    justify-content: center;
                                    text-align: center;
                                }

                                .color {
                                    background-color: lightseagreen;
                                    color: white;
                                }

                                .hpanel .panel-body {
                                background: #f2e7c3;
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

    <!--end main wrappper-->
</asp:Content>

