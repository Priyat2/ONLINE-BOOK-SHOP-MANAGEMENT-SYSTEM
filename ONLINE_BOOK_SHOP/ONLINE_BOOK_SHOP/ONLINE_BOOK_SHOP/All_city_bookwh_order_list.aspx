<%@ Page Title="Center- Confirm Order Reports" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="All_city_bookwh_order_list.aspx.cs" Inherits="ONLINE_BOOK_SHOP.All_city_bookwh_order_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .content2 {
            padding: 10px 40px 25px 40px;
            min-width: 320px;
        }
        * {
  box-sizing: border-box;
}

/* Create three equal columns that floats next to each other */
.column {
  float: left;
  width: 22.33%;
  padding:10px;
   /* Should be removed. Only for demonstration */
}


/* Clear floats after the columns */
.row:after {
  content: "";
  display: table;
  clear: both;
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
                       <h4>Reports of Center Orders (Based on Order Date)</h4>
                        <div class="panel-body">
                            
                            <div>

                                <div class="row">

                                    <div class="column">
                                         <label class="form-check-label" for="gridCheck">Start Date :</label>
                                    <asp:TextBox ID="txtstartdate" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>

                                    </div>

                                    <div class="column">
                                         <label style="padding-left: 15px;" class="form-check-label" for="gridCheck">End Date :</label>
                                    <asp:TextBox ID="txtenddate" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>

                                    </div>

                                   <div class="column">
                                       <span style="padding-left: 15px;">
                                        <asp:Button ID="btnreport" class="button button2" runat="server" Text="Show Reports" OnClick="btnreport_Click" />
                                    </span>
                                   </div>
                                   
                                    

                                   <%-- <span class="form-group form-group-lg-4 form-inline pull-right">
                                        <asp:Button ID="btndash" CssClass="btn btn-success " runat="server" Text="Dashboard" OnClick="btndash_Click" />
                                    </span>--%>
                                </div>

                            </div>
                            <asp:HiddenField ID="getid" runat="server" />
                            <div  style="padding-top: 15px;">
                                <asp:Repeater ID="Repeater" runat="server">
                                    <HeaderTemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col">ID</th>
                                                <th scope="col">Warehouse Name</th>
                                               
                                                <th scope="col">Order Date</th>
                                                <th scope="col">Total Quantity</th>
                                                <th scope="col">Total Price</th>
                                                <th scope="col">Order By</th>

                                               <th scope="col">Status</th>
                                              <%-- <th scope="col">Confirm By</th>--%>
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
                                            <td> <span Style="color:<%# Eval("color") %>;"><%# Eval("status")%></span>  </td>
                                           <%-- <td><%# DataBinder.Eval(Container, "DataItem.confm")%></td>--%>
                                            <td><asp:LinkButton ID="btnid" runat="server" OnClientClick='<%# "next(" + Eval("pk_order_to_book_id") + "); " %>' style="color:blue;" Text='<img src="images/inventory.png" style="width: 30px; height: 30px;">'></asp:LinkButton>
                                               <%-- <button id="btnid" onclick='next(<%# Eval("pk_order_to_wh_id") %>)' class="btn btn-info">View Items</button>--%></td>
                                          

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

                                   .hpanel .panel-body {
                                    background: #f2e7c3;
                                    border: 1px solid #e4e5e7;
                                    border-radius: 2px;
                                    padding: 20px;
                                }

                                   .button {
                                    background-color: lightseagreen; /* Green */
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
                                    color: lightseagreen;
                                    border: 2px solid lightseagreen;
                                }

                                    .button2:hover {
                                        background-color: lightseagreen;
                                        color: white;
                                    }

                                .button2 {
                                    width: 140px;
                                }

                                .button2 {
                                    border-radius: 8px;
                                }
                                </style>

                                <script>
                                function next(id) {
                                    window.open('view_all_city_bookwh_order_list.aspx?id=' + id + '')
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
