<%@ Page Title="Local- Receive Item" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="View_Local_order_Regionalwh.aspx.cs" Inherits="ONLINE_BOOK_SHOP.View_Local_order_Regionalwh" %>
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
  width: 33.33%;
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

                                <span class="form-group form-group-lg-4 form-inline pull-right">
                                    <asp:Button ID="btnback" CssClass="btn" style="background-color: #48C9B0; color: white;" runat="server" Text="Back" OnClick="btnback_Click" />
                                </span>

                                <div>
                                    <h3><b>Order Details :</b></h3>
                                    <b>Order ID :</b>
                                    <asp:Label runat="server" Text=" " ID="lblorderid1"></asp:Label>
                                    -
                                <asp:Label runat="server" Text="" ID="lbllocation"></asp:Label>

                                    <span class="form-group form-group-lg-4 form-inline pull-right"><b>Date : </b>
                                        <asp:Label runat="server" Text=" " ID="lbldate"></asp:Label>
                                    </span>

                                </div>
                                <hr />
                                   <div class="row">
                                    <div class ="column">
                                        <label style="padding-left:15px;"><b>Supplier Name :</b></label>
                                            <asp:Label runat="server" Text="" ID="lbllocalname"></asp:Label>
                                    </div>
                                    <div class="column">

                                        <label><b>Order Quantity :</b></label>
                                            <asp:Label  runat="server" Text="" ID="lbltotalqty"></asp:Label>
                                    </div>
                                    <div class="column">
                                        <label><b>Order price : </b></label>
                                            <asp:Label runat="server" Text="" ID="lbltotalprice"></asp:Label>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="column">
                                        <label style="padding-left:15px;"><b>Delivery Invoice : </b></label>
                                            <asp:TextBox runat="server" CssClass="form-control" style="width:200px;" ID="txtinvoice" Text=""></asp:TextBox>
                                     </div>
                                    <div class="column">
                                        <label><b>GRN : </b></label>
                                            <asp:TextBox runat="server" CssClass="form-control" style="width:200px;" ID="txtgrn" Text=""></asp:TextBox>

                                    </div>
                                    <div class="column">
                                        <label><b>Delivery Charges :</b></label>
                                    <asp:TextBox runat="server" ID="lbldelch" CssClass="form-control" style="width:200px;"  Text="0"></asp:TextBox>
                                    </div>
                                </div>
                                <hr/>
                                <asp:HiddenField ID="getid" runat="server" />
                                <div>
                                    <asp:Repeater ID="Repeater" runat="server">
                                        <headertemplate>
                                        <table cellpadding="2" cellspacing="1" id="tblProducts" class="table table-hover">
                                            <tr>
                                                <th scope="col" style="display: none;">ID</th>
                                                <th scope="col" style="display:none;">Lo Fk ID</th>
                                                <th scope="col" style="display:none;">Item Id</th>
                                                <th scope="col">Name</th>
                                                <th scope="col">Quantity</th>
                                                 <th scope="col">Received Qty</th>
                                                <th scope="col">Bonus Qty</th>
                                                <th scope="col">Total Qty</th>
                                                <th scope="col">Batch No.</th>
                                                <th scope="col">Expiry</th>
                                                <th scope="col">Price(per item)</th>
                                               
                                                <th scope="col">Rate(%)</th>
                                                 <th scope="col">Disc(%)</th>
                                                 <th scope="col">Value</th>


                                            </tr>
                                    </headertemplate>
                                        <itemtemplate>
                                        <tr>
                                            <td style="display: none;">
                                                <asp:Label ID="lbltrloid" runat="server" Text='<%# Eval("pk_trlo_id") %>' /></td>

                                              <td style="display: none;">
                                                <asp:Label ID="lblloid" runat="server" Text='<%# Eval("trlo_fk_lo_id") %>' /></td>

                                            <td style="display: none;">
                                                <asp:Label ID="lblitemid" runat="server" Text='<%# Eval("trlo_fk_item_id") %>' /></td>

                                            <td><%# DataBinder.Eval(Container, "DataItem.item_name")%></td>                             
                                                    
                                            <td><%# DataBinder.Eval(Container, "DataItem.trlo_item_qty")%></td>


                                            <td>
                                                <asp:TextBox runat="server" CssClass ="form-control" style="width:80px;" onkeyup="calculate(this)"    ID="txtrecieved" Text='<%# Eval("trlo_item_qty") %>'></asp:TextBox></td>

                                             <td> <asp:TextBox runat="server"  CssClass ="form-control" style="width:80px;" ID="txtbonus" onkeyup="calculate(this)"   Text="0"></asp:TextBox></td>

                                            <td > <asp:Label runat="server" ID="lbltqty" Text='<%# Eval("total") %>'  ></asp:Label></td>

                                            <td><asp:TextBox runat="server" ID="txtbatch" class="form-control" style="width:80px;" Text=""></asp:TextBox></td>

                                               <td><asp:TextBox runat="server" ID="txtexpiry" CssClass="form-control" style="width:130px;" TextMode="Date" Text=""></asp:TextBox></td>

                                            <td><asp:TextBox runat="server" CssClass ="form-control" style="width:80px;" onkeyup="calculate(this)" ID="txtpriper" Text='<%# Eval("trlo_item_price") %>'></asp:TextBox></td>
                                            
                                            <td><asp:TextBox runat="server"  CssClass ="form-control" style="width:80px;" onkeyup="calculate(this)" ID="txtrate" Text='<%# Eval("trlo_tax_percent") %>'></asp:TextBox></td>

                                             <td><asp:TextBox runat="server"  CssClass ="form-control" style="width:80px;" onkeyup="calculate(this)" ID="txtdisc" Text='<%# Eval("trlo_discount_percent") %>'></asp:TextBox></td>

                                            <td><asp:Label runat="server" ID="finalprice" Text= '<%# Eval("final_price") %>'></asp:Label></td>
                                           

           

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
                         </div>
                            <span class="form-group form-group-lg-4 form-inline pull-right">
                                <asp:Button ID="btnsave" CssClass="btn" Style="background-color: #C39BD3; color: whitesmoke;" runat="server" Text="Save" OnClick="btnsave_Click" />
                            </span>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--end main wrappper-->
     <script>
            function calculate() {
                $('[id*=tblProducts] tr:has(td)').each(function () {
                    var rec_qty = $(this).find('[id*=txtrecieved]').val(); 
                    var bon_qty = $(this).find('[id*=txtbonus]').val(); 
                    $(this).find('[id*=lbltqty]').html(parseFloat(rec_qty) + parseFloat(bon_qty));

                    var price_per = $(this).find('[id*=txtpriper]').val();
                    var rate = $(this).find('[id*=txtrate]').val();
                    var disc = $(this).find('[id*=txtdisc]').val();
                    
                    var total = ((price_per * rec_qty) * rate / 100) + (price_per * rec_qty) -
                                (((price_per * rec_qty) * rate / 100) + (price_per * rec_qty)) * disc /100;
                    

                    $(this).find('[id*=finalprice]').html(parseFloat(total));
                }); 
            }

        </script>

</asp:Content>
