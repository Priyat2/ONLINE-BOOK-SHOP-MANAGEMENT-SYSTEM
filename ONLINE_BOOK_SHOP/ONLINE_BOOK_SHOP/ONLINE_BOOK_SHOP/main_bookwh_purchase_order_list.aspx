<%@ Page Title="Supplier- Order List" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="main_bookwh_purchase_order_list.aspx.cs" Inherits="ONLINE_BOOK_SHOP.main_bookwh_purchase_order_list" %>
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
                        <h4>List of Purchase Orders From Supplier</h4>
                        <div class="panel-body">
                             <%-- <span >
                                <asp:Button ID="bntrecord" CssClass="btn" Style="background-color:#C39BD3; color:white;" runat="server" Text="Show Reports" OnClick="bntrecord_Click"   />
                            </span>--%>

                            <%-- <span class="form-group form-group-lg-4 form-inline pull-right">
                                <asp:Button ID="btndash" class="button button2" runat="server" Text="Dashboard" OnClick="btndash_Click"  />
                            </span>--%>
                             <asp:HiddenField ID="getid" runat="server" />
                            <div>
                                <asp:Repeater ID="Repeater" runat="server">
                                    <HeaderTemplate>
                                        <table cellpadding="1" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col">P.O.No.</th>
                                                 <th scope="col">PO Code</th>
                                                <th scope="col">Center</th>
                                                <th scope="col">Supplier</th>
                                                <th scope="col">Order Date</th>
                                                <th scope="col">Total Quantity</th>
                                                <th scope="col">Total Price</th>
                                               <th scope="col">Order By</th>
                                                <th scope="col">Action</th>
                                                

                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td ><%# DataBinder.Eval(Container, "DataItem.pk_po_id")%></td>
                                            <td ><%# DataBinder.Eval(Container, "DataItem.po_code")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.center_name")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.splr_name")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.po_order_dt")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.po_item_qty")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.po_item_price")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.user_name")%></td>
                                          <td>  <asp:LinkButton ID="btnid" runat="server" OnClientClick='<%# "next(" + Eval("pk_po_id") + "); " %>' style="color:blue;" Text="Receive Items"></asp:LinkButton> |
                                              <asp:LinkButton ID="btnview" runat="server" OnClientClick='<%# "nexts(" + Eval("pk_po_id") + "); " %>' style="color:blue;" Text="View Items"></asp:LinkButton> |
                                               <asp:LinkButton ID="bntpdf" runat="server" OnClientClick='<%# "nextss(" + Eval("pk_po_id") + "); " %>' style="color:blue;" Text='<img src="images/print.png">'></asp:LinkButton> 
  
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
                                    window.open('main_bookwh_po_item_receive.aspx?id=' + id + '')
                                }

                                function nexts(id) {
                                    window.open('All_po_for_main_bookwh_by_item.aspx?id=' + id + '')
                                }
                                function nextss(id) {
                                    window.open('Book_Po_Generate_Receipt.aspx?id=' + id + '')
                                }
                                
                            </script>
                            </div>
                             <style>
                            .hpanel .panel-body {
                                background: #f2e7c3;
                                border: 1px solid #e4e5e7;
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
                                    width: 140px;
                                }

                                .button2 {
                                    border-radius: 8px;
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
