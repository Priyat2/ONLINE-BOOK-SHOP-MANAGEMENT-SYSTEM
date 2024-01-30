<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Book_purchase_order_rp.aspx.cs" Inherits="Warehouse.Book_purchase_order_rp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
        <div class="hpanel" id="hidepanel" runat="server" visible="false">
            <h4>Order Product list</h4>

            <div class="panel-body">
                <div class="row">
                    <div class="col-lg-12">


                        <div class="card">
                            <div class="card-body">

                                <div class="row g-3">

                                    <table class="table table-striped table-bordered table-hover">
                                        <asp:Repeater ID="repeater1" runat="server" OnItemDataBound="OnItemDataBound">
                                            <HeaderTemplate>

                                                <tr class="dg_item">
                                                    <th style="display: none;">ID </th>
                                                    <th style="display: none;">Warehouse ID </th>
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
                                                    <td style="display: none">
                                                        <asp:Label ID="orderid" runat="server" Text='<%# Eval("pk_trpo_id") %>' />
                                                    </td>

                                                    <td style="display: none">
                                                        <asp:Label ID="lblwh" runat="server" Text='<%# Eval("trpo_wh_id") %>' />
                                                    </td>

                                                    <td style="display: none">
                                                        <asp:Label ID="lblsplr" runat="server" Text='<%# Eval("trpo_splr_id") %>' />
                                                    </td>

                                                    <td style="display: none">
                                                        <asp:Label ID="lbldesc" runat="server" Text='<%# Eval("trpo_desc") %>' />
                                                    </td>

                                                    <td style="text-align: center;"><%# Eval("book_item_name") %> </td>

                                                    <td style="text-align: center;">
                                                        <asp:TextBox ID="txtquantity1" runat="server" Text='<%# Eval("trpo_item_qty") %>' ClientIDMode="Static"></asp:TextBox>

                                                    </td>

                                                    <asp:HiddenField ID="hdstatus" runat="server" Value='<%# Eval("trpo_tax_percent") %>' />
                                                    <td style="text-align: center;">
                                                        <asp:DropDownList runat="server" ID="ddlgstre" class="form-control">
                                                            <asp:ListItem Value="10">10</asp:ListItem>
                                                            <asp:ListItem Value="12">12</asp:ListItem>
                                                            <asp:ListItem Value="18">18</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>

                                                    <td style="text-align: center;">
                                                        <asp:TextBox ID="txtdiscount" runat="server" Text='<%# Eval("trpo_discount_percent") %>'></asp:TextBox>
                                                    </td>

                                                    <td style="text-align: center;">
                                                        <asp:Label ID="lblprice" runat="server" Text='<%# Eval("trpo_item_price") %>'></asp:Label>
                                                    </td>

                                                    <td style="text-align: center;">
                                                        <asp:Label ID="lblfinalprice" runat="server" Text='<%# Eval("final_price") %>'></asp:Label>
                                                    </td>

                                                    <td style="text-align: center;">
                                                        <asp:LinkButton ID="lnkDelete" Text="Delete" CssClass="btn btn-danger" runat="server" OnClientClick="return confirm('Do you want to delete this Order?');"
                                                            OnClick="DeleteCustomer" />
                                                    </td>

                                                </tr>
                                            </ItemTemplate>

                                        </asp:Repeater>
                                    </table>
                                    <div>
                                        <asp:Button ID="btnUpdateCart" Text="Update Order" CssClass="btn" Style="background-color: #FF7F50; color: white;"
                                            ValidationGroup="02" runat="server" OnClick="btnUpdateCart_Click" />
                                        <span class="form-group form-group-lg-4 form-inline pull-right">
                                            <asp:Button ID="btnplace" CssClass="btn btn-warning " runat="server" Text="Place Order" OnClick="btnplace_Click" Width="143px" />

                                        </span>
                                    </div>


                                </div>



                            </div>

                        </div>
                    </div>

                </div>
            </div>
        </div>
        </div>
</asp:Content>
