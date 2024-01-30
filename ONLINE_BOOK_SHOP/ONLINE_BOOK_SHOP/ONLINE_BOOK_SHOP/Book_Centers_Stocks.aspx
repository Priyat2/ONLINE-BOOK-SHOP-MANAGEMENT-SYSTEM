<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Book_Centers_Stocks.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Book_Centers_Stocks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .content2 {
            padding: 10px 40px 25px 40px;
            min-width: 320px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Main Wrapper -->
    <div id="wrapper">

        <div class="content2 animate-panel">
            <h4>All Centers Stock</h4>
            <div class="row">
                <div class="col-lg-12" style="top: -4px; left: 2px">
                    <div class="hpanel">

                        <div class="panel-body">
                            <%-- <h4>All Centers Stock</h4>--%>
                            <br />

                            <div style="font-size: 15px;">
                                <label for="">Select Centers :</label>
                            </div>
                            <div class="form-group form-group-lg-4 form-inline">

                                <span>

                                    <asp:DropDownList runat="server" ID="ddlcenetrs" class="form-control" Style="width: 250px; margin: 0%;">
                                        <asp:ListItem Value="0">--Select Center--</asp:ListItem>
                                        <asp:ListItem Value=""></asp:ListItem>

                                    </asp:DropDownList>

                                    <asp:RequiredFieldValidator InitialValue="0" ID="Req_ID" Display="Dynamic"
                                        runat="server" ControlToValidate="ddlcenetrs"
                                        ErrorMessage="Please Select Center" ValidationGroup="assign" ForeColor="Red"></asp:RequiredFieldValidator>
                                </span>

                                <asp:Button ID="btnupdate" class="button button2" runat="server" Text="Show" ValidationGroup="assign" OnClick="btnupdate_Click" />
                            </div>

                            <br />

                            <div>
                                <link href="~/Styles/style.css" rel="stylesheet" type="text/css" />
                                <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
                                <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
                                <%--<link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
                                   media="screen" />--%>
                                <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/css/bootstrap-datepicker.css" type="text/css" />
                                <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/js/bootstrap-datepicker.js" type="text/javascript"></script>

                                <link rel="stylesheet" href="../media/css/demo_table.css" type="text/css" />
                                <link rel="stylesheet" href="../media/css/demo_table_jui.css" type="text/css" />
                                <link rel="stylesheet" href="../media/jquery-ui-1.8.4.custom.css" type="text/css" />
                                <%--<script type="text/javascript" src="../media/js/jquery.js"></script>--%>
                                <script type="text/javascript" src="../media/js/jquery.dataTables.js"></script>
                                <script type="text/javascript" src="../media/js/jquery.dataTables.min.js"></script>
                                <script type="text/javascript">

                                    $(document).ready(function () {
                                        $('#report').dataTable(
                                            {
                                                "bJQueryUI": true,
                                                "sPaginationType": "full_numbers",
                                                tableTools: {
                                                    "aButtons": [
                                                        "copy",
                                                        "print"
                                                    ],
                                                    "sSwfPath": "../swf/copy_csv_xls_pdf.swf"
                                                }
                                            });
                                    });
                                </script>
                                <div class="card-body" id="divadvanceq">
                                    <div class="table-responsive">
                                        <div id="ImageGallery1" style="overflow: auto;">


                                            <asp:Repeater ID="repeater" runat="server">

                                                <HeaderTemplate>
                                                    <table id="report" cellpadding="0" cellspacing="0" border="0" class="display">
                                                        <thead>
                                                            <tr class="dg_item">
                                                                <th style="width: 20px; text-align: center; vertical-align: middle;">Item Name
                                                                </th>
                                                                <th style="width: 80px; text-align: center; vertical-align: middle;">Available Quantity
                                                                </th>
                                                                <th style="width: 80px; text-align: center; vertical-align: middle;">Waste Quantity
                                                                </th>
                                                                <th style="width: 80px; text-align: center; vertical-align: middle;">Total Quantity
                                                                </th>

                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td style="width: 80px; text-align: center; vertical-align: middle; font-weight: 600;">
                                                            <%# Eval("book_item_name") %>
                                                        </td>

                                                        <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                            <%# Eval("stk_available_qty") %>
                                                        </td>
                                                        <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                            <%# Eval("stk_waste_qty") %>
                                                        </td>
                                                        <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                            <%# Eval("total_qty") %>
                                                        </td>

                                                    </tr>

                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    </tbody>
                                                   </table>
                                                </FooterTemplate>
                                            </asp:Repeater>

                                        </div>


                                    </div>

                                </div>

                            </div>

                        </div>

                        <style>
                            .hpanel .panel-body {
                                background-color: #D4F1F4;
                                border: 1px solid #D4F1F4;
                                border-radius: 2px;
                                padding: 20px;
                            }

                            .button {
                                background-color: red; /* Green */
                                border: none;
                                color: white;
                                padding: 9px 3px;
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
                                color: red;
                                border: 2px solid red;
                            }

                                .button2:hover {
                                    background-color: red;
                                    color: white;
                                }

                            .button2 {
                                width: 120px;
                            }

                            .button2 {
                                border-radius: 8px;
                            }

                            element.style {
                                width: 191px;
                                margin: 0%;
                            }
                        </style>
                    </div>
                </div>
            </div>
        </div>

    </div>



    <!-- Main Wrapper End-->
</asp:Content>
