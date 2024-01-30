<%@ Page Title="Local- Order Records" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Order_to_Local_Regionalwh_book_report.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Order_to_Local_Regionalwh_book_report" %>

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
            width: 22.33%;
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
    <!--end main wrappper-->

    <div id="wrapper">
        <div class="content2 animate-panel">
            <div class="row">

                <div class="col-lg-12" style="">
                    <div class="hpanel">
                        <h4>Report of Purchase Orders From Local (Based on Recieve Date)</h4>
                        <div class="panel-body">


                            <div class="card">
                                <div class="card-body">


                                    <div class="row">
                                        <div class="column">
                                            <label for="">Start Date</label>
                                            <asp:TextBox ID="startdate" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                                        </div>

                                        <div class="column">
                                            <label style="padding-left: 15px;" for="">End Date</label>
                                            <asp:TextBox ID="enddate" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                                        </div>

                                        <div class="column">
                                            <span style="padding-left: 15px;">
                                                <asp:Button ID="Button2" Text="Show Reports" runat="server" class="button button2" OnClick="Button2_Click" /></span>
                                        </div>
                                    </div>
                                    <br />

                                    <div>
                                        <asp:Repeater ID="Repeat" runat="server">
                                            <HeaderTemplate>

                                                <table cellpadding="2" cellspacing="1" class="table table-hover">

                                                    <thead>
                                                        <tr>
                                                            <th scope="col">PO ID </th>
                                                            <th scope="col">Center</th>
                                                            <th scope="col">Local shop</th>
                                                            <th scope="col">Total Quantity</th>
                                                            <th scope="col">Total Price</th>

                                                            <th scope="col">Order Date</th>
                                                            <th scope="col">Order by</th>
                                                            <%--  <th scope="col">Status</th>--%>
                                                            <th scope="col">Action </th>


                                                        </tr>
                                                    </thead>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tbody>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="cmrnid" runat="server" Text='<%# Eval("pk_lo_id")%>' />
                                                        </td>
                                                        <td><%# DataBinder.Eval(Container, "DataItem.center_name")%></td>
                                                        <td><%# DataBinder.Eval(Container, "DataItem.trlo_local_shop")%></td>
                                                        <%-- <td><%# DataBinder.Eval(Container, "DataItem.splr_name")%></td>--%>
                                                        <td><%# DataBinder.Eval(Container, "DataItem.lo_item_qty")%></td>
                                                        <td><%# DataBinder.Eval(Container, "DataItem.lo_item_price")%></td>
                                                        <%--   <td><%# DataBinder.Eval(Container, "DataItem.lo_discount_percent")%></td>
                                                        <td><%# DataBinder.Eval(Container, "DataItem.lo_tax_percent")%></td>--%>
                                                        <td><%# DataBinder.Eval(Container, "DataItem.lo_order_dt")%></td>
                                                        <%--<td> <span Style="color:<%# Eval("color") %>;"><%# Eval("status")%></span>  </td>--%>
                                                        <td><%# DataBinder.Eval(Container, "DataItem.user_name")%></td>

                                                        <td>

                                                            <asp:LinkButton ID="btnid" runat="server" OnClientClick='<%# "next(" + Eval("pk_lo_id") + "); " %>' Style="color: blue;" Text='<img src="images/view.png">'></asp:LinkButton>
                                                            |
                                                            <asp:LinkButton ID="bntpdf" runat="server" OnClientClick='<%#"nextss(" + Eval("pk_lo_id") + "); " %>' Style="color: blue;" Text='<img src="images/print.png">'></asp:LinkButton>
                                                        </td>

                                                    </tr>
                                                </tbody>

                                            </ItemTemplate>
                                            <FooterTemplate>
                                                </table>
                                            </FooterTemplate>

                                        </asp:Repeater>
                                    </div>
                                </div>

                                <style>
                                    table, th, td {
                                        border: 1px solid;
                                        justify-content: center;
                                        text-align: center;
                                    }

                                    th {
                                        background-color: lightseagreen;
                                        color: white;
                                    }

                                    .hpanel .panel-body {
                                                background: #f2e7c3;
                                                border: 1px solid #e4e5e7;
                                                border-radius: 2px;
                                                padding: 20px;
                                            }

                                    .button {
                                        background-color: lightseagreen; /* Green */
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
                                        color: lightseagreen;
                                        border: 2px solid lightseagreen;
                                    }

                                        .button2:hover {
                                            background-color: lightseagreen;
                                            color: white;
                                        }

                                    .button2 {
                                        width: 140px;
                                    }

                                    .button2 {
                                        border-radius: 8px;
                                    }
                                </style>


                                <script>
                                    function next(id) {
                                        window.open('Records_of_Lo_Regwhbook_per_items.aspx?id=' + id + '')
                                    }

                                    function nextss(id) {
                                        window.open('LO_Receipt_book.aspx?id=' + id + '')
                                    }
                                </script>

                            </div>

                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
