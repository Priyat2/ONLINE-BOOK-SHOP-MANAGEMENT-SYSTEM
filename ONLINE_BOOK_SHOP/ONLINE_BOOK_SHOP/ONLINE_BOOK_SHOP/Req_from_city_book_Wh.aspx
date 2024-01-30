<%@ Page Title="Center- Pending Order" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Req_from_city_book_Wh.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Req_from_city_book_Wh" %>
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
                      <h4>Pending Orders From Centers</h4>

                        <div class="panel-body">
                             
                          
                            <asp:HiddenField ID="getid" runat="server" />
                            <div>
                                <asp:Repeater ID="Repeater" runat="server">
                                    <HeaderTemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col">ID</th>
                                                <th scope="col">Center Name</th>
                                                <th scope="col">Order Date</th>
                                                <th scope="col">Total Quantity</th>
                                                <th scope="col">Total Price</th>
                                                <th scope="col">Order By</th>
                                                <th scope="col">Action</th>

                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                             <td ><%# DataBinder.Eval(Container, "DataItem.pk_order_to_book_id")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.center_name")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_order_dt")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_qty")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_price")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.user_name")%></td>
                                            
                                            <td>
                                                 <asp:LinkButton ID="btnid" runat="server" OnClientClick='<%# "next(" + Eval("pk_order_to_book_id") + "); " %>'  Text='<img src="images/inventory.png" style="width: 30px; height: 30px;">'></asp:LinkButton> 
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

                                <script>
                                function next(id) {
                                    window.open('complete_req_from_wh_to_bookcitywh.aspx?id=' + id + '')
                                }
                                </script>
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
        </div>
    </div>
    <!--end main wrappper-->
</asp:Content>
