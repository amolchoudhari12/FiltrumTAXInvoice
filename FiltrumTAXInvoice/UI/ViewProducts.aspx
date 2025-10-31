<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true" CodeFile="ViewProducts.aspx.cs" Inherits="UI_ViewProducts" Title="View Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <table width="100%">
        <tr>
            <td style="width: 100px; text-align: center; background-color: lightslategray;">
             <asp:Label ID="lblViewProducts" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="12pt"
                    Font-Underline="True" Text="View Products" Width="414px"></asp:Label></td>
        </tr>
        <tr>
            <td >
                &nbsp;<asp:GridView ID="grdViewProduct" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    ForeColor="#333333" GridLines="None"  Width="100%" OnRowCommand="grdViewProduct_RowCommand" ShowFooter="True">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundField DataField="ProductCode" HeaderText="Product Code" >
                            <ControlStyle Width="75px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ProductName" HeaderText="Product Name" >
                            <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ChapterHeading1" HeaderText="Chapter Heading 1" >
                            <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ChapterHeading2" HeaderText="Chapter Heading 2" >
                            <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Description" HeaderText="Description" >
                            <ControlStyle Width="100px" />
                        </asp:BoundField>
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
               </td>
        </tr>
         <tr>
            <td style="width: 100px; text-align: center;">
                &nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="Close" OnClick="btnCancel_Click" /></td>
        </tr>
         <tr>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
</asp:Content>

