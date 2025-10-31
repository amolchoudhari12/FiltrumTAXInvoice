<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true" CodeFile="CustomerManagement.aspx.cs" Inherits="UI_CustomerManagement" Title="Customer Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<table width="100%">
<tr>
<td style="text-align: center;  height: 20px;">
    <span style="font-family: Verdana; text-decoration: underline"><strong>
        <asp:Label ID="lblCustOperation" runat="server" Text="Add Customer" ForeColor="#000040"></asp:Label></strong></span></td>
</tr>

<tr>
<td style="height: 28px; background-color: lavender; text-align: center;">
 <table width="100%" border="1" style="border-right: silver thin ridge; border-top: silver thin ridge; border-left: silver thin ridge; border-bottom: silver thin ridge">
    
    <tr>
            <td colspan="6" style="height: 23px">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="10pt"
        ForeColor="#00CC00" Text="Customer is added Successfully"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 158px; text-align: left; height: 18px;">
                <span style="font-size: 10pt; font-family: Verdana">Customer Code:</span></td>
            <td colspan="2" style="width: 142px; height: 18px" valign="middle">
                <asp:TextBox ID="txtCustomerCode" runat="server" Width="218px" ReadOnly="True"></asp:TextBox><br />
                &nbsp;</td>
            <td style="width: 206px; text-align: left; height: 18px;">
                <span style="font-size: 10pt; font-family: Verdana">
                First Name:</span></td>
            <td style="height: 18px; width: 234px; text-align: left;" colspan="2" valign="top">
                <asp:TextBox ID="txtCustomerFirstName" runat="server" Width="215px" CausesValidation="True"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCustomerFirstName"
                    ErrorMessage="*"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 158px; text-align: left; height: 28px;">
                <span style="font-size: 10pt; font-family: Verdana">
                Last Name:</span></td>
            <td colspan="2" style="width: 142px; height: 28px; text-align: left;" valign="top">
                <asp:TextBox ID="txtCutomerLastName" runat="server" Width="215px"></asp:TextBox></td>
            <td style="width: 206px; text-align: left; height: 28px;">
                <span style="font-size: 10pt; font-family: Verdana">
                ECC Code:</span></td>
            <td colspan="2" style="height: 28px; width: 234px; text-align: left;" valign="top">
                <asp:TextBox ID="txtEccCode" runat="server" Width="215px"></asp:TextBox>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 158px; text-align: left; height: 103px;">
                <span style="font-size: 10pt; font-family: Verdana">
                Billing Address:</span></td>
            <td colspan="2" style="width: 142px; height: 103px; text-align: left;" valign="top">
                <asp:TextBox ID="txtBillingAddress" runat="server" Height="115px" TextMode="MultiLine" Width="215px"></asp:TextBox><asp:RequiredFieldValidator
                    ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtBillingAddress"
                    ErrorMessage="*"></asp:RequiredFieldValidator></td>
            <td style="width: 206px; text-align: left; height: 103px;">
                <span style="font-size: 10pt; font-family: Verdana">
                Shipping Address:</span></td>
            <td colspan="2" style="width: 234px; height: 103px; text-align: left" valign="top">
                <asp:TextBox ID="txtShippingAddress" runat="server" Height="118px" TextMode="MultiLine" Width="215px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtShippingAddress"
                    ErrorMessage="*"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 158px; text-align: left;" valign="top">
                <span style="font-size: 10pt; font-family: Verdana">
                    <br />
                City:</span></td>
            <td colspan="2" style="width: 142px; text-align: left;" valign="top">
                <asp:TextBox ID="txtCity" runat="server" Width="215px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCity"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            <td style="width: 206px; text-align: left;">
                <span style="font-size: 10pt; font-family: Verdana">
                State:</span></td>
            <td colspan="2" style="width: 234px; text-align: left">
                <asp:TextBox ID="txtState" runat="server" Width="215px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtState"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td style="width: 158px; height: 26px; text-align: left;">
                <span style="font-size: 10pt; font-family: Verdana">
                Country:</span></td>
            <td colspan="2" style="width: 142px; height: 26px; text-align: left;" valign="top">
                <asp:DropDownList ID="comboCountry" runat="server" Width="221px">
                    <asp:ListItem Value="3">Australia</asp:ListItem>
                    <asp:ListItem Value="4">China</asp:ListItem>
                    <asp:ListItem Value="0">India</asp:ListItem>
                    <asp:ListItem Value="6">Maxico</asp:ListItem>
                    <asp:ListItem Value="5">Singhapur</asp:ListItem>
                    <asp:ListItem Value="7">Srilanka</asp:ListItem>
                    <asp:ListItem Value="1">USA</asp:ListItem>
                    <asp:ListItem Value="2">UK</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="comboCountry"
                    ErrorMessage="*"></asp:RequiredFieldValidator></td>
            <td style="width: 206px; height: 26px; text-align: left;">
                <span style="font-size: 10pt; font-family: Verdana">
                PinCode:</span></td>
            <td colspan="2" style="height: 26px; width: 234px; text-align: left;" valign="top">
                <asp:TextBox ID="txtPinCode" runat="server" Width="192px" CausesValidation="True"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPinCode"
                    ErrorMessage="Enter Valid Value" ValidationExpression="^[+]?\d+(\.\d+)?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 158px; text-align: left; height: 35px;">
                <span style="font-size: 10pt; font-family: Verdana">
                Phone Number:</span></td>
            <td colspan="2" style="width: 142px; height: 35px; text-align: left;" valign="top">
                <asp:TextBox ID="txtPhoneNumber" runat="server" Width="215px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtPhoneNumber"
                    ErrorMessage="Enter Valid Value" ValidationExpression="^[+]?\d+(\.\d+)?$"></asp:RegularExpressionValidator></td>
            <td style="width: 206px; text-align: left; height: 35px;">
                <span style="font-size: 10pt; font-family: Verdana">
                FAX Number:</span></td>
            <td colspan="2" style="width: 234px; height: 35px; text-align: left" valign="top">
                <asp:TextBox ID="txtFAXNumber" runat="server" Width="215px" CausesValidation="True"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtFAXNumber"
                    ErrorMessage="Enter Valid Value" ValidationExpression="^[+]?\d+(\.\d+)?$"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="width: 158px; text-align: left;">
                <span style="font-size: 10pt; font-family: Verdana">
                Email:</span></td>
            <td colspan="2" style="width: 142px; text-align: left;" valign="top">
                <asp:TextBox ID="txtEmail" runat="server" Width="215px" CausesValidation="True"></asp:TextBox><br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Enter valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
            <td style="width: 206px; text-align: left;">
                <span style="font-size: 10pt; font-family: Verdana">
                Type:</span></td>
            <td colspan="2" style="text-align: left; width: 234px;" valign="top">
                <asp:RadioButtonList ID="rdoListType" runat="server" Width="165px">
                    <asp:ListItem>Domestic</asp:ListItem>
                    <asp:ListItem>Foreign</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="rdoListType"
                    ErrorMessage="*"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 158px; height: 25px; text-align: left;">
                <span style="font-size: 10pt; font-family: Verdana">Cess Duty:</span></td>
            <td colspan="2" style="width: 142px; height: 25px; text-align: left;" valign="top">
                <asp:TextBox ID="txtCessDuty" runat="server" Width="120px" CausesValidation="True"></asp:TextBox>%
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtCessDuty"
                    ErrorMessage="Enter valid value" MaximumValue="99.99" MinimumValue="0.0001" Type="Double"
                    Width="101px"></asp:RangeValidator></td>
            <td style="width: 206px; height: 25px; text-align: left;">
                <span style="font-size: 10pt; font-family: Verdana">
                Excise Duty:</span></td>
            <td colspan="2" style="height: 25px; text-align: left; width: 234px;" valign="top">
                <asp:TextBox ID="txtExciseDuty" runat="server" Width="120px"></asp:TextBox>%
                <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtExciseDuty"
                    ErrorMessage="Enter valid value" MaximumValue="99.99" MinimumValue="0.0001" Type="Double"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td style="width: 158px; text-align: left; height: 47px;">
                <span style="font-size: 10pt; font-family: Verdana">
                E. Cess Duty:</span></td>
            <td colspan="2" style="width: 142px; text-align: left; height: 47px;" valign="top">
                <asp:TextBox ID="txtECessDuty" runat="server" Width="120px"></asp:TextBox>%
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtECessDuty"
                    ErrorMessage="Enter valid value" MaximumValue="99.99" MinimumValue="0.001" Type="Double"></asp:RangeValidator></td>
            <td style="width: 206px; text-align: left; height: 47px;">
                <span style="font-size: 10pt; font-family: Verdana">
                S.H. Cess Duty:</span></td>
            <td colspan="2" style="text-align: left; width: 234px; height: 47px;" valign="top">
                <asp:TextBox ID="txtSHDuty" runat="server" Width="120px"></asp:TextBox>%
                <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txtSHDuty"
                    ErrorMessage="Enter valid value" MaximumValue="99.99" MinimumValue="0.0001" Type="Double"></asp:RangeValidator></td>
        </tr>
        
        <tr>
            <td style="width: 158px; text-align: left; height: 15px;">
                <span style="font-size: 10pt; font-family: Verdana">
                VAT Rate:</span></td>
            <td colspan="2" style="width: 142px; height: 15px; text-align: left;" valign="top">
                <asp:TextBox ID="txtVATRate" runat="server" Width="120px"></asp:TextBox>%
                <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtVATRate"
                    ErrorMessage="Enter valid value" MaximumValue="99.99" MinimumValue="0.0001" Type="Double"></asp:RangeValidator></td>
            <td style="width: 206px; text-align: left; height: 15px;">
                <span style="font-size: 10pt; font-family: Verdana">
                Description:</span></td>
            <td colspan="2" style="height: 15px; text-align: left; width: 234px;" valign="top">
                <asp:TextBox ID="txtDescription" runat="server" Width="215px" Height="39px"></asp:TextBox></td>
        </tr>
        
       
       
       
       
    </table>
    <asp:Label ID="lblErrorSummary" runat="server" ForeColor="#FF3333" Text="* Indicates manadatory fields"></asp:Label></td></tr>

<tr>
<td style="text-align: center; height: 20px; background-color: lavender;">
    &nbsp;<asp:Button ID="btnADD" runat="server" Text="ADD" Font-Names="Verdana" Font-Size="10pt" OnClick="btnADD_Click" Width="74px" />
                &nbsp;&nbsp; &nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="Close" Font-Names="Verdana" Font-Size="10pt" OnClick="btnCancel_Click" Width="82px" CausesValidation="False" />&nbsp;
</td></tr>

<tr>
<td style="background-color: lavender; height: 5px;"></td></tr>


</table>
   
</asp:Content>

