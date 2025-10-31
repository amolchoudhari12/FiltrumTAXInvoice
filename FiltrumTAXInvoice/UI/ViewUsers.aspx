<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true" CodeFile="ViewUsers.aspx.cs" Inherits="UI_ViewUsers" Title="View Users" %>
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
             <asp:Label ID="lblViewUsers" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="12pt"
                    Font-Underline="True" Text="View Users" Width="219px"></asp:Label>
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
                            &nbsp;<asp:GridView ID="grdViewUsers" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    ForeColor="#333333" GridLines="None"   Width="119%" OnRowCommand="grdViewUsers_RowCommand">
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundField DataField="UserName" HeaderText="User Name" >
                            <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Password" HeaderText="Password" >
                            <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Department" HeaderText="Department" >
                            <ControlStyle Width="150px" />
                        </asp:BoundField>
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

