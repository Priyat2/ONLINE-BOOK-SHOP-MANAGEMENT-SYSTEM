<%@ Page Title="Supplier- Supplier vs Item" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Show_Splr_vs_book_item.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Show_Splr_vs_book_item" %>

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
                <div class="col-lg-12" style="top: -4px; left: 2px">
                    <div class="hpanel">
                        <h4>Details of Suppliers With Items</h4>
                        <div class="panel-body">

                            <br />
                            <div class="form-group form-group-lg-4 form-inline pull-right" style="color: darkslategrey;">


                                <label for="">SELECT SUPPLIER:</label>
                                <div>

                                    <asp:DropDownList runat="server" ID="ddlsuplier" class="form-control">
                                        <asp:ListItem Value="0">--Select Supplier--</asp:ListItem>
                                    </asp:DropDownList>

                                    <asp:RequiredFieldValidator InitialValue="0" ID="Req_ID" Display="Dynamic"
                                        runat="server" ControlToValidate="ddlsuplier"
                                        ErrorMessage="Please Select Supplier" ValidationGroup="assign" ForeColor="Red"></asp:RequiredFieldValidator>


                                    <asp:Button ID="btnupdate" class="button1 button3" runat="server" Text="Show" ValidationGroup="assign" OnClick="btnupdate_Click" />
                                </div>
                            </div>
                            <div>
                                <asp:Button ID="btnsubmit" class="button button2" runat="server" Text="Add New" OnClick="btnsubmit_Click" />

                            </div>

                            <br />

                            <div>
                                <asp:Repeater ID="Repeater" runat="server">
                                    <HeaderTemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col">ID</th>

                                                <th scope="col">Item</th>


                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td scope="row">
                                                <button id="btnid" onclick='next(<%# Eval("pk_splr_item_id") %>)'><%# Eval("pk_splr_item_id") %></button>
                                            </td>

                                            <td><%# DataBinder.Eval(Container, "DataItem.book_item_name")%></td>


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
                                        color: darkslategrey;
                                         border: 1px solid;
                                    }
                                </style>
                            </div>
                            <script>
                                function next(id) {
                                    window.open('splr_vs_book_items.aspx?id=' + id + '')
                                }
                            </script>
                        </div>
                        <style>
                            .hpanel .panel-body {
                                background: #a2b0ca;
                                border: 1px solid #f2e7c3;
                                border-radius: 2px;
                                padding: 20px;
                            }

                            .button {
                                background-color: #99C221; /* Green */
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
                                color: #99C221;
                                border: 2px solid #99C221;
                            }

                                .button2:hover {
                                    background-color: #99C221;
                                    color: white;
                                }

                            .button2 {
                                width: 100px;
                            }

                            .button2 {
                                border-radius: 8px;
                            }

                            .button1 {
                                background-color: #F62217;
                                border: none;
                                color: white;
                                padding: 7px 4px;
                                text-align: center;
                                text-decoration: none;
                                display: inline-block;
                                font-size: 16px;
                                margin: 4px 2px;
                                transition-duration: 0.4s;
                                cursor: pointer;
                            }

                            .button3 {
                                background-color: white;
                                color: #F62217;
                                border: 2px solid #F62217;
                            }

                                .button3:hover {
                                    background-color: #F62217;
                                    color: white;
                                }

                            .button3 {
                                width: 109px;
                            }

                            .button3 {
                                border-radius: 8px;
                            }
                        </style>

                    </div>
                </div>
            </div>
        </div>

    </div>



    <!-- Main Wrapper End-->
</asp:Content>
