<%@ Page Title="" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Req_from_center_bookwh_order.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Req_from_center_bookwh_order" %>
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
                      <h4>Pending Orders From Warehouse</h4>

                        <div class="panel-body">
                             
                          
                            <asp:HiddenField ID="getid" runat="server" />
                            <div>
                                <asp:Repeater ID="repeater" runat="server">
                                    <HeaderTemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th style="display: none;">Order ID</th> 
                                                <th scope="col">Warehouse Name</th>
                                                <th scope="col">Order Date</th>
                                                <th scope="col">Total Price</th>
                                                <th scope="col">Total Quantity</th>
                                                <th scope="col">Order For</th>
                                               <%-- <th scope="col">Order By</th>--%>
                                                <th scope="col">Action</th>

                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                         <tr id="rept" class="dg_alt_item">
                                                <td style="display: none;">
                                                    <asp:Label ID="orderid" runat="server" Text='<%# Eval("pk_order_to_book_id") %>' />
                                                </td>
                                                <td>
                                                    <%# Eval("center_name") %>
                                                </td>

                                                <td>
                                                   <%# Eval("otw_order_dt") %>
                                                </td>

                                                 <td>
                                                    <asp:Label ID="lblprice" runat="server" Text='<%# Eval("otw_price") %>'></asp:Label>
                                                </td>

                                                <td>
                                                    <asp:label ID="txtquantity1" runat="server" Text='<%# Eval("otw_qty") %>' TextMode="Number"></asp:label>
                                                </td>
                                               
                                                
                                                 <td>
                                                   <%# Eval("order_type") %>
                                                </td>  
                                                
                                                <%-- <td>
                                                   <%# Eval("user_name") %>
                                                </td>  --%>

                                                <td>
                                                   <asp:LinkButton ID="btnid" runat="server" OnClientClick='<%# "return view(" + Eval("pk_order_to_book_id") + ");" %>' Text='<img src="images/view.png" style="width: 30px; height: 30px;">'></asp:LinkButton>

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
                                        background-color: lightseagreen ;
                                        color: white;
                                    }
                                </style>

                              
                            </div>
                          
                             <style>
                            .hpanel .panel-body {
                                background: #f2e7c3;
                                border: 1px solid #f2e7c3;
                                border-radius: 2px;
                                padding: 20px;
                            }
                        </style>
                        </div>
                    </div>
                </div>
            </div>
            <script>
                function view(id) {
                    window.open("Complete_req_from_wh_to_centerwh.aspx?orderid=" + id, "_blank");
                    return false; // prevent postback
                }
            </script>

        </div>
    </div>
    <!--end main wrappper-->
    
     
</asp:Content>
