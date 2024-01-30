<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="book_items_rp_ms.aspx.cs" Inherits="ONLINE_BOOK_SHOP.book_items_rp_ms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .content2 {
            padding: 10px 40px 25px 40px;
            min-width: 320px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<script src="vendor/jquery/dist/jquery.min.js"></script>
    <script src="vendor/bootstrap/dist/js/bootstrap.min.js"></script>--%>
    <!-- Main Wrapper -->
    <div id="wrapper">
        <div class="content2 animate-panel">
            <div class="row">
                <div class="col-lg-12" style="">
                    <div class="hpanel">
                         <h4>Details of Items</h4>
                        <div class="panel-body">
                           
                           
                             <div>
                                <%--<div class="form-group form-group-lg-4 form-inline pull-right">

                                    <asp:TextBox ID="txtSearch" runat="server" placeholder=" Search Here " class="form-control"> </asp:TextBox>

                                    <asp:Button ID="BtnSearch" CssClass="btn btn-info" runat="server" Text="search" OnClick="BtnSearch_Click" />

                                </div>--%>

                                <asp:Button ID="btnsubmit" class="button button2" Text="Add New" runat="server" OnClick="btnsubmit_Click1" />


                            </div>
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


                                            <asp:Repeater ID="repeater" runat="server">

                                                <HeaderTemplate>
                                                    <table id="report" cellpadding="0" cellspacing="0" border="0" class="display">
                                                        <thead>
                                                            <tr class="dg_item">
                                                                <th style="width: 20px; text-align: center; vertical-align: middle;">ID
                                                                </th>
                                                                <th style="width: 80px; text-align: center; vertical-align: middle;">Book Item Name
                                                                </th>
                                                                <th style="width: 80px; text-align: center; vertical-align: middle;">Item Code
                                                                </th>
                                                                <th style="width: 80px; text-align: center; vertical-align: middle;">Purchase Cost
                                                                </th>
                                                                <th style="width: 80px; text-align: center; vertical-align: middle;">IGST(%)
                                                                </th>
                                                                <th style="width: 80px; text-align: center; vertical-align: middle;">CGST(%)
                                                                </th>
                                                                <th style="width: 80px; text-align: center; vertical-align: middle;">SGST(%)
                                                                </th>

                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td style="width: 80px; text-align: center; vertical-align: middle; font-weight: 600;">
                                                           <button id="btnid" onclick='next(<%# Eval("pk_book_item_id") %>)'><%# Eval("pk_book_item_id") %></button>
                                                        </td>
                                                        <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                            <%# Eval("book_item_name") %>
                                                        </td>
                                                        <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                            <%# Eval("item_code") %>
                                                        </td>
                                                        <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                            <%# Eval("item_purchase_cost") %>
                                                        </td>
                                                        <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                            <%# Eval("IGST") %>
                                                        </td>
                                                        <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                            <%# Eval("CGST") %>
                                                        </td>
                                                        <td style="width: 80px; text-align: center; vertical-align: middle;">
                                                            <%# Eval("SGST") %>
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

                            <script>
                            function next(id) {
                                window.open('book_itemss_ms.aspx?id=' + id + '')
                            }
                            </script>
                           

                          <%-- <div>
                                <asp:Repeater ID="Repeat" runat="server">
                                    <HeaderTemplate>

                                        <table cellpadding="2" cellspacing="1" class="table table-hover">

                                            <thead>
                                                <tr>
                                                    <th scope="col">ID</th>
                                                    <th scope="col">Item Name</th>--%>
                                                  <%--  <th scope="col">Category</th>
                                                    <th scope="col">Item Type</th>--%>
                                                    <%--<th scope="col">Item Code</th>--%>
                                                    <%--<th scope="col">Unit</th>--%>
                                                   <%-- <th scope="col">Sale Cost</th>--%>
                                                    <%--<th scope="col">Purchase Cost</th>
                                                    <th scope="col">IGST(%)</th>
                                                    <th scope="col">CGST(%)</th>
                                                    <th scope="col">SGST(%)</th>--%>
                                                   
                                              <%--  </tr>
                                            </thead>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tbody>
                                            <tr>
                                                <td scope="row">
                                                    <button id="btnid" onclick='next(<%# Eval("pk_item_id") %>)'><%# Eval("pk_item_id") %></button>
                                                </td>--%>
                                               <%-- <td><%# DataBinder.Eval(Container, "DataItem.item_name")%></td>--%>
                                             <%--   <td><%# DataBinder.Eval(Container, "DataItem.item_icat_name")%></td>
                                                <td><%# DataBinder.Eval(Container, "DataItem.item_itype_name")%></td>--%>
                                                <%--<td><%# DataBinder.Eval(Container, "DataItem.item_code")%></td>--%>
                                               <%-- <td><%# DataBinder.Eval(Container, "DataItem.item_unit_name")%></td>
                                                <td><%# DataBinder.Eval(Container, "DataItem.item_sale_cost")%></td>--%>
                                     <%--           <%--<td><%# DataBinder.Eval(Container, "DataItem.item_purchase_cost")%></td>
                                                <td><%# DataBinder.Eval(Container, "DataItem.IGST")%></td>
                                                <td><%# DataBinder.Eval(Container, "DataItem.CGST")%></td>
                                                <td><%# DataBinder.Eval(Container, "DataItem.SGST")%></td>
                                              
                                            </tr>
                                        </tbody>

                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </table>
                                    </FooterTemplate>

                                </asp:Repeater>
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
                            </style>
                        </div>

                        <script>
                            function next(id) {
                                window.open('itemss_masterpage.aspx?id=' + id + '')
                            }
                        </script>--%>

                    </div>
                </div>
                      <style>
                               .hpanel .panel-body {
                                background: #D4F4C7;
                                border: 1px solid #e4e5e7;
                                border-radius: 2px;
                                padding: 20px;
                            }

                               .button {
                                    background-color: #FE5000; /* Green */
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
                                    color: #FE5000;
                                    border: 2px solid #FE5000;
                                }

                                    .button2:hover {
                                        background-color: #FE5000;
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
    </div>
        </div>

    <!--end main wrappper-->

</asp:Content>

