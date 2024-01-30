<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New_Receipt.aspx.cs" Inherits="ONLINE_BOOK_SHOP.New_Recript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bill PrintOut</title>
    <script src="vendor/jquery/dist/jquery.min.js"></script>
    <script src="vendor/bootstrap/dist/js/bootstrap.min.js"></script>
    <%--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">--%>
    <%-- <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>--%>
    <link href="../assets/css/billpdf.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.3/dist/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="invoice-box">
            <asp:HiddenField ID="bill_id" runat="server" />
            <table>
                <tr>
                    <td class="bb" style="width: 500px;">
                        <p class="images">
                            <img class="logo" src="https://erp.sabkadentist.net/images/sabkadentist-logo-green.png" style="max-height: 150px; width: 300px;" />
                        </p>
                    </td>
                    <td class="bb" style="text-align: right; width: 500px;">
                        <%--<p>
                            <strong>ORIGINAL FOR RECIPIENT</strong>
                        </p>--%>
                        <%-- <H1>TAX INVOICE</H1>--%>
                        <p>
                            <strong>Total Dental Care Pvt Ltd</strong>
                            <br />
                            <strong>
                                <asp:Label ID="lblcenteradd" runat="server"></asp:Label></strong><br />
                        </p>
                    </td>
                </tr>
            </table>
            <table width="100%">


                <tr align="center">
                    <td>

                        <table>
                            <tr>
                                <td style="height: 20px;"></td>
                            </tr>
                            <tr>
                                <td style="width: 120px;">Supplier Name: </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblpatname" runat="server" Text=""></asp:Label></td>
                                <td style="width: 120px;"><b>PURCHASE ORDER</b></td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblbill" runat="server"></asp:Label></td>

                            </tr>
                            <tr>
                                <td style="width: 120px;">Supplier Address: </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lbladdress" runat="server"></asp:Label></td>
                                <td style="width: 120px;">PO No.: </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblpono" runat="server" Text=""></asp:Label></td>
                            </tr>
                            <tr>
                                <td style="width: 120px;">ENQ No.: </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblenqno" runat="server"></asp:Label></td>
                                <td style="width: 120px;">PO DATE : </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lbldate" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td style="width: 120px;">ENQ. DATE: </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblenqdate" runat="server"></asp:Label></td>
                            <%--    <td style="width: 120px;">Visit ID </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblvisit" runat="server"></asp:Label></td>--%>
                            </tr>
                            <tr>
                                <td style="width: 120px;">QUT REF.: </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblqutref" runat="server"></asp:Label></td>
                               <%-- <td style="width: 120px;">Register Date: </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblregister" runat="server"></asp:Label></td>--%>
                            </tr>
                            <tr>
                                <td style="width: 120px;">DATE : </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblqutdate" runat="server"></asp:Label></td>
                                <%--<td style="width: 120px;">Kln Name: </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblkln" runat="server"></asp:Label></td>--%>
                            </tr>
                           <%-- <tr>
                                <td style="width: 120px;">Rate Plan: </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblrate" runat="server"></asp:Label></td>
                                <td style="width: 120px;">Center Pan No: </td>
                                <td style="width: 200px;">
                                    <asp:Label ID="lblcen" runat="server"></asp:Label></td>
                            </tr>--%>
                            <tr>
                                <td style="height: 50px;"></td>
                            </tr>


                        </table>
                        <%-- <div>
                            <div style="text-align: center;">
                                <label><b>Services & Procedures</b></label>
                            </div>

                        </div>--%>
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:HiddenField ID="getid" runat="server" />
                        <asp:Repeater ID="repeater" runat="server">

                            <HeaderTemplate>
                                <table class="table table-bordered">
                                    <thead>
                                        <tr style="background-color: #ddd;">
                                            <th style="display:none;">SR No.
                                        </th>

                                            <th>Item Description 
                                        </th>
                                            <th>Unit
                                        </th>
                                            <th>Qty
                                        </th>
                                            <th>BQty
                                        </th>
                                            <th>GST
                                        </th>
                                             <th>GST%
                                        </th>
                                             <th>DISC
                                        </th>
                                             <th>DISC%
                                        </th>
                                             <th>Unit Price
                                                 <hr />
                                                 Rs. Ps
                                        </th>
                                             <th>Value
                                                 <hr />
                                                 Rs. Ps
                                        </th>
                                        </tr>
                                    </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td style="display:none;">
                                       <asp:Label ID="lbltrpoid" runat="server" Text='<%# Eval("pk_trpo_id") %>' />
                                        </td>

                                    <td>
                                       <%# DataBinder.Eval(Container, "DataItem.item_name")%>
                                        </td>
                                    <td>
                                     
                                        </td>
                                    <td>
                                       <%# DataBinder.Eval(Container, "DataItem.trpo_item_qty")%>
                                        </td>
                                    <td>
                                   
                                        </td>
                                    <td>
                                        
                                        </td>
                                    <td>
                                        
                                        </td>
                                    <td>
                                     
                                        </td>
                                    <td>
                                       
                                        </td>
                                    <td>
                                       <%# DataBinder.Eval(Container, "DataItem.trpo_item_price")%>
                                        </td>
                                    <td>
                                      <%# DataBinder.Eval(Container, "DataItem.total_price")%>
                                        </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>

                                </table>
                               
                            </FooterTemplate>
                        </asp:Repeater>


                        <%--   <div>
                            <div style="text-align: center;">
                                <label><b>Payment Details</b></label>
                            </div>

                        </div>--%>

                    </td>
                </tr>
 
                <tr>
                    <td>
                        <table align="right" class="table-bordered">
                            <tr>
                                <td style="width: 180px;"><b>Gross Amount </b></td>
                                <td style="width: 200px; text-align: center;">
                                    <asp:Label ID="lblgrossamount" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td style="width: 120px;"><b>Discount</b> </td>
                                <td style="width: 200px; text-align: center;">
                                    <asp:Label ID="lbldiscount" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td style="width: 120px;"><b>Total Tax Amount</b> </td>
                                <td style="width: 200px; text-align: center;">
                                    <asp:Label ID="lbltotaltax" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td style="width: 120px;"><b>Net total Value </b></td>
                                <td style="width: 200px; text-align: center;">
                                    <asp:Label ID="lblnetvalue" runat="server"></asp:Label></td>
                            </tr>
                          
                        </table>
                    </td>
                </tr>

                <tr>
                    <td>
                         <div>
                            <div style="height: 25px; ">
                                <label>HOSPITAL TERMS AND CONDITIONS:</label>
                            </div>

                            1)Please attach LPO with Invoice<br />
                            2)PO Validity 15 days<br />
        
                        </div>

                        <div>
                            <div style="height: 50px; padding-top:25px;"><b>DELIVERY:</b></div>
                        </div>

                     <div style="height: 50px; padding-top:25px;" class="container">
                          <div class="row">
                            <div class="col-sm">
                              Prepared By
                                <br />
                                <asp:Label runat="server" ID="lblmanagersign"></asp:Label>
                            </div>
                            <div class="col-sm">
                              Doctors Sign and Stamp
                            </div>
                            <div class="col-sm">
                              Supply Chain Manager
                            </div>
                          </div>
                        </div>
                        <br />
                       

                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
