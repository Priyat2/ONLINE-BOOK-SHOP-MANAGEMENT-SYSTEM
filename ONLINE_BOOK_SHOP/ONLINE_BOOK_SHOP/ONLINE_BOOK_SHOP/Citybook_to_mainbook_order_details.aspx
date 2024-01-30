<%@ Page Title="Book- Order List" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Citybook_to_mainbook_order_details.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Citybook_to_mainbook_order_details" %>
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
                            <h4>List of Purchase Orders From Center</h4>
                            <div class="panel-body">

                                <%--<span class="form-group form-group-lg-4 form-inline pull-right">
                                        <asp:Button ID="btndash" CssClass="btn" runat="server" Style="background-color:#C39BD3; color:white;" Text="Show Reports" OnClick="btndash_Click" />
                                    </span>--%>
                                
                                <asp:HiddenField ID="getid" runat="server" />
                                <div style="padding-top:5px;">
                                    <asp:Repeater  ID="Repeater" runat="server">
                                        <headertemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col">ID</th>
                                                <th scope="col">Book Center Name</th>
                                               
                                                <th scope="col">Order Date</th>
                                                <th scope="col">Total Quantity</th>
                                                <th scope="col">Total Price</th>
                                               <th scope="col">Order By</th>
                                               <th scope="col">Status</th>
                                               <%-- <th scope="col">Confirm By</th>--%>
                                                <th scope="col">Action</th>

                                            </tr>
                                    </headertemplate>
                                        <itemtemplate>
                                        <tr>
                                             <td ><%# DataBinder.Eval(Container, "DataItem.pk_order_to_book_id")%></td>
                                           
                                            <td><%# DataBinder.Eval(Container, "DataItem.center_name")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_order_dt")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_qty")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_price")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.user_name")%></td>
                                           <td> <span Style="color:<%# Eval("color") %>;"><%# Eval("status")%></span>  </td>
                                               <%--<td><%# DataBinder.Eval(Container, "DataItem.confm")%></td>--%>
                                            
                                            <td><asp:LinkButton ID="btnrec" runat="server" OnClientClick='<%# "next(" + Eval("pk_order_to_book_id") + "); return false;" %>' Style='<%# "visibility:" + Eval("flag") + "; color: blue;" %>'  Text="Receive Item"></asp:LinkButton> | 
                                                <asp:LinkButton ID="btnview" runat="server" OnClientClick='<%# "nexts(" + Eval("pk_order_to_book_id") + "); " %>' style="color:blue;" Text="View Items"></asp:LinkButton> 
                                                </td>

                                        </tr>
                                    </itemtemplate>
                                        <footertemplate>
                                        </table>
                                    </footertemplate>

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
                                    </style>

                                        <script>
                                            function next(id) {
                                                window.open('citybook_to_mainbook_receive_item.aspx?id=' + id + '')
                                            }

                                            function nexts(id) {
                                                window.open('view_rec_bookwh_to_citybookwh_by_item.aspx?id=' + id + '')
                                            }
                                        </script>
                                        </div>
                          
                                 <style>
                            .hpanel .panel-body {
                                background: #F2E7C3;
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
    <!--end main wrappper-->

</asp:Content>

