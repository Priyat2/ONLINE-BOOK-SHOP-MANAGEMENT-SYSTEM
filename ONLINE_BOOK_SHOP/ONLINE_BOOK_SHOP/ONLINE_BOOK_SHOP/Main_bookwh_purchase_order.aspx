<%@ Page Title="Supplier- Place Order" Language="C#" MasterPageFile="~/Mainsite.Master"  AutoEventWireup="true" CodeBehind="Main_bookwh_purchase_order.aspx.cs" Inherits="ONLINE_BOOK_SHOP.Main_bookwh_purchase_order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        table, td {
         
            font-size: 12px;
        }


        th {
            
            background-color: lightseagreen;
            font-weight: bold;
            color:white;
        }

        .content1 {
            padding: 10px 40px 40px 40px;
            min-width: 320px;
        }

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
                      
                          <h4>Purchase From Supplier</h4>
                        <div class="panel-body">
                            <asp:HiddenField ID="hdnpoid" runat="server" />
                            
                            <div>
                                <table>
                                  

                                    <tr>
                                        <td>
                                            <label for="">Select Supplier : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;" >
                                            <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlsupplier" class="form-control" >
                                                <asp:ListItem Value="0">--Select Supplier--</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator1" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlsupplier"
                                                ErrorMessage="Please Select Supplier" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <%--         <tr>
                                        <td>
                                            <label for="">Select Item Type : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlitemtype" class="form-control">
                                                <asp:ListItem Value="0">--Select Item Type--</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator3" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlitemtype"
                                                ErrorMessage="Please Select Item Type" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>--%>

                                    <tr>
                                        <td>
                                            <label for="">Select Item Name : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlitemname" AutoPostBack="true" class="form-control" OnSelectedIndexChanged="ddlitemname_SelectedIndexChanged1">
                                                <asp:ListItem Value="0">-Select Book Item-</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator5" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlitemname"
                                                ErrorMessage="Please Select Item Name" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                          <tr style="padding: 15px;">
                                        <td>
                                            <label for="">Item Unit :</label></td>
                                        <td style="padding-left: 80px; padding-bottom:25px;">
                                            <asp:Label ID="lblunits" runat="server" Text=""></asp:Label></td>

                                    </tr>

                                  <%--  <tr>
                                        <td>
                                            <label for="">Enter Product Description : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtprodesc" runat="server" TextMode="MultiLine" placeholder="Enter Product Description" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="hardware" ControlToValidate="txtprodesc" ErrorMessage="Enter Product Description"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>--%>



                                    <tr>
                                        <td>
                                            <label for="">Enter Item Quantity : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtqty" runat="server" placeholder="Enter Item Quantity" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="hardware" ControlToValidate="txtqty" ErrorMessage="Enter Item Quantity"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                        <tr>
                                        <td>
                                            <label for="">GST : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList Style="width: 250px;" runat="server" ID="ddlgst" class="form-control">
                                                <asp:ListItem Value="0">--Select GST--</asp:ListItem>
                                                <asp:ListItem Value="10">10%</asp:ListItem>
                                                <asp:ListItem Value="12">12%</asp:ListItem>
                                                <asp:ListItem Value="18">18%</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator3" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlgst"
                                                ErrorMessage="Please Select GST" ValidationGroup="hardware" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label for="">Discount(%) : <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtdiscount" runat="server" Text="0" placeholder="Enter Discount" class="form-control"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="hardware" ControlToValidate="txtdiscount" ErrorMessage="Enter Item Quantity"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">In Stock Quantity :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:Label ID="lblqty" runat="server" Text=""></asp:Label></td>

                                    </tr>



                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">Sale Cost :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:Label ID="lblsalecost" runat="server" Text=""></asp:Label></td>

                                    </tr>

                                    <tr style="padding: 15px;">
                                        <td>
                                            <label for="">Purchase Cost :</label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:Label ID="lblpurchasecost" runat="server" Text=""></asp:Label></td>

                                    </tr>
                                </table>
                                <span style="padding-left:150px;"><asp:Button ID="btnadd" CssClass="btn btn-warning" runat="server" ValidationGroup="hardware" Text="ADD" OnClick="btnadd_Click" /></span>


                               
                            </div>

                           
                        </div>
                    </div>

                          <div id="hidepanel" runat="server" visible="false">
                       <h4>Order Product list</h4>


                        <div  class="panel-body">


                            <div class="row">
                                <div class="col-lg-12">


                                    <div class="card">
                                        <div  class="card-body">
                                          
                                            

                                             <div class="row g-3">
                                                <table class="table table-striped table-bordered table-hover">
                                                    <asp:Repeater ID="repeater" runat="server"   OnItemDataBound ="OnItemDataBound">
                                                        <HeaderTemplate>
                                                            <tr >
                                                                <th style="display: none;">ID </th>
                                                                <th style="display: none;">Center ID </th>
                                                                <th style="display: none;">Supplier ID </th>
                                                                <th style="display: none;">Desc </th>
                                                                <th style="text-align: center;">Name </th>
                                                                <th style="text-align: center;">Quantity</th>
                                                                <th style="text-align: center;">GST(%)</th>
                                                                <th style="text-align: center;">Discount(%)</th>
                                                                <th style="text-align: center;">Price per pc </th>
                                                                <th style="text-align: center;">Total Price </th>
                                                                <th style="text-align: center;">Action </th>

                                                            </tr>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <tr >
                                                                <td style="display: none">
                                                                    <asp:Label ID="orderid" runat="server" Text='<%# Eval("pk_trpo_id") %>' />
                                                                </td>

                                                                <td style="display: none">
                                                                    <asp:Label ID="lblwh" runat="server" Text='<%# Eval("trpo_wh_id") %>' />
                                                                </td>

                                                                <td style="display: none">
                                                                    <asp:Label ID="lblsplr" runat="server" Text='<%# Eval("trpo_splr_id") %>' />
                                                                </td>

                                                                <td style="display: none">
                                                                    <asp:Label ID="lbldesc" runat="server" Text='<%# Eval("trpo_desc") %>' />
                                                                </td>

                                                                <td style="text-align: center;"><%# Eval("book_item_name") %> </td>

                                                                <td style="text-align: center;">
                                                                    <asp:TextBox ID="txtquantity1" runat="server" Text='<%# Eval("trpo_item_qty") %>'></asp:TextBox>
                                                                </td>

                                                                    <asp:HiddenField ID="hdstatus" runat="server" Value='<%# Eval("trpo_tax_percent") %>' />
                                                                <td style="text-align: center;">
                                                                    <asp:DropDownList runat="server" ID="ddlgstre" class="form-control">
                                                                        <asp:ListItem Value="10">10</asp:ListItem>
                                                                        <asp:ListItem Value="12">12</asp:ListItem>
                                                                        <asp:ListItem Value="18">18</asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>

                                                                <td style="text-align: center;">
                                                                    <asp:TextBox ID="txtdiscount" runat="server" Text='<%# Eval("trpo_discount_percent") %>'></asp:TextBox>
                                                                </td>

                                                                <td style="text-align: center;">
                                                                    <asp:Label ID="lblprice" runat="server" Text='<%# Eval("trpo_item_price") %>'></asp:Label></td>

                                                                 <td style="text-align: center;">
                                                                    <asp:Label ID="lblfinalprice" runat="server" Text='<%# Eval("final_price") %>'></asp:Label></td>

                                                                <td style="text-align: center;">
                                                                    <asp:LinkButton ID="lnkDelete" Text="Delete" CssClass="btn btn-danger" runat="server" OnClientClick="return confirm('Do you want to delete this Order?');"
                                                                        OnClick="DeleteCustomer" />
                                                                </td>

                                                            </tr>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </table>
                                            </div>
                                            <asp:Button ID="btnUpdateCart" Text="Update Order" CssClass="btn"  style="background-color:#FF7F50; color:white;" ValidationGroup="02"
                                                runat="server" OnClick="btnUpdateCart_Click" />

                                            <span class="form-group form-group-lg-4 form-inline pull-right">
                                                <asp:Button ID="btnplace" CssClass="btn btn-warning " runat="server" Text="Place Order" OnClick="btnplace_Click" />
                                            </span>



                                        </div>
                                           <style>
                            .hpanel .panel-body {
                                background: #D4F4C7;
                                border: 1px solid #e4e5e7;
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
            </div>

        </div>
    </div>


    <!-- Main Wrapper End-->

     
    </asp:Content>
