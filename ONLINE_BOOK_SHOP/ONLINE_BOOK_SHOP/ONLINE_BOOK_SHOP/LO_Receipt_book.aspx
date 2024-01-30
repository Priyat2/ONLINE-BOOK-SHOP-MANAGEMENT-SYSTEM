﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LO_Receipt_book.aspx.cs" Inherits="ONLINE_BOOK_SHOP.LO_Receipt_book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Local- Receipt</title>
  <link rel="icon" type="image/x-icon" href="images/book-shop.gif">
    
    
    <style>
    
 .centerdiv{
        justify-content: center;
        text-align: center;
    }

    table , th ,td{
        border: 1px solid;
        justify-content: center;
        text-align: center;
      border-collapse: collapse;
    }

    th,td{
        padding: 10px;
    }
   
    .th1 {
        border: 1px solid;
        padding: 10px;
        border-collapse: collapse;
    }
    .font{
        font-size:medium;
        font-weight: 400;
    }

    .same{
        display: inline-block;
    }

    .lp{
        width: 250px;
    }
    .op{
        width: 950px;
        justify-content: center;
        text-align: center;
    }

    .le{
        width: 550px;
    }

    .le1{
        width: 141px;
    }
    .le2{
        width: 135px;
    }
    
    .fontr{
        text-align: left;
    }

    .tb3{
        width: 35px;
    }

    .tb3w{
        width: 45px;
    }
    .tb3item{
        width: 350px;
    }

    .tb3u{
        width: 45px;
    }

    .tb3gst{
        width: 50px;
    }

    .tb3up{
        width: 121px;
    }

    .th4{
        width: 405px;
    }
    .th4d{
        width: 760px;
    }

    .divtp{
        padding-top: 50px;
    }

    .singleline{
        display: inline-block;
    }

    .divsl1{
        padding-left: 800px;
    }

    .divsl2{
        padding-left: 250px;
    }

    .divsl3{
        padding-left: 200px;
    }

    .fontfooter{
        font-size: smaller;
        
    }
    
    .footerdiv{
        justify-content: center;
        text-align: center;
    }

    .footer{
        padding-top: 50px;
    }

     </style>
     <script src="vendor/jquery/dist/jquery.min.js"></script>
    <script src="vendor/bootstrap/dist/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <header>
           <div>

            <div class="same lp"> 
                <td >
                        <p class="images">
                            <img class="logo" src="images/1.PNG" style="max-height: 112px; width: 132px;" />
                        </p>
                    </td>
            </div>
            <div class="same op "> 
                <h3>Swastik Book Store (CIN:- U33112MH2010PTC209531)</h3>
                <asp:Label class="font" runat="server" ID="lblheadadd" Text="J. M Shopping Centre, Opposite Railway Station, Vartak Road, Virar West, Thane - 401303"></asp:Label>
               
            </div>
           </div>
    </header>
         <hr/>
        <main>
       <div class="centerdiv">
        <table >
            <tr>
                <th>
                    <h3>Store</h3>
                    <br/>
                   <asp:Label runat="server" class="font" ID="lblmainadd" Text="Swastik Book Store,J. M Shopping Centre, Opposite Railway Station, Vartak Road, Book store in Virar West, Maharashtra, Thane - 401303"></asp:Label>
                 
                </th>
                <th >
                    <h2>Local Order</h2>
                    <hr>
                    <table>
                        <tr>
                            <th class="th1">Date: <asp:Label  class="font"  runat="server" ID="lbldate" Text=""></asp:Label></th>
                            <th class="th1">Order No. <asp:Label class="font" runat="server" ID="lbllono" Text=""></asp:Label></th>
                        </tr>
                    </table>
                    

                    
                </th>
            </tr></table>
            <table>
            <tr>
                <th class="le">Local shop</th>
                <th class="le1">ENQ. NO.</th>
                <th class="le1">ENQ. DATE</th>
                <th class="le2">QUT REF.</th>
                <th class="le2">DATE</th>
            </tr>

            <tr>
                <td class="fontr">
                    <asp:Label runat="server" ID="lbllocalname" Text=""></asp:Label>
                   <asp:Label runat="server" ID="lbllocaladd" Text=""></asp:Label>
                    <br/>
                   ph: <asp:Label runat="server" ID="lbllocalno" Text=""></asp:Label>
                    
                   <br/>
                    FAX:<asp:Label runat="server" ID="lbllocalfax" Text=""></asp:Label>
                              
                </td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                
            </tr>
        </table>
            <asp:HiddenField ID="getid" runat="server" />
                        <asp:Repeater ID="repeater" runat="server">

                            <HeaderTemplate>
                                <table class="table table-bordered">
                                    <thead>
                                        <tr style="background-color: #ddd;">
                                            <th  class="tb3">SR No.
                                        </th>

                                            <th class="tb3item">Item Description 
                                        </th>
                                            <th class="tb3u">Unit
                                        </th>
                                            <th class="tb3w">Qty
                                        </th>
                                            <th class="tb3w">BQty
                                        </th>
                                            <th class="tb3gst">GST(Rs.)
                                        </th>
                                             <th class="tb3gst">GST%
                                        </th>
                                             <th class="tb3gst">DISC(Rs.)
                                        </th>
                                             <th class="tb3gst">DISC%
                                        </th>
                                             <th class="tb3up">Unit Price
                                                 <hr />
                                                 Rs. Ps
                                        </th>
                                             <th class="tb3up">Value
                                                 <hr />
                                                 Rs. Ps
                                        </th>
                                        </tr>
                                    </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td >
                                       <asp:Label ID="lbltrloid" runat="server" Text='<%# Eval("pk_trlo_id") %>' />
                                        </td>

                                   <td>
                                       <%# DataBinder.Eval(Container, "DataItem.book_item_name")%>
                                       
                                    </td>
                                                                     
                                   
                                     <td>
                                         <%# DataBinder.Eval(Container, "DataItem.item_unit_name")%>
                                    </td>
                                      
                                    <td>
                                       <%# DataBinder.Eval(Container, "DataItem.trlo_item_qty")%>
                                        </td>
                                     <td>
                                    <%# DataBinder.Eval(Container, "DataItem.trlo_bonus_qty")%>
                                        </td>
                                     
                                   
                                     <td>  <%# String.Format("{0:0.00}", Eval("gst_amt"))%>
                                       
                                        </td>
                                    
                                     <td>
                                         <%# DataBinder.Eval(Container, "DataItem.trlo_tax_percent")%>
                                        </td>
                                              
                                    <td> <%# String.Format("{0:0.00}", Eval("discount_price"))%>
                                   
                                        </td>
                                    <td>
                                        <%# DataBinder.Eval(Container, "DataItem.trlo_discount_percent")%>
                                        </td>
                                   
                                    <td><%# String.Format("{0:0.00}", Eval("trlo_item_price"))%>
                                     
                                        </td>
                                    <td><%# String.Format("{0:0.00}", Eval("final_price"))%>
                                  
                                        </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>

                                </table>
                               
                            </FooterTemplate>
                        </asp:Repeater>

     <%--   <table>
            <tr>
                <th class="tb3">SR NO</th>
                <th class="tb3item">ITEM DESCRIPTION</th>
                <th class="tb3u">UNIT</th>
                <th class="tb3w">QTY</th>
                <th class="tb3w">BQty</th>
                <th class="tb3gst">GST</th>
                <th class="tb3gst">GST%</th>
                <th class="tb3gst">DISC</th>
                <th class="tb3gst">DISC%</th>
                <th class="tb3up"> UNIT PRICE
                    <hr>
                    RS. Ps
                    
                </th>
                <th class="tb3up">VALUE
                    <hr>
                    RS. Ps
                </th>
            </tr>
            <tr>
                <td><label for="">1</label></td>
                <td><label for="">Gloves-Extra small</label></td>
                <td><label for="">Packet</label></td>
                <td><label for="">500</label></td>
                <td><label for="">.00</label></td>
                <td><label for="">10800.00</label></td>
                <td><label for="">12.00</label></td>
                <td><label for="">0.00</label></td>
                <td><label for="">0.00</label></td>
                <td><label for="">180.00</label></td>
                <td><label for="">100800.00</label></td>
            </tr>
        </table>--%>
        <table>
            <tr>
                <th class="th4">GROSS AMOUNT</th>
                <td class="th4d"><asp:Label ID="lblgrossamount" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <th class="th4">DISCOUNT</th>
                <td class="th4d"> <asp:Label ID="lbldiscount" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <th class="th4">TOTAL TAX AMOUNT</th>
                <td class="th4d"><asp:Label ID="lbltotaltax" runat="server"></asp:Label></td>
            </tr>
             <tr>
                <th class="th4">DELIVERY CHARGES</th>
                <td class="th4d"><asp:Label ID="lbldelch" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <th class="th4">NET TOTAL VALUE</th>
                <td class="th4d"> <asp:Label ID="lblnetvalue" runat="server"></asp:Label></td>
            </tr>
        </table>
    </div>

   
    <br/>
    
    <br/>
    <div>
        <div class="singleline divsl1">
            DELIVERY:
            <p>Prepared By</p>
            <asp:Label runat="server" ID="lblmanagersign"></asp:Label>
        </div>
       
    </div>
    </main>

        <footer class="footer">
        <hr/>
        <div class="footerdiv"> 
        <label class="fontfooter" for="">Regd Off.: 167,1St Floor, New Satguru Nanik Industrial Premises Cooperative Society, Western Express Highway Goregaon East, Mumbbai</label><br>
        <label class="fontfooter" for="">400063 www.sabkadentist.com Email: info@sabkadentist.com Phone: 9222233111.</label><br>
        <label class="fontfooter" for="">GST No: 27AADCT6419N1ZU SAC (999312) RATE (NIL)</label><br>
        <label class="fontfooter" for="">All Disputes, Consents, Transactions & Contracts are Subject to exclusive Jurisdiction of Courts in MUMBAI.</label>
    </div>
    </footer>
          <center>
             <input id="printpagebutton" type="button" value="Print" onclick="printpage()"/>
	    </center>

       <script type="text/javascript">
    function printpage() {
       
        var printButton = document.getElementById("printpagebutton");
       
        printButton.style.visibility = 'hidden';
        
        window.print()
       
        printButton.style.visibility = 'visible';
    }
       </script>
    </form>
</body>
</html>