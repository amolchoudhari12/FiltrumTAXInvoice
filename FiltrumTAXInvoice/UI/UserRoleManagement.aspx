<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true" CodeFile="UserRoleManagement.aspx.cs" Inherits="UI_UserRoleManagement" Title="User Role Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function TABLE1_onclick() {

}

// ]]>
</script>

    <table width="100%">
        <tr>
            <td style="vertical-align: top; text-align: center">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Text="Label"
                    Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td style="background-color: slategray" >
                <asp:Label ID="lblUserOperation" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Underline="True"
                    Text="Add User/ Assign Roles to User"></asp:Label></td>
        </tr>
        <tr>
            <td style="text-align: center; height: 725px;" valign="top" >
                <table border="1" style="width: 122%; text-align: left;">
                    <tr>
                        <td style="height: 26px; width: 270px;" >
                            <span style="font-size: 10pt; font-family: Verdana">Select User Name:</span></td>
                        <td style="height: 26px"  >
                            <asp:DropDownList ID="comboUserName" runat="server" OnSelectedIndexChanged="comboUserName_SelectedIndexChanged"
                                Width="219px" DataTextField="UserName" DataValueField="UserName" Height="29px" AppendDataBoundItems="True" AutoPostBack="True">
                                <asp:ListItem Value="0">Select User</asp:ListItem>
                            </asp:DropDownList>&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 270px; height: 29px;"  >
                            <span style="font-size: 10pt; font-family: Verdana">Enter User Name:</span></td>
                        <td style="height: 29px"  >
                            <asp:TextBox ID="txtUserName" runat="server" Width="208px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 270px"  >
                            <span style="font-size: 10pt; font-family: Verdana">Enter Password:</span></td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server" Width="208px" TextMode="Password"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 270px"  >
                            <span style="font-size: 10pt; font-family: Verdana">
                            Confirm Password:</span></td>
                        <td  >
                            <asp:TextBox ID="txtConfirmPassword" runat="server" Width="208px" TextMode="Password"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword"
                                ControlToValidate="txtConfirmPassword" ErrorMessage="Password No Match"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td style="width: 270px"  >
                            <span style="font-size: 10pt; font-family: Verdana">
                            Select Dept.:</span></td>
                        <td  >
                            <asp:DropDownList ID="comboDepartment" runat="server" Width="214px">
                                <asp:ListItem Value="0">Accounts</asp:ListItem>
                                <asp:ListItem Value="1">HRD</asp:ListItem>
                                <asp:ListItem Value="2">Plant Engg.</asp:ListItem>
                                <asp:ListItem Value="3">PPE &amp; QA</asp:ListItem>
                                <asp:ListItem Value="4">Production</asp:ListItem>
                                <asp:ListItem Value="5">Store &amp; Material</asp:ListItem>
                                <asp:ListItem Value="6">Administration</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                    <td colspan="2" style="height: 23px"> </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="background-color: slategray"  >
                            &nbsp;<span style="font-size: 10pt; font-family: Verdana"><strong>Select following rights to this user:</strong></span></td>
                       
                    </tr>
        
       
                </table>
    <table style="width: 100%" border="1">
        <tr>
            <td style="width: 314px; vertical-align: top; text-align: left;" valign="top">
                            <asp:CheckBox ID="chkCustometMgt" runat="server" Font-Names="Verdana" Font-Size="9pt"
                                Text="Customer Management System" Width="268px" AutoPostBack="True" OnCheckedChanged="chkCustometMgt_CheckedChanged" /></td>
            <td style="vertical-align: top; text-align: left" >
                            <asp:CheckBoxList ID="chkCustomerOptions" runat="server" Width="173px" Font-Names="Verdana" Font-Size="10pt">
                                <asp:ListItem Value="Add">Customer Add</asp:ListItem>
                                <asp:ListItem Value="Modify">Customer Modify</asp:ListItem>
                                <asp:ListItem Value="View">View Customers</asp:ListItem>
                            </asp:CheckBoxList></td>
        </tr>
        <tr>
            <td style="width: 314px; vertical-align: top; text-align: left;" valign="top" >
                            <asp:CheckBox ID="chkProductMgt" runat="server" Font-Names="Verdana" Font-Size="9pt"
                                Text="Product Management System" Width="216px" AutoPostBack="True" OnCheckedChanged="chkProductMgt_CheckedChanged" /></td>
            <td style="vertical-align: top; text-align: left" ><asp:CheckBoxList ID="chkProductOptions" runat="server" Width="173px" Font-Names="Verdana" Font-Size="10pt">
                <asp:ListItem Value="Add">Product Add</asp:ListItem>
                <asp:ListItem Value="Modify">Product Modify</asp:ListItem>
                <asp:ListItem Value="View">View Product</asp:ListItem>
            </asp:CheckBoxList></td>
        </tr>
        <tr>
            <td style="width: 314px; vertical-align: top; text-align: left;" valign="top" >
                            <asp:CheckBox ID="chkPOMgt" runat="server" Font-Names="Verdana" Font-Size="9pt" Text="Purchase Order Management"
                                Width="217px" AutoPostBack="True" OnCheckedChanged="chkPOMgt_CheckedChanged" /></td>
            <td style="vertical-align: top; text-align: left" ><asp:CheckBoxList ID="chkPOOptions" runat="server" Width="197px" Font-Names="Verdana" Font-Size="10pt">
                <asp:ListItem Value="Add">Purchase Order Add</asp:ListItem>
                <asp:ListItem Value="Modify">Purchase Order Modify</asp:ListItem>
                <asp:ListItem Value="View">View Purchase Order</asp:ListItem>
            </asp:CheckBoxList></td>
        </tr>
       
        <tr>
            <td style="width: 314px; vertical-align: top; text-align: left;" valign="top" >
                            <asp:CheckBox ID="chkInvoice" runat="server" Font-Names="Verdana" Font-Size="9pt"
                                Text="Invoice Management" Width="215px" AutoPostBack="True" OnCheckedChanged="chkInvoice_CheckedChanged" /></td>
            <td style="vertical-align: top; text-align: left" valign="top" ><asp:CheckBoxList ID="chkInvoiceOptions" runat="server" Width="173px" Font-Names="Verdana" Font-Size="10pt">
                <asp:ListItem Value="Add">Invoice Add</asp:ListItem>
                <asp:ListItem Value="View">View Invoice</asp:ListItem>
            </asp:CheckBoxList></td>
        </tr>
        <tr>
            <td style="vertical-align: top; width: 314px; height: 22px; text-align: left" valign="top">
                <asp:CheckBox ID="chkUserRoleMgt" runat="server" Font-Names="Verdana" Font-Size="9pt"
                                Text="User/Role Management" Width="215px" EnableTheming="False" /></td>
            <td style="vertical-align: top; height: 22px; text-align: left" valign="top">
            </td>
        </tr>
        <tr>
            <td style="width: 270px; vertical-align: top; height: 23px; background-color: slategray; text-align: left;" colspan="2">
                <strong>
                            Reports:</strong></td>
        </tr>
        
         <tr>
             <td colspan="2" style="vertical-align: top; text-align: left; height: 23px;">
                            <asp:CheckBox ID="chkCustomerReport" runat="server" Font-Names="Verdana" Font-Size="9pt"
                                Text="Customer Details" Width="216px" /></td>
        </tr>
        
         <tr>
            <td style="vertical-align: top; text-align: left;" colspan="2" >
                            <asp:CheckBox ID="chkProductReport" runat="server" Font-Names="Verdana" Font-Size="9pt"
                                 Text="Product Details"  Width="214px" /></td>
        </tr>
        
         <tr>
            <td style="vertical-align: top; text-align: left;" colspan="2" >
                            <asp:CheckBox ID="ckhPODetailsReport" runat="server" Font-Names="Verdana" Font-Size="9pt"
                                 Text="Puchase Order Details"  Width="214px" /></td>
        </tr>
        
         <tr>
            <td style="vertical-align: top; text-align: left;" colspan="2" >
                            <asp:CheckBox ID="chkInvoiceDetails" runat="server" Font-Names="Verdana" Font-Size="9pt"
                                 Text="Invoice Details" Width="214px" /></td>
        </tr>
    </table>
        &nbsp;&nbsp;&nbsp;
               
               
                
       
         
       
    </table>
    <table style="width: 100%">
        <tr>
            <td style="vertical-align: top; text-align: center;" colspan="3">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnClose" runat="server" Text="Close" OnClick="btnClose_Click" /></td>
        </tr>
    </table>
</asp:Content>

