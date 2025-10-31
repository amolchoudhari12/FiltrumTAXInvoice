<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true" CodeFile="ReportCustomerDetails.aspx.cs" Inherits="UI_ReportCustomerDetails" Title="Customer Details Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" >
<tr>
<td style="background-color: lightsteelblue">

<div>
    <span style="font-family: Verdana"><strong>Customer Details:</strong></span></div>


</td>
</tr>


<tr>
<td>

<div>


</div>


</td>
</tr>


<tr>
<td style="height: 181px" valign="top">

<div>
    <asp:GridView ID="grdCustomerDetails" runat="server" AutoGenerateColumns="False" CellPadding="4"
        ForeColor="#333333" GridLines="None" Width="100%" OnRowCommand="grdCustomerDetails_RowCommand" OnSelectedIndexChanged="grdCustomerDetails_SelectedIndexChanged">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="CustomerCode" HeaderText="Customer Code" />
            <asp:BoundField DataField="CustomerName" HeaderText="Name" />
            <asp:BoundField DataField="ECCNumber" HeaderText="ECC Number" >
                <ControlStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="Country" HeaderText="Country" />
            <asp:BoundField DataField="City" HeaderText="City" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="Phone" />
            <asp:BoundField DataField="FaxNumber" HeaderText="Fax" />
            <asp:ButtonField CommandName="NoOfPOs" DataTextField="NoOfPOs" HeaderText="No. Of POs"
                Text="No. Of POs" />
            <asp:ButtonField CommandName="NoOfInvoice" DataTextField="NoOfInvoice" HeaderText="No. Of Invoice"
                Text="No Of Invoice" />
            <asp:ButtonField CommandName="TaxRates" Text="TAX Rates">
                <ControlStyle Width="80px" />
            </asp:ButtonField>
        </Columns>
        <RowStyle BackColor="LightBlue" BorderStyle="Solid" ForeColor="Black" HorizontalAlign="Left" VerticalAlign="Top" />
        <EditRowStyle BackColor="#2461BF" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" BorderColor="Black" BorderStyle="Solid" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" VerticalAlign="Top" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>


</div>


