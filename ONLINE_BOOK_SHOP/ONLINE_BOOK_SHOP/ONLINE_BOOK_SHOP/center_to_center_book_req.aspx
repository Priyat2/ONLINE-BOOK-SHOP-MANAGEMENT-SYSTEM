<%@ Page Title="Book Center- Pending Request" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="center_to_center_book_req.aspx.cs" Inherits="ONLINE_BOOK_SHOP.center_to_center_book_req" %>

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
                            <h4 style="color:grey;">Book Requests From Centers</h4>
                            

                            <%--<span class="form-group form-group-lg-4 form-inline pull-right">
                                        <asp:Button ID="btndash" CssClass="btn" runat="server" Style="background-color:#C39BD3; color:white;" Text="Show Reports" OnClick="btndash_Click" />
                                    </span>--%>
                            <asp:HiddenField ID="getid" runat="server" />
                            <div>
                                <asp:Repeater ID="Repeater" runat="server" OnItemCommand="Repeater_ItemCommand" OnItemDataBound="OnItemDataBound">
                                    <HeaderTemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col">ID</th>
                                                <th scope="col">Center Name</th>
                                                <th scope="col">Order Date</th>
                                                <th scope="col">Total Quantity</th>
                                                <th scope="col">Total Price</th>
                                                <th scope="col">Send Request</th>
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

                                            <td>
                                                <asp:DropDownList runat="server" ID="ddlcenters" class="form-control">
                                                    <asp:ListItem Value="0">-Select Centers-</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>

                                            <td>
                                                <asp:Button ID="btnaccept" runat="server" Text="Approve" CssClass="btn btn-warning btn-sm" CommandArgument='<%# Eval("pk_order_to_book_id") %>' CommandName="approve" />
                                                |
                                                <asp:Button ID="btnreject" runat="server" Text="Reject" CssClass="btn btn-danger btn-sm" CommandArgument='<%# Eval("pk_order_to_book_id") %>' CommandName="reject" />

                                            </td>


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

                                <script>
                                    function next(id) {
                                        window.open('Complete_req_for_book_center.aspx?id=' + id + '')
                                    }
                                </script>
                            </div>

                            <style>
                                .hpanel .panel-body {
                                    background-color: #F2E7C3;
                                    border: 1px solid #F2E7C3;
                                    border-radius: 2px;
                                    padding: 20px;
                                }

                              /*  hr {
                                    margin-top: 20px;
                                    margin-bottom: 20px;
                                    border: 0;
                                    background-color: red;
                                    border-top: 1px solid red;
                                }*/
                            </style>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--end main wrappper-->


</asp:Content>

