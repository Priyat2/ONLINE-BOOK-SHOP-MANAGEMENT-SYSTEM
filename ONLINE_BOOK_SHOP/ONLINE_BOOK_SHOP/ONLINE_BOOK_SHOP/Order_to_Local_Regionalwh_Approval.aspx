<%@ Page Title="Local- Order List" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Order_to_Local_Regionalwh_Approval.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Order_to_Local_Regionalwh_Approval" %>
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
                                
                               
                                <%-- <span >
                                <asp:Button ID="bntrecord" CssClass="btn" Style="background-color:#C39BD3; color:white;" runat="server" Text="Show Reports" OnClick="bntrecord_Click"   />
                            </span>--%>

                                <span class="form-group form-group-lg-4 form-inline pull-right">
                                    <asp:Button ID="btndash" CssClass="btn btn-warning " runat="server" Text="Dashboard" OnClick="btndash_Click" />
                                </span>
                                <h4>List of Purchase Orders From Local</h4>
                                <div>
                                    <asp:Repeater ID="Repeater" runat="server">
                                        <headertemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col">P.O.No.</th>
                                                 <th>Warehouse</th>
                                                 <th>Local shop</th>

                                                <th scope="col">Order Date</th>
                                                <th scope="col">Total Quantity</th>
                                                <th scope="col">Total Price</th>
                                             
                                                 <th scope="col">Action</th>
                                                

                                            </tr>
                                    </headertemplate>
                                        <itemtemplate>
                                        <tr>
                                            <td ><%# DataBinder.Eval(Container, "DataItem.pk_lo_id")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.center_name")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.trlo_local_shop")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.lo_order_dt")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.lo_item_qty")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.lo_item_price")%></td>
                                       


                                            
                                            <td><asp:LinkButton id="btnid" runat="server" OnClientClick='<%#"next(" + Eval("pk_lo_id") + "); " %>' style="color:blue;" Text="Receive Items"></asp:LinkButton> | 
                                                <asp:LinkButton id="btnview"  runat="server" OnClientClick='<%#"nexts(" + Eval("pk_lo_id") + "); " %>' style="color:blue;" Text="View Items"></asp:LinkButton> |
                                                <asp:LinkButton id="bntpdf" runat="server" OnClientClick='<%#"nextss(" + Eval("pk_lo_id") + "); " %>' style="color:blue;" Text='<img src="images/print.png">' ></asp:LinkButton>
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
                                            background-color: lightseagreen;
                                            color: white;
                                        }
                                    </style>

                                    <script>
                                        function next(id) {
                                            window.open('View_Local_order_Regionalwh.aspx?id=' + id + '')
                                        }

                                        function nexts(id) {
                                            window.open('Records_of_Lo_Regwh_per_Items.aspx?id=' + id + '')
                                        }

                                        function nextss(id) {
                                            window.open('LO_Receipt.aspx?id=' + id + '')
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
