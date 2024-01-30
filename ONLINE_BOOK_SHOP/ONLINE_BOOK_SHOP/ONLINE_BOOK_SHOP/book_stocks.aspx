<%@ Page Title="Book Stock" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="book_stocks.aspx.cs" Inherits="ONLINE_BOOK_SHOP.book_stocks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
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

        <div class="content animate-panel">
            <div class="row">
                <div class="col-lg-12" style="">
                    <div class="hpanel">
                        <div class="panel-heading">
                            <%--<div class="panel-tools headfont">
                            </div>--%>
                            <h4 style="color:grey;">Book Stock</h4>
                        
                        </div>

                        <div class="panel-body">

                            <div>
                                <asp:Repeater ID="repeater" runat="server">
                                    <HeaderTemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col">Book Item Name</th>
                                                <%--<th scope="col">Description</th>--%>
                                                <th scope="col">Available Quantity</th>
                                                <th scope="col">Waste Quantity</th>
                                                <th scope="col">Total Quantity</th>
                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# DataBinder.Eval(Container, "DataItem.book_item_name")%></td>
                                           <%-- <td><%# DataBinder.Eval(Container, "DataItem.stk_desc")%></td>--%>
                                            <td><%# DataBinder.Eval(Container, "DataItem.stk_available_qty")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.stk_waste_qty")%></td>
                                             <td><%# DataBinder.Eval(Container, "DataItem.total_qty")%></td>

                             
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </table>
                                    </FooterTemplate>

                                </asp:Repeater>
                                <style>
                                    table, th, td {
                                        border: 1px solid;
                                        justify-content: center;
                                        text-align: center;
                                    }

                                    th {
                                        background-color: #99C221;
                                        color: white;
                                    }

                                    td{
                                        background-color:#F2E7C3;
                                    }
                                </style>
                                <style>
                                    .hpanel .panel-body {
                                        background-color:#F2E7C3;
                                        border: 1px solid #F2E7C3;
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
