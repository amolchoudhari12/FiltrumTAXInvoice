<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true" CodeFile="ProductManagement.aspx.cs" Inherits="UI_ProductManagement" Title="Product Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%">
        <tr>
            <td style="width: 100px; height: 21px; text-align: center; vertical-align: top;" valign="top">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="10pt"
                    ForeColor="#00CC00" Text="Product is added successfully" Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td style="background-color: lightslategray; text-align: center;">
                <span style="font-family: Verdana"><strong>
                    <asp:Label ID="lblProductOperation" runat="server" Text="Add Product"></asp:Label></strong></span></td>
        </tr>
        <tr>
            <td style="height: 276px" >
                <table width="100%" border="1">
                    <tr>
                        <td style="width: 140px; text-align: left;">
                            <span style="font-size: 10pt; font-family: Verdana">
                            Product Code:</span></td>
                        <td style="width: 100px; text-align: left;">
                            <asp:TextBox ID="txtProductCode" runat="server" Width="238px" CausesValidation="True"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter code" ControlToValidate="txtProductCode" Width="158px"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td style="width: 140px; height: 21px; text-align: left;">
                            <span style="font-size: 10pt; font-family: Verdana">
                            Product Name:</span></td>
                        <td style="width: 100px; height: 21px; text-align: left;">
                            <asp:TextBox ID="txtProductName" runat="server" Width="238px" CausesValidation="True"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtProductName"
                                ErrorMessage="Please enter code" Width="158px"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td style="width: 140px; text-align: left;">
                            <span style="font-size: 10pt; font-family: Verdana">
                            Chapter Heading1:</span></td>
                        <td style="width: 100px; text-align: left;">
                            <asp:TextBox ID="txtChapterHead1" runat="server" Width="238px" CausesValidation="True"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtChapterHead1"
                                ErrorMessage="Please enter code" Width="167px"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td style="width: 140px; text-align: left;">
                            <span style="font-size: 10pt; font-family: Verdana">
                            Chapter Heading 2:</span></td>
                        <td style="width: 100px; text-align: left;">
                            <asp:TextBox ID="txtChapterHead2" runat="server" Width="238px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 140px; text-align: left;">
                            <span style="font-size: 10pt; font-family: Verdana">
                            Description:</span></td>
                        <td style="width: 100px; text-align: left;">
                            <asp:TextBox ID="txtDescription" runat="server" Height="104px" TextMode="MultiLine"
                                Width="238px"></asp:TextBox></td>
                    </tr>
                </table>
                <div style="z-index: 101; left: 100px; width: 100px; position: absolute; top: 100px;
                    height: 100px">
                </div>
                <div style="text-align: center">
                </div>
                <div style="text-align: center">
                    <table>
                        <tr>
                            <td style="width: 214px; text-align: right">
                <asp:Button ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click" /></td>
                            <td style="width: 100px; text-align: left">
                <asp:Button ID="btnCancel" runat="server" Text="Close" OnClick="btnCancel_Click" /></td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; text-align: center;">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
</asp:Content>

