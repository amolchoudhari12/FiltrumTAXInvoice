<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true"
    CodeFile="ViewPOItems.aspx.cs" Inherits="UI_ViewPOItems" Title="View POItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 100px; height: 21px;">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: center; height: 20px;">
                <span style="font-family: Verdana"><strong>View PO Items</strong></span></td>
        </tr>
    </table>
    <table style="width: 100%">
        <tr>
            <td style="width: 100px; text-align: center;">
                &nbsp; &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: left">
                <table style="width: 100%">
                    <tr>
                        <td style="width: 135px;">
                            PO Code:</td>
                        <td style="width: 134px;">
                            <asp:TextBox ID="txtPOCode" runat="server"></asp:TextBox></td>
                        <td style="width: 144px;">
                            Costomer Code:</td>
                        <td style="width: 100px;">
                            <asp:TextBox ID="txtCustomerCode" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <table style="width: 100%">
        <tr>
            <td style="width: 100px">
                <asp:GridView ID="grdViewPOItems" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    ForeColor="#333333" GridLines="None" ShowFooter="True" Width="100%"
                    AllowSorting="True" OnSorting="grdViewPOItems_Sorting" OnPageIndexChanging="grdViewPOItems_PageIndexChanging" OnRowCommand="grdViewPOItems_RowCommand" OnRowDeleting="grdViewPOItems_RowDeleting"  >
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundField DataField="POItemID" HeaderText="POItem ID" InsertVisible="False"
                            ReadOnly="True" SortExpression="PurchaseOrderID" />
                             <asp:BoundField DataField="PurchaseOrderID" HeaderText="PurchaseOrder ID" SortExpression="PurchaseOrderID" />
                        <asp:BoundField DataField="PurchaseOrderCode" HeaderText="PurchaseOrder Code" SortExpression="PurchaseOrderCode" />
                         
                        <asp:BoundField DataField="CustomerCode" HeaderText="Customer Code" ReadOnly="True"
                            SortExpression="CustomerCode" />
                        <asp:BoundField DataField="ProductCode" HeaderText="Product Code" SortExpression="ProductCode" />
                        <asp:BoundField DataField="CustomerPartNo" HeaderText="Customer Part No" SortExpression="CustomerPartNo" />
                        <asp:BoundField DataField="FFTLPartNo" HeaderText="FFTLPart Part No" SortExpression="FFTLPartPartNo" />
                        <asp:BoundField DataField="PriceRate" HeaderText="Price"  SortExpression="PriceRate" />
                        <asp:BoundField DataField="UnitOfMesurement" HeaderText="Unit"  SortExpression="UnitOfMesurement" />
                        <asp:CommandField ShowDeleteButton="True" />
                       
                    </Columns>
                    <RowStyle BackColor="#EFF3FB" />
                    <EditRowStyle BackColor="#2461BF" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                    <PagerSettings PageButtonCount="2" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: center">
                <asp:Button ID="btnCancel" runat="server"  Text="Close" OnClick="btnCancel_Click" /></td>
        </tr>
    </table>
</asp:Content>
