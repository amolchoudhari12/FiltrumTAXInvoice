<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true" CodeFile="ViewCustomers.aspx.cs" Inherits="UI_ViewCustomers" Title="View Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="z-index: 101; left: 100px; width: 100px; position: absolute; top: 100px;
        height: 100px">
    </div>
    <table width="100%">
        <tr>
            <td style="width: 100px; text-align: center;">
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: center;">
            <table width="100%">
            <tr>
            <td style="width: 404px; background-color: lightblue" > 
             <asp:Label ID="lblViewCustomers" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="12pt"
                    Font-Underline="True" Text="View Customers" Width="219px"></asp:Label>
            </td>
            </tr>
            </table>
               </td>
        </tr>
        <tr>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td style="width: 100px">
                <asp:GridView ID="grdViewCustomers" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grdViewCustomers_SelectedIndexChanged" OnRowCommand="grdViewCustomers_RowCommand" Width="100%">
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundField DataField="CustomerCode" HeaderText="Customer Code" />
                        <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" >
                            <ItemStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="BillingAddress" HeaderText="Bill To" >
                            <ControlStyle Width="100px" />
                            <ItemStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ShippingAddress" HeaderText="Ship To" />
                        <asp:BoundField DataField="ECCNumber" HeaderText="ECC No." />
                        <asp:BoundField DataField="Country" HeaderText="Country" />
                        <asp:BoundField DataField="State" HeaderText="State" />
                        <asp:BoundField DataField="City" HeaderText="City" />
                        <asp:BoundField DataField="PinNumber" HeaderText="Pin Number" />
                        <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                        <asp:BoundField DataField="FaxNumber" HeaderText="Fax Number" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="IsDomestic" HeaderText="Is Domestic" />
                        <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                    </Columns>
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <EditRowStyle BackColor="#999999" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
         <tr>
            <td style="width: 100px; text-align: center;">
                <asp:Button ID="btnCancel" runat="server" Text="Close" OnClick="btnCancel_Click" />&nbsp;</td>
        </tr>
         <tr>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
</asp:Content>

