<%@ Page Title="Supplier- Order Details" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="Records_of_book_PO_per_items.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Records_of_book_PO_per_items" %>
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
                           <%-- <span class="form-group form-group-lg-4 form-inline pull-right">
                                <asp:Button ID="btnback" CssClass="btn" Style="background-color: #48C9B0; color: white;" runat="server" Text="Back" OnClick="btnback_Click" />
                            </span>--%>

                            <div>
                                <h3><b>Order Details :</b></h3>
                                <b>Order ID :</b>
                                <asp:Label runat="server" Text=" " ID="lblorderid1"></asp:Label>
                                -
                                <asp:Label runat="server" Text="" ID="lbllocation"></asp:Label>
                                -
                                <asp:Label runat="server" Text="" ID="lblpocode"></asp:Label>

                                <span class="form-group form-group-lg-4 form-inline pull-right"><b>Order Date : </b>
                                    <asp:Label runat="server" Text=" " ID="lblorder"></asp:Label>
                                </span>
                                
                            </div>
                            <div style="padding-left:898px;">
                                 <label><b>Receive Date : </b> </label>
                                    <asp:Label runat="server" Text=" " ID="lblreceive"></asp:Label>
                               
                             </div>
                            <hr />
                            <div class="row">
                                <div class="column">
                                    <label style="padding-left:15px;"><b>Supplier Name :</b></label>
                                        <asp:Label  runat="server" Text="" ID="lblsplrname"></asp:Label>
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
                                    <label style="padding-left:15px;"><b>Delivery Invoice :</b></label>
                                        <asp:Label  runat="server" Text="" ID="lblinvoice"></asp:Label>
                                </div>
                                <div class="column">
                                    <label><b>GRN : </b></label>
                                        <asp:Label runat="server" Text="" ID="lblgrn"></asp:Label>

                                </div>
                                <div class="column">
                                    <label><b>Delivery Charges :</b></label>
                                     <asp:Label  runat="server" Text="" ID="lbldelch"></asp:Label>
                                </div>

                            </div>
                            <hr />

                            <asp:HiddenField ID="getid" runat="server" />
                            <div>
                                <asp:Repeater ID="Repeater" runat="server">
                                    <HeaderTemplate>
                                        <table cellpadding="2" cellspacing="1" class="table table-hover">
                                            <tr>
                                                <th scope="col" style="display: none;">ID</th>
                                                <th scope="col">Book Item Name</th>
                                                <th scope="col">Quantity</th>
                                                <th scope="col">Price(per item)</th>
                                                 <th scope="col">Tax(%)</th>
                                                 <th scope="col">Disc(%)</th>
                                                <th scope="col">Value</th>
                                                <th scope="col">Received Qty</th>
                                                <th scope="col">B Qty</th>

                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td style="display: none;">
                                                <asp:Label ID="lbltrpoid" runat="server" Text='<%# Eval("pk_trpo_id") %>' /></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.book_item_name")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.trpo_item_qty")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.trpo_item_price")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.trpo_tax_percent")%></td>

                                             <td><%# DataBinder.Eval(Container, "DataItem.trpo_discount_percent")%></td>

                                            <td><%# DataBinder.Eval(Container, "DataItem.final_price")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.trpo_receive_qty")%></td>
                                            <td><%# DataBinder.Eval(Container, "DataItem.trpo_bonus_qty")%></td>

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


                            </div>


                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--end main wrappper-->
</asp:Content>
