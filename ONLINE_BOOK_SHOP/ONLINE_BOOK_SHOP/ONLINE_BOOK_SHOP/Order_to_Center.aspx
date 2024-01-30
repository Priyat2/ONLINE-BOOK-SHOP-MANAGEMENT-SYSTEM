<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Order_to_Center.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Order_to_Center" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <main id="main" class="main">

        <section class="section">
            

            <div class="row">
                <div class="col-lg-12">
                    <h5 class="card-title">Order list from center</h5>
                    <div class="card">
                        <div class="card-body">

                            <div class="row g-3">
                                <table class="table table-striped table-bordered table-hover">
                                    <asp:Repeater ID="repeater1" runat="server">
                                        <HeaderTemplate>
                                            <tr class="dg_item">
                                                <th style="display: none;">ID </th>
                                              
                                                <th>Quantity</th>
                                                <th>Total Price </th>
                                                <th>Order Date </th>
                                                <th>C/O Approval</th>
                                              
                                                <th>View</th>
                                              

                                            </tr>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <tr id="rept" class="dg_alt_item">
                                                <td style="display: ">
                                                    <asp:Label ID="orderid" runat="server" Text='<%# Eval("pk_order_to_book_id") %>' />
                                                </td>
                                               
                                                <td>
                                                    <asp:label ID="txtquantity1" runat="server" Text='<%# Eval("otw_qty") %>' TextMode="Number"></asp:label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblprice" runat="server" Text='<%# Eval("otw_price") %>'></asp:Label>
                                                </td>
                                                <td>
                                                   <%# Eval("otw_order_dt") %>
                                                </td>
                                                 <td style="color:<%# Eval("approval_indicator") %>;">
                                                   <%# Eval("approval_status") %>
                                                </td>
                                                
                                                <td>
                                                    <input type="button" id="btnview" class="btn btn-outline-dark" value="View Items" onclick="view('<%# Eval("pk_order_to_book_id") %>')" />
                                                </td>

                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </table>
                            </div>
                        </div>

                    </div>

                </div>
            </div>

        </section>
    </main>
   <%-- <script>
        function view(id) {
          
            window.open("send_item_center.aspx?orderid=" + id + "");
        }
    </script>--%>
</asp:Content>
