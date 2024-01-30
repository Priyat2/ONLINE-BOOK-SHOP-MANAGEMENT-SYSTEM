<%@ Page Title="Book Center- Pending Order" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="book_Req_from_Center.aspx.cs" Inherits="ONLINE_BOOK_SHOP.book_Req_from_Center" %>

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

        <div class="content2 animate-panel">
            <div class="row">
                <div class="col-lg-12" style="">
                    <div class="hpanel">
                       
                        <div class="panel-body">
                             <h4>Pending Orders From Book Centers</h4>
                        

                            <%--<span class="form-group form-group-lg-4 form-inline pull-right">
                                        <asp:Button ID="btndash" CssClass="btn" runat="server" Style="background-color:#C39BD3; color:white;" Text="Show Reports" OnClick="btndash_Click" />
                                    </span>--%>
                            <asp:HiddenField ID="getid" runat="server" />
                            <div>
                                <asp:Repeater ID="Repeater" runat="server">
                                    <HeaderTemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col">ID</th>
                                                <th scope="col">Center Name</th>

                                                <th scope="col">Order Date</th>
                                                <th scope="col">Total Quantity</th>
                                                <th scope="col">Total Price</th>


                                                <th scope="col">Action</th>

                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <asp:Label runat="server" Text='<%# Eval("pk_order_to_book_id") %>' ID="lblcheck"></asp:Label></td>

                                            <td><%# DataBinder.Eval(Container, "DataItem.center_name")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_order_dt")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_qty")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_price")%></td>

                                           <%-- <td>
                                                <asp:LinkButton ID="btntransfer" runat="server" OnClick="transfer" Style="color: blue;" Text="Transfer"></asp:LinkButton>
                                                |
                                                <asp:LinkButton ID="btnid" runat="server" OnClientClick='<%# "next(" + Eval("pk_order_to_book_id") + "); " %>' Style="color: blue;" Text="View Items"></asp:LinkButton>
                                            </td>--%>

                                             <td><button id="btnid" onclick='next(<%# Eval("pk_order_to_book_id") %>)' class="btn btn-info">View Items</button></td>

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
                                        background-color: lightseagreen;
                                        color: white;
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

                                <script>
                                    function next(id) {
                                        window.open('Complete_req_for_book_center.aspx?id=' + id + '')
                                    }
                                </script>
                            </div>


                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--end main wrappper-->
</asp:Content>
