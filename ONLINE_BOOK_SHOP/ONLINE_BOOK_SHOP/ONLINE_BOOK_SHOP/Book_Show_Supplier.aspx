<%@ Page Title="Supplier- Suppliers List" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Book_Show_Supplier.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Book_Show_Supplier" %>

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
                        <h4>Details of Suppliers</h4>

                        <div class="panel-body">

                            <div>
                                <asp:Button ID="btnsubmit" class="button button2" runat="server" Text="Add New" OnClick="btnsubmit_Click" />
                            </div>

                            <%--<div class="form-group form-group-lg-4 form-inline pull-right">

                                <asp:TextBox ID="txtinput" runat="server" placeholder="Enter Here" class="form-control me-2"></asp:TextBox>
                                <asp:Button ID="searchbtn" CssClass="btn btn-info" runat="server" Text="Search" OnClick="searchbtn_Click" />
                            </div>--%>

                            <br />

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


                                        <asp:Repeater ID="Repeater" runat="server">

                                            <HeaderTemplate>
                                                <table id="report" cellpadding="0" cellspacing="0" border="0" class="display">
                                                    <thead>
                                                        <tr class="dg_item">
                                                            <th style="width: 20px; text-align: center; vertical-align: middle;">ID
                                                            </th>
                                                            <th style="width: 80px; text-align: center; vertical-align: middle;">Name
                                                            </th>
                                                            <th style="width: 80px; text-align: center; vertical-align: middle;">Address
                                                            </th>
                                                            <th style="width: 80px; text-align: center; vertical-align: middle;">Contact No.
                                                            </th>
                                                            <th style="width: 80px; text-align: center; vertical-align: middle;">Phone No.
                                                            </th>
                                                            <th style="width: 80px; text-align: center; vertical-align: middle;">Email ID
                                                            </th>
                                                            <th style="width: 80px; text-align: center; vertical-align: middle;">GST No.
                                                            </th>


                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td style="width: 80px; text-align: center; vertical-align: middle; font-weight: 600;">
                                                        <button id="btnid" onclick='next(<%# Eval("pk_splr_id") %>)'><%# Eval("pk_splr_id") %></button>
                                                    </td>
                                                    <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                        <%# Eval("splr_name") %>
                                                    </td>
                                                    <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                        <%# Eval("splr_address") %>
                                                    </td>
                                                    <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                        <%# Eval("splr_contact") %>
                                                    </td>
                                                    <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                        <%# Eval("splr_phone") %>
                                                    </td>
                                                    <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                        <%# Eval("splr_email") %>
                                                    </td>
                                                    <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                        <%# Eval("splr_gst_no") %>
                                                    </td>

                                                </tr>

                                            </ItemTemplate>
                                            <FooterTemplate>
                                                </tbody>
                                                   </table>
                                            </FooterTemplate>
                                        </asp:Repeater>

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
                                    </style>
                                </div>

                            </div>


                            <div>

                                <script>
                                    function next(id) {
                                        window.open('Book_Supplier.aspx?id=' + id + '')
                                    }
                                </script>


                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--end main wrappper-->
</asp:Content>

