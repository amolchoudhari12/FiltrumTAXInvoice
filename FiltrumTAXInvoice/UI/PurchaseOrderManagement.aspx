<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true"  CodeFile="PurchaseOrderManagement.aspx.cs" Inherits="UI_PurchaseOrderManagement" Title="PO Management"  %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
<script type="text/javascript" >
function OnClick()
{
if( divCalendar.style.display == "none")
divCalendar.style.display = "";
else
divCalendar.style.display = "none";
}
</script>
 

    <table style="width: 100%; height: 100%" >
        <tr>
            <td style="width: 100px; text-align: center; height: 21px; background-color: lightslategray;">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Underline="True"
                    Text="Add Puchase Order" Width="189px"></asp:Label></td>
        </tr>
        <tr>
            <td style="height: 177px; text-align: center" valign="top" >
                <table style="width: 100%; height: 74%; border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid;" border="1">
                    <tr>
                        <td colspan="4" style="height: 152px; text-align: left">
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 100px" valign="top">
                                        <span style="font-size: 10pt; font-family: Verdana">Customer</span> Code:</td>
                                    <td style="width: 104px" valign="middle">
                            <asp:DropDownList ID="comboCustomerCode" runat="server" Width="238px" OnSelectedIndexChanged="comboCustomerCode_SelectedIndexChanged" AutoPostBack="True" CausesValidation="True" DataSourceID="sqlCustomerCode" DataTextField="CustomerName" DataValueField="CustomerCode" AppendDataBoundItems="True" >
                                <asp:ListItem Value="0">Select Customer</asp:ListItem>
                            </asp:DropDownList>
                                        <asp:SqlDataSource ID="sqlCustomerCode" runat="server" ConnectionString="<%$ ConnectionStrings:FitrumInvoiceConnectionString %>"
                                            SelectCommand="SELECT CustomerCode, CustomerFirstName + CustomerLastName AS CustomerName FROM tblCustomer">
                                        </asp:SqlDataSource>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="comboCustomerCode"
                                            ErrorMessage="Select Customer"></asp:RequiredFieldValidator>
                                    </td>
                                    <td style="width: 100px" valign="top">
                                        <span style="font-size: 10pt; font-family: Verdana">
                            Customer Name:</span></td>
                                    <td style="width: 100px" valign="top">
                            <asp:TextBox ID="txtCustomerName" runat="server" Width="235px"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px" valign="top">
                                        <span style="font-size: 10pt; font-family: Verdana">
                            Bill To:</span></td>
                                    <td style="width: 104px" valign="top">
                            <asp:TextBox ID="txtBillTo" runat="server" Height="61px" TextMode="MultiLine" Width="232px" TabIndex="2"></asp:TextBox></td>
                                    <td style="width: 100px" valign="top">
                                        <span style="font-size: 10pt; font-family: Verdana">
                            Ship To:</span></td>
                                    <td style="width: 100px" valign="top">
                            <asp:TextBox ID="txtShipTo" runat="server" Height="61px" TextMode="MultiLine" Width="239px"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 100px" valign="top">
                                        <span style="font-size: 10pt; font-family: Verdana">PO Code: </span>
                                    </td>
                                    <td style="width: 104px" valign="top">
                            <asp:TextBox ID="txtPOCode" runat="server" Width="231px" CausesValidation="True" TabIndex="1"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvPOCode" runat="server" ControlToValidate="txtPOCode"
                                            ErrorMessage="Enter PO Code" EnableClientScript="False" Visible="False"></asp:RequiredFieldValidator></td>
                                    <td style="width: 100px" valign="top">
                                        <span style="font-size: 10pt; font-family: Verdana">
                            PO Date:</span></td>
                                    <td style="width: 100px; text-align: left;" valign="top">
                                        <asp:TextBox ID="txtPODate" runat="server"></asp:TextBox>
                                        <asp:Button ID="btnOpenCalender" runat="server" OnClick="btnOpenCalender_Click" Text="......" />
                                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
                                            BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                                            Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged"
                                            Width="220px" Visible="False" VisibleDate="2008-04-05">
                                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                            <WeekendDayStyle BackColor="#CCCCFF" />
                                            <OtherMonthDayStyle ForeColor="#999999" />
                                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" BorderStyle="None" />
                                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                                                Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                        </asp:Calendar>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                   
                    
                </table>
                <asp:Button ID="btnAddPO" runat="server" OnClick="btnAddPO_Click" Text="Add PO" />
                &nbsp; &nbsp; &nbsp;<strong><span style="font-size: 11pt">&nbsp;</span></strong>
                &nbsp; &nbsp;
            </td>
        </tr>
    </table>
    &nbsp;
    <table style="width: 100%">
        <tr>
            <td style="width: 100px; background-color: lightsteelblue; text-align: left;">
                <strong><span style="font-size: 11pt; font-family: Verdana;">
                            Add PO&nbsp; Items:&nbsp;</span></strong></td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
    <table style="width: 100%">
        <tr>
            <td style="width: 386px; height: 27px;">
                <span style="font-size: 10pt; font-family: Verdana"><strong>
                Enter Number of Items/rows to be
                                            entered :&nbsp;</strong></span></td>
            <td style="height: 27px; text-align: left;" colspan="2">
                            <asp:TextBox ID="txtNumberOfRows" runat="server" Width="198px"></asp:TextBox>
                &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp;&nbsp;
                            <asp:Button ID="btnCreateRows" runat="server" Text="Create rows" Width="96px" Font-Names="Verdana" Font-Size="10pt" OnClick="btnCreateRows_Click" />
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtNumberOfRows"
                    ErrorMessage="Enter number between 1 to 99" MaximumValue="99" MinimumValue="1"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td colspan="3" style="height: 21px">
            </td>
        </tr>
    </table>
    <table style="width: 100%">
        <tr>
            <td style="width: 100px">
                            <asp:GridView ID="grdViewPOItems" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                ForeColor="#333333" GridLines="Vertical" Height="133px" Width="195px"    >
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Product Name">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="comboProductName" runat="server" AutoPostBack="True" 
                                                Width="120px" OnSelectedIndexChanged="comboProductName_SelectedIndexChanged" >
                                            </asp:DropDownList>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Product Code">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtProductCode" runat="server" ReadOnly="True"></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle Width="60px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Customer Part No.">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtCustomerPartNo" runat="server"></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle Width="120px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="FFTL Part No.">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtFFTLPartNo" runat="server"></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle Width="120px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Quantity">
                                        <ItemTemplate>
                                            &nbsp;<asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtQuantity"
                                                ErrorMessage="*" ValidationExpression="^[+]?\d+(\.\d+)?$"></asp:RegularExpressionValidator>
                                        </ItemTemplate>
                                        <ControlStyle Width="110px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Unit">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="comboUnit" runat="server" Width="127px">
                                                <asp:ListItem Value="Nos">Nos</asp:ListItem>
                                                <asp:ListItem Value="Kgs">Kgs</asp:ListItem>
                                            </asp:DropDownList>
                                        </ItemTemplate>
                                        <ControlStyle Width="80px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Price Rate">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtPriceRate" runat="server"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPriceRate"
                                                ErrorMessage="*" ValidationExpression="^[+]?\d+(\.\d+)?$"></asp:RegularExpressionValidator>
                                        </ItemTemplate>
                                        <ControlStyle Width="100px" />
                                    </asp:TemplateField>
                                </Columns>
                                <RowStyle BackColor="#EFF3FB" HorizontalAlign="Left" VerticalAlign="Top" />
                                <EditRowStyle BackColor="#2461BF" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <AlternatingRowStyle BackColor="White" />
                            </asp:GridView>
                &nbsp;&nbsp;
                <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="* : Indicates Enter numeric fields"
                    Width="238px"></asp:Label></td>
        </tr>
    </table>
    <table style="width: 100%">
        <tr>
            <td style="width: 100px; height: 33px;">
            </td>
            <td style="width: 100px; height: 33px; text-align: center;">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="10pt"
                    ForeColor="#006633" Text="Items added Successfully !" Visible="False"></asp:Label>&nbsp;
            </td>
            <td style="width: 100px; height: 33px;">
            </td>
        </tr>
        <tr>
            <td style="height: 26px; text-align: center;" colspan="3">
                                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />&nbsp;
                            <asp:Button ID="btnCancel" runat="server" Text="Close" OnClick="btnCancel_Click" /></td>
        </tr>
        <tr>
            <td style="background-color: lightsteelblue;" colspan="3">
            </td>
        </tr>
    </table>
</asp:Content>

