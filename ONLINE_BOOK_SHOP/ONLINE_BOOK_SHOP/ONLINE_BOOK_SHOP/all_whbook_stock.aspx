<%@ Page Title="Report- Book Center Stock" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="all_whbook_stock.aspx.cs" Inherits="ONLINE_BOOK_SHOP.all_whbook_stock" %>

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
            <div class="row">
                <div class="col-lg-12" style="top: -4px; left: 2px">
                    <div class="hpanel">
                        <h4>All Center Stock</h4>
                        <div class="panel-body">


                            <%--<div class="form-group form-group-lg-4 form-inline pull-right">

                                <asp:TextBox ID="txtSearch" runat="server" placeholder=" Search Here " class="form-control"> </asp:TextBox>

                                    <asp:Button ID="BtnSearch" CssClass="btn btn-info" runat="server" Text="search" OnClick="BtnSearch_Click"  />
                                   
                            </div>--%>

                            <div>
                                <label for="">Select Center : <span style="color: red;">*</span></label></div>
                            <div class="form-group form-group-lg-4 form-inline">

                                <span>

                                    <asp:DropDownList runat="server" ID="ddlcenter" class="form-control" Style="width: 200px; margin: 0%;">
                                        <asp:ListItem Value="0">Select Center</asp:ListItem>


                                    </asp:DropDownList>

                                    <asp:RequiredFieldValidator InitialValue="0" ID="Req_ID" Display="Dynamic"
                                        runat="server" ControlToValidate="ddlcenter"
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
                                                                <th style="width: 20px; text-align: center; vertical-align: middle;">Book Item Name
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
                                background: #519f5366;
                                border: 1px solid #519f5366;
                                border-radius: 2px;
                                padding: 20px;
                            }

                            .button {
                                background-color: #dc241b; /* Green */
                                border: none;
                                color: white;
                                padding: 8px 4px;
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
                                color: #dc241b;
                                border: 2px solid #dc241b;
                            }

                                .button2:hover {
                                    background-color: #dc241b;
                                    color: white;
                                }

                            .button2 {
                                width: 129px;
                            }

                            .button2 {
                                border-radius: 16px;
                            }
                        </style>
                    </div>
                </div>
            </div>
        </div>

    </div>



    <!-- Main Wrapper End-->
</asp:Content>
