<%@ Page Title="Center - Request Report" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Request_Report.aspx.cs" Inherits="Warehouse.Request_Report" %>
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
                      
                        <div class="panel-body">
                             <h4>Reports of Request Status (Based on Order Date)</h4>
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
                                        <asp:Button ID="btnreport" CssClass="btn btn-info " runat="server" Text="Show Reports" OnClick="btnreport_Click" />
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
                                                <th scope="col">Center Name</th>
                                                <th scope="col">Order Date</th>
                                                <th scope="col">Total Quantity</th>
                                            
                                               <th scope="col">Status</th>
                                                   <th scope="col">Aproove Center</th>
                                                <%--<th scope="col">Action</th>--%>

                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                             <td ><%# DataBinder.Eval(Container, "DataItem.pk_order_to_wh_id")%></td>
                                           
                                            <td><%# DataBinder.Eval(Container, "DataItem.center_req")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_order_dt")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.otw_qty")%></td>
                                            <td> <span style="color:<%# Eval("color") %>;"><%# Eval("status")%></span>  </td>
                                               <td><%# DataBinder.Eval(Container, "DataItem.center_pass")%></td>
                                          <%--  <td><asp:LinkButton ID="btnid" runat="server" OnClientClick='<%# "next(" + Eval("pk_order_to_wh_id") + "); " %>' style="color:blue;" Text='<img src="images/view.png">'></asp:LinkButton>--%>
                                               <%-- <button id="btnid" onclick='next(<%# Eval("pk_order_to_wh_id") %>)' class="btn btn-info">View Items</button></td> --%>
                                         

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

                               <%-- <script>
                                function next(id) {
                                    window.open('view_all_city_wh_order_list.aspx?id=' + id + '')
                                }
                            </script>--%>
                            </div>
                          

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--end main wrappper-->
</asp:Content>
