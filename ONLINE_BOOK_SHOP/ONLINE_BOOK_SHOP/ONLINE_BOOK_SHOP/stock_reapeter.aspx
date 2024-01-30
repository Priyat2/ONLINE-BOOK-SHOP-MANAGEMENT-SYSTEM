<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stock_reapeter.aspx.cs" Inherits="ONLINE_BOOK_SHOP.stock_reapeter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div>


                                <main id="main" class="main">
                                        <section class="section">
                                        <div class="row">
                                             <link href="http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet"/>
                                                <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
                                                <link rel="stylesheet" href="http://cdn.datatables.net/1.10.2/css/jquery.dataTables.min.css"/>
                                               
                                                <script type="text/javascript" src="http://cdn.datatables.net/1.10.2/js/jquery.dataTables.min.js"></script>
                                                <script type="text/javascript" src="http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
                                                                                        <div class="card">
                                                <div class="card-body" id="divadvanceq">
                                                    <div>
                                                        <div id="ImageGallery1" style="overflow: auto;">
                                                            <asp:Repeater ID="Repeater" runat="server">

                                                                <HeaderTemplate>
                                                                    <table id="myTable" class="table table-striped table-bordered table-warning">

                                                                        <thead>
                                                                            <tr>
                                                                                <th>Item Name</th>
                                                                                <th>Description</th>
                                                                                <th>Available Quantity</th>
                                                                                <th>Waste Quantity</th>
                                                                                <th>Total Quantity</th>

                                                                            </tr>

                                                                        </thead>

                                                                        <tbody>
                                                                </HeaderTemplate>
                                                                <ItemTemplate>
                                                                    <tr id="rept">
                                                                        <td><%# Eval("item_name") %></td>
                                                                        <td><%# Eval("stk_desc") %></td>
                                                                        <td><%# Eval("stk_available_qty") %></td>
                                                                        <td><%# Eval("stk_waste_qty") %></td>
                                                                        <td><%# Eval("total_qty") %></td>

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

                                             </section>
                           
                                     </main>
   
                            </div><script>
                                $(document).ready(function () {
                                    $('#myTable').dataTable({

                                        columnDefs: [{
                                            "defaultContent": "-",
                                            "targets": "_all"
                                        }]
                                    });
                                });
                                        </script>

    </div>
    </form>
</body>
</html>
