<%@ Page Title="Add Book Item" Language="C#" MasterPageFile="~/Mainsite.Master" AutoEventWireup="true" CodeBehind="book_itemss_ms.aspx.cs" Inherits="ONLINE_BOOK_SHOP.book_itemss_ms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        table , td{
            font-size:12px;
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
                       <h4>Book Items</h4>
                           
                        <div class="panel-body">
                          
                            <asp:HiddenField ID="getid1" runat="server" />
                            <div>
                                <table>
                                    <tr>
                                        <td>
                                            <label for="">Enter Book Item Name :<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtitemname" runat="server" Style="width: 250px;" class="form-control" placeholder="Enter Item Name"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="itemss" runat="server" ControlToValidate="txtitemname" ErrorMessage="Enter Item name"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Item Discription :<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtitemdesc" runat="server" class="form-control" placeholder="Enter Item Discription"></asp:TextBox>
                                        </td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="itemss" runat="server" ControlToValidate="txtitemdesc" ErrorMessage="Enter Item Discription"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Image Path:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="itemimagepath" runat="server" class="form-control" placeholder="Enter Image path"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="itemss" runat="server" ControlToValidate="itemimagepath" ErrorMessage="Enter Image Path"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Select Category: <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList ID="ddlcat"  runat="server" class="form-control">
                                                <asp:ListItem Value="0">--ADD NEW--</asp:ListItem>

                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator10" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlcat" ValidationGroup="itemss"
                                                ErrorMessage="Please Select Category" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Select Item Type: <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList ID="ddlItemtype" class="form-control" runat="server">
                                                <asp:ListItem Value="0">--Select item_itype_name--</asp:ListItem>
                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator4" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlItemtype" ValidationGroup="itemss"
                                                ErrorMessage="Please Select Item Type" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Item Short Name:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="itemshortname" runat="server" class="form-control" placeholder="Enter Item Short Name"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="itemss" runat="server" ControlToValidate="itemshortname" ErrorMessage="Enter Item Short Name"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Item Code:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtitemcode" runat="server" class="form-control" placeholder="Enter Item Code"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="itemss" runat="server" ControlToValidate="txtitemcode" ErrorMessage="Enter Item Code"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Sort Order:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="txtitemsortorder" runat="server" class="form-control" placeholder="Enter Sort Order"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="itemss" runat="server" ControlToValidate="txtitemsortorder" ErrorMessage="Enter Sort Order."
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Select Item Unit: <span style="color: red;">*</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList ID="ddlitemunit"  class="form-control" runat="server">
                                                <asp:ListItem Value="0">--Select item_unit name--</asp:ListItem>
                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator9" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlitemunit" ValidationGroup="itemss"
                                                ErrorMessage="Please Select Item Unit" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Item pcs per Unit:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="pcsperunit" runat="server" class="form-control" placeholder="Enter item pcs per unit"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RangeValidator runat="server" Type="Integer" MinimumValue="0" MaximumValue="1000" ValidationGroup="itemss" ControlToValidate="pcsperunit"
                                                ErrorMessage="Enter Item pcs per Unit" ForeColor="Red" /></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Item Notes:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="itemnotes" runat="server" class="form-control" placeholder="Enter Item Notes"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" ValidationGroup="itemss" runat="server" ControlToValidate="itemnotes" ErrorMessage="Enter Item Notes"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Sale Cost:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="itemsalecost" runat="server" class="form-control" placeholder="Enter Sale Cost"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" ValidationGroup="itemss" runat="server" ControlToValidate="itemsalecost" ErrorMessage="Enter Sale Cost"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Sale Cost Out:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="salecostout" runat="server" class="form-control" placeholder="Enter Sale Cost Out"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" ValidationGroup="itemss" runat="server" ControlToValidate="salecostout" ErrorMessage="Enter Sale Cost Out"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Sale Cost Old:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="salecostold" runat="server" class="form-control" placeholder="Enter Sale Cost Old"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" ValidationGroup="itemss" runat="server" ControlToValidate="salecostold" ErrorMessage="Enter Sale Cost Old"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Sale Cost Out Old:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="salecostoutold" runat="server" class="form-control" placeholder="Enter Sale Cost Out Old"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="itemss" runat="server" ControlToValidate="salecostoutold" ErrorMessage="Enter Sale Cost Out Old"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Purchase Cost:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="purchasecost" runat="server" class="form-control" placeholder="Enter Purchase Cost"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator17" ValidationGroup="itemss" runat="server" ControlToValidate="purchasecost" ErrorMessage="Enter Purchase Cost"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <%--<tr>
                                        <td>
                                            <label for="">Enter Show In WH:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="showinwh" runat="server" class="form-control" placeholder="Enter Show In WH"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RangeValidator runat="server" Type="Integer" MinimumValue="0" MaximumValue="1000" ValidationGroup="itemss" ControlToValidate="showinwh"
                                                ErrorMessage="Enter Show In WH" ForeColor="Red" /></td>
                                    </tr>--%>

                                  <%--  <tr>
                                        <td>
                                            <label for="">Enter Show In Report:<span style="color: red;"> *</span></label>
                                        </td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="showinreport" runat="server" class="form-control" placeholder="Enter Show In Report"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RangeValidator runat="server" Type="Integer" MinimumValue="0" MaximumValue="1000" ValidationGroup="itemss" ControlToValidate="showinreport"
                                                ErrorMessage="Enter Show In Report" ForeColor="Red" /></td>
                                    </tr>--%>

