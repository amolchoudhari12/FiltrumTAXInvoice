<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true" CodeFile="ViewPurchaseOrders.aspx.cs" Inherits="UI_ViewPurchaseOrders" Title="View POs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 100px; height: 21px;">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: center;">
                <span style="font-family: Verdana"><strong>
                View Purchase Orders:</strong></span></td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
    <table style="width: 100%">
        <tr>
            <td style="width: 100px; text-align: left;">
                <asp:GridView ID="grdViewPOs" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    ForeColor="#333333" GridLines="None" 
                    ShowFooter="True" Width="105%" AllowPaging="True" AllowSorting="True" OnRowCommand="grdViewPOs_RowCommand" OnSelectedIndexChanged="grdViewPOs_SelectedIndexChanged" OnRowEditing="grdViewPOs_RowEditing" OnPageIndexChanging="grdViewPOs_PageIndexChanging" >
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundField DataField="CustomerCode" HeaderText="Customer Code" ReadOnly="True"
                            SortExpression="CustomerCode" />
                        <asp:BoundField DataField="PurchaseOrderID" HeaderText="Purchase OrderID" InsertVisible="False"
                            ReadOnly="True" SortExpression="PurchaseOrderID" />
                        <asp:BoundField DataField="PurchaseOrderCode" HeaderText="PurchaseOrder Code" SortExpression="PurchaseOrderCode" />
                        <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                        <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" ReadOnly="True"
                            SortExpression="CustomerName" />
                        <asp:CommandField SelectText="View POItems" ShowSelectButton="True">
                            <ControlStyle Width="90px" />
                        </asp:CommandField>
                        <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                        
                    </Columns>
                    <RowStyle BackColor="#EFF3FB" />
                    <EditRowStyle BackColor="#2461BF" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                    <PagerSettings PageButtonCount="2" />
                </asp:GridView>
                &nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: right">
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Close" /></td>
        </tr>
    </table>
    <table style="width: 100%">
        <tr>
            <td style="width: 100px; text-align: left; height: 21px; background-color: lightsteelblue;">
                <asp:Label ID="lblPOoperation" runat="server" Text="Modify Purchase Order" Visible="False" Width="214px" Font-Bold="True" Font-Names="Verdana"></asp:Label></td>
        </tr>
    </table>
    <table id="tblModifyPO" style="width: 100%" runat = "server">
        <tr>
            <td style="width: 100px; height: 193px">
                <table style="width: 100%">
                    <tr>
                        <td style="width: 100px">
                            <span style="font-size: 10pt; font-family: Verdana">Customer</span> Code:</td>
                        <td style="width: 100px">
                            <asp:DropDownList ID="comboCustomerCode" runat="server" AutoPostBack="True" CausesValidation="True"
                                DataSourceID="sqlCustomerCode" DataTextField="CustomerName" DataValueField="CustomerCode"
                                Width="238px">
                            </asp:DropDownList><span style="font-size: 10pt"> </span>
                            <asp:SqlDataSource ID="sqlCustomerCode" runat="server" ConnectionString="<%$ ConnectionStrings:FitrumInvoiceConnectionString %>"
                                SelectCommand="SELECT CustomerCode, CustomerFirstName + CustomerLastName AS CustomerName FROM tblCustomer">
                            </asp:SqlDataSource>
                        </td>
                        <td style="width: 112px">
                            <span style="font-size: 10pt; font-family: Verdana">PO Code:</span></td>
                        <td style="width: 100px">
                            <asp:TextBox ID="txtPOCode" runat="server" Width="235px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; height: 54px;">
                            <span style="font-size: 10pt; font-family: Verdana">PO ID:</span></td>
                        <td style="width: 100px; height: 54px;">
                            <asp:TextBox ID="txtPOID" runat="server" Width="238px"></asp:TextBox></td>
                        <td style="width: 112px; height: 54px;">
                            <span style="font-size: 10pt; font-family: Verdana">PO Date:</span></td>
                        <td style="width: 100px; height: 54px;">
                            <asp:TextBox ID="txtPODate" runat="server" Width="238px"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: left; vertical-align: top;">
                <asp:Button ID="btnModify" runat="server" Text="Modify" OnClick="btnModify_Click" />
                <asp:Button ID="btnCancelPO" runat="server" Text="Close" />
            </td>
        </tr>
    </table>
</asp:Content>