</td>
</tr>
</table>
    <table  id= "tblTaxRates" runat="Server" style="width: 100%" border="1">
        <tr>
            <td style="background-color: lightsteelblue;" colspan="4">
                <strong><span style="font-family: Verdana">
                TAX Rates:</span></strong></td>
        </tr>
        <tr>
            <td style="vertical-align: top; width: 100px; text-align: left; height: 1px;">
                <span style="font-size: 10pt; font-family: Verdana">
                            Excise Duty:</span></td>
            <td style="vertical-align: top; width: 100px; text-align: left; height: 1px;">
                            <asp:Label ID="lblExciseDuty" runat="server" Font-Names="Verdana" Font-Size="10pt"
                                Text="Label" Width="115px"></asp:Label></td>
            <td style="vertical-align: top; width: 100px; text-align: left; height: 1px;">
                <span style="font-size: 10pt; font-family: Verdana">Cess Duty:</span></td>
            <td style="vertical-align: top; width: 100px; text-align: left; height: 1px;">
                            <asp:Label ID="lblCessDuty" runat="server" Font-Names="Verdana" Font-Size="10pt"
                                Text="Label" Width="133px"></asp:Label></td>
        </tr>
        <tr>
            <td style="vertical-align: top; width: 100px; text-align: left; height: 19px;">
                <span style="font-size: 10pt; font-family: Verdana">
                            E.Cess Duty:</span></td>
            <td style="vertical-align: top; width: 100px; text-align: left; height: 19px;">
                            <asp:Label ID="lblEcessDuty" runat="server" Font-Names="Verdana" Font-Size="10pt"
                                Text="Label" Width="114px"></asp:Label></td>
            <td style="vertical-align: top; width: 100px; text-align: left; height: 19px;">
                <span style="font-size: 10pt; font-family: Verdana">SH Cess Duty:</span></td>
            <td style="vertical-align: top; width: 100px; text-align: left; height: 19px;">
                            <asp:Label ID="lblSHCessDuty" runat="server" Font-Names="Verdana" Font-Size="10pt"
                                Text="Label" Width="136px"></asp:Label></td>
        </tr>
        <tr>
            <td style="vertical-align: top; width: 100px; text-align: left; height: 15px;">
                <span style="font-size: 10pt; font-family: Verdana">
                            VAT Rate:</span></td>
            <td style="vertical-align: top; width: 100px; text-align: left; font-size: 12pt; height: 15px;">
                            <asp:Label ID="lblVATRate" runat="server" Font-Names="Verdana" Font-Size="10pt" Text="Label"
                                Width="113px"></asp:Label></td>
            <td colspan="2" style="vertical-align: top; text-align: right; font-size: 12pt; height: 15px;">
                <asp:Button ID="btnClose" runat="server" Text="Close" OnClick="btnClose_Click" ToolTip="CloseTAXes" Font-Names="Verdana" /></td>
        </tr>
    </table>
    <table style="width: 100%; font-size: 12pt;" id="tblPOs" runat="server" border="1">
        <tr>
            <td style="width: 100px; vertical-align: top; background-color: lightsteelblue; text-align: left; height: 1px;" valign="top">
                <span style="font-family: Verdana; background-color: lightsteelblue;">Purchase Orders of<strong> </strong>
                    <asp:Label ID="lblCustomerName1" runat="server" Font-Bold="True" Font-Names="Verdana"
                        Font-Size="12pt" Text="lblCustomerName"></asp:Label></span></td>
        </tr>
        <tr>
            <td colspan="1" style="vertical-align: top; height: 144px; text-align: left" valign="top">
                <asp:GridView ID="grdViewPOs" runat="server" 
                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" OnRowCommand="grdViewPOs_RowCommand" HorizontalAlign="Left">
                    <PagerSettings PageButtonCount="2" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" Wrap="True" />
                    <Columns>
                        <asp:BoundField DataField="PurchaseOrderID" HeaderText="Purchase OrderID" InsertVisible="False"
                            ReadOnly="True" SortExpression="PurchaseOrderID" Visible="False" />
                        <asp:BoundField DataField="CustomerCode" HeaderText="Customer Code" ReadOnly="True"
                            SortExpression="CustomerCode" />
                        <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" ReadOnly="True"
                            SortExpression="CustomerName" />
                        <asp:BoundField DataField="PurchaseOrderCode" HeaderText="PurchaseOrder Code" SortExpression="PurchaseOrderCode" />
                        <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                        <asp:TemplateField Visible="False"></asp:TemplateField>
                    </Columns>
                    <RowStyle BackColor="#EFF3FB" HorizontalAlign="Left" VerticalAlign="Top" />
                    <EditRowStyle BackColor="#2461BF" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="Left"
                        VerticalAlign="Top" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 21px; text-align: left;">
            <asp:Button ID="btnClose1" runat="server" Text="Close" OnClick="btnClose1_Click" ToolTip="ClosePOs" Font-Names="Verdana" /></td>
        </tr>
    </table>
    <table id="tblInvoices" style="width: 100%; font-size: 12pt;" runat="server" border="1">
        <tr>
            <td style="width: 100px; background-color: lightsteelblue; height: 5px;" valign="top">
                <span style="font-family: Verdana; vertical-align: top; text-align: left;">Invoice Details of &nbsp;<strong> </strong>
                    <asp:Label ID="lblCustomerName" runat="server" Text="lblCustomerName" Font-Bold="True"></asp:Label></span></td>
        </tr>
        <tr>
            <td  valign="top">
                <asp:GridView ID="grdInvoices" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    ForeColor="#333333" GridLines="None" Width="100%" HorizontalAlign="Left">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundField DataField="InvoiceID" HeaderText="Invoice ID" />
                        <asp:BoundField DataField="CustomerCode" HeaderText="Customer Code" />
                        <asp:BoundField DataField="PurchaseOrderCode" HeaderText="PO Code" />
                        <asp:BoundField DataField="InvoiceDate" HeaderText="Invoice Date" />
                        <asp:BoundField DataField="RateOfDuty" HeaderText="Rate Of Duty" />
                        <asp:BoundField DataField="CentralExciseDuty" HeaderText="Excisable Amount" />
                        <asp:BoundField DataField="InvoiceNetValue" HeaderText="Net Amount" />
                        <asp:BoundField DataField="InvoiceGrossValue" HeaderText="Gross Amount" />
                        <asp:TemplateField Visible="False"></asp:TemplateField>
                    </Columns>
                    <RowStyle BackColor="#EFF3FB" />
                    <EditRowStyle BackColor="#2461BF" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 26px; text-align: left">
                <asp:Button ID="btnClose2" runat="server" Text="Close" OnClick="btnClose2_Click" ToolTip="CloseInvoices" Font-Names="Verdana" /></td>
        </tr>
    </table>
</asp:Content>