<%--                                    <tr>
                                        <td>
                                            <label for="">Enter Item Show In ERP:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="showinerp" runat="server" class="form-control" placeholder="Enter Item Show In ERP"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RangeValidator runat="server" Type="Integer" MinimumValue="0" MaximumValue="1000" ValidationGroup="itemss" ControlToValidate="showinerp"
                                                ErrorMessage="Enter Item Show In ERP" ForeColor="Red" /></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Item Show In Entry:<span style="color: red;"> *</span></label>
                                        </td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="showinentry" runat="server" class="form-control" placeholder="Enter Item Show In Entry"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RangeValidator runat="server" Type="Integer" MinimumValue="0" MaximumValue="1000" ValidationGroup="itemss" ControlToValidate="showinentry"
                                                ErrorMessage="Enter Item Show In Entry" ForeColor="Red" /></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter Item ISHF:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="itemishf" runat="server" class="form-control" placeholder="Enter Item ISHF"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RangeValidator runat="server" Type="Integer" MinimumValue="0" MaximumValue="1000" ValidationGroup="itemss" ControlToValidate="itemishf"
                                                ErrorMessage="Enter Item ISHF" ForeColor="Red" /></td>
                                    </tr>--%>

                                    <tr>
                                        <td>
                                            <label for="">Select IGST:<span style="color: red;"> *</span></label></td>
                                         <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList ID="ddlIGST"  class="form-control" runat="server">
                                                <asp:ListItem Value="0">--Select IGST--</asp:ListItem>
                                                 <asp:ListItem Value="10">10%</asp:ListItem>
                                                 <asp:ListItem Value="12">12%</asp:ListItem>
                                                 <asp:ListItem Value="18">18%</asp:ListItem>
                                            </asp:DropDownList></td>

                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator11" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlIGST" ValidationGroup="itemss"
                                                ErrorMessage="Please Select IGST" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Select CGST:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList ID="ddlCGST"  class="form-control" runat="server">
                                                <asp:ListItem Value="0">--Select CGST--</asp:ListItem>
                                                 <asp:ListItem Value="10">10%</asp:ListItem>
                                                 <asp:ListItem Value="12">12%</asp:ListItem>
                                                 <asp:ListItem Value="18">18%</asp:ListItem>
                                            </asp:DropDownList></td>

                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator16" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlCGST" ValidationGroup="itemss"
                                                ErrorMessage="Please Select CGST" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter SGST:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList ID="ddlSGST"  class="form-control" runat="server">
                                                <asp:ListItem Value="0">--Select SGST--</asp:ListItem>
                                                 <asp:ListItem Value="10">10%</asp:ListItem>
                                                 <asp:ListItem Value="12">12%</asp:ListItem>
                                                 <asp:ListItem Value="18">18%</asp:ListItem>
                                            </asp:DropDownList></td>

                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator18" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlSGST" ValidationGroup="itemss"
                                                ErrorMessage="Please Select SGST" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter HSN:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="HSN" runat="server" class="form-control" placeholder="Enter HSN"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator26" ValidationGroup="itemss" runat="server" ControlToValidate="HSN" ErrorMessage="Enter HSN"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter HSN Desc:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="HSNDesc" runat="server" class="form-control" placeholder="Enter HSN Desc"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator27" ValidationGroup="itemss" runat="server" ControlToValidate="HSNDesc" ErrorMessage="Enter HSN Desc"
                                                ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>

                                   <%-- <tr>
                                        <td>
                                            <label for="">Enter IGST Percentage:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="IGSTPercentage" runat="server" class="form-control" placeholder="Enter IGST Percentage"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="IGSTPercentage" Display="Dynamic" ErrorMessage="Enter IGST Percentage" Operator="DataTypeCheck" SetFocusOnError="True" Type="Double" ValidationGroup="itemss" ForeColor="Red"></asp:CompareValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter CGST Percentage:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="CGSTPercentage" runat="server" class="form-control" placeholder="Enter CGST Percentage"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="CGSTPercentage" Display="Dynamic" ErrorMessage="Enter CGST Percentage" Operator="DataTypeCheck" SetFocusOnError="True" Type="Double" ValidationGroup="itemss" ForeColor="Red"></asp:CompareValidator></td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <label for="">Enter SGST Percentage:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:TextBox ID="SGSTPercentage" runat="server" class="form-control" placeholder="Enter SGST Percentage"></asp:TextBox></td>
                                        <td style="padding-left: 25px;">
                                            <asp:CompareValidator ID="CompareValidator5" runat="server" ControlToValidate="SGSTPercentage" Display="Dynamic" ErrorMessage="Enter SGST Percentage" Operator="DataTypeCheck" SetFocusOnError="True" Type="Double" ValidationGroup="itemss" ForeColor="Red"></asp:CompareValidator></td>
                                    </tr>--%>

                                  <%--  <tr>
                                        <td>
                                            <label for="">Select Item Sub Category:<span style="color: red;"> *</span></label></td>
                                        <td style="padding-left: 80px; padding-bottom: 15px;">
                                            <asp:DropDownList ID="ddlitemsubcat" class="form-control" runat="server">
                                                <asp:ListItem Value="0">--Select item_sub_cat_name--</asp:ListItem>
                                            </asp:DropDownList></td>
                                        <td style="padding-left: 25px;">
                                            <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator31" Display="Dynamic"
                                                runat="server" ControlToValidate="ddlitemsubcat" ValidationGroup="itemss"
                                                ErrorMessage="Please Select Item Sub Category" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>--%>
                                </table>
                            </div>


                            <asp:Button ID="btnsubmit" class="button button2" ValidationGroup="itemss" runat="server" Text="Submit" OnClick="btnsubmit_Click" />


                        </div>
                          <style>
                               .hpanel .panel-body {
                                background: #D4F4C7;
                                border: 1px solid #e4e5e7;
                                border-radius: 2px;
                                padding: 20px;
                            }

                                .button {
                                    background-color: #FE5000; /* Green */
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
                                    color: #FE5000;
                                    border: 2px solid #FE5000;
                                }

                                    .button2:hover {
                                        background-color: #FE5000;
                                        color: white;
                                    }

                                .button2 {
                                    width: 100px;
                                }

                                .button2 {
                                    border-radius: 8px;
                                }
                        </style>
                </div>
                </div>
            </div>
        </div>
    </div>

    <!--end main wrappper-->
</asp:Content>

