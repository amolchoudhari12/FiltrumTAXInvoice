<%@ Page Language="C#" MasterPageFile="~/FiltrumMasterpage.master" AutoEventWireup="true" CodeFile="InvoiceManagement.aspx.cs" Inherits="UI_InvoiceManagement" Title="Invoice Management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
        <tr>
            <td style="height: 100px" valign="top">
                <table style="width: 100%" border="1">
                    <tr>
                        <td colspan="4" style="height: 23px">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" style="height: 25px; text-align: center; background-color: lightslategray;">
                            <span style="font-size: 14pt; font-family: Verdana; text-decoration: underline"><strong>
                                Filtrum Invoice</strong></span></td>
                    </tr>
                    <tr>
                        <td colspan="4" style="height: 21px">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" style="background-color: lightsteelblue">
                            <span style="font-family: Verdana"><strong>Customer Information:</strong></span></td>
                    </tr>
                    <tr>
                        <td style="width: 143px">
                            <span style="font-size: 10pt; font-family: Verdana">Invoice SR. No:</span></td>
                        <td style="width: 98px">
                            <asp:TextBox ID="txtSRNumber" runat="server" Width="215px" Enabled="False"></asp:TextBox></td>
                        <td style="width: 118px">
                        </td>
                        <td style="width: 98px">
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 143px; height: 20px;">
                            <span style="font-size: 10pt; font-family: Verdana">Customer Code:</span></td>
                        <td style="width: 98px; height: 20px;">
                            <asp:DropDownList ID="comboCustomerCode" runat="server" Width="222px" DataTextField="CustomerName" DataValueField="CustomerCode" OnSelectedIndexChanged="comboCustomerCode_SelectedIndexChanged" AutoPostBack="True" DataSourceID="sqlCustomerCode" AppendDataBoundItems="True">
                                <asp:ListItem Value="0">Select Customer</asp:ListItem>
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="sqlCustomerCode" runat="server" ConnectionString="<%$ ConnectionStrings:FitrumInvoiceConnectionString %>"
                                SelectCommand="SELECT CustomerCode, CustomerFirstName + CustomerLastName AS CustomerName FROM tblCustomer">
                            </asp:SqlDataSource>
                        </td>
                        <td style="width: 118px; height: 20px;">
                            <span style="font-size: 10pt; font-family: Verdana">Customer Name:</span></td>
                        <td style="width: 98px; height: 20px;">
                            <asp:TextBox ID="txtCustomerName" runat="server" Width="217px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 143px; height: 63px;">
                            <span style="font-size: 10pt; font-family: Verdana">Bill To:</span></td>
                        <td style="width: 98px; height: 63px;">
                            <asp:TextBox ID="txtBillTo" runat="server" TextMode="MultiLine" Width="300px" Height="93px"></asp:TextBox></td>
                        <td style="width: 118px; height: 63px;">
                            <span style="font-size: 10pt; font-family: Verdana">Ship To:</span></td>
                        <td style="width: 98px; height: 63px;">
                            <asp:TextBox ID="txtShipTo" runat="server" TextMode="MultiLine" Width="288px" Height="94px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 143px">
                            <span style="font-size: 10pt; font-family: Verdana">Country:</span></td>
                        <td style="width: 98px">
                            <asp:TextBox ID="txtCountry" runat="server" Width="217px"></asp:TextBox></td>
                        <td style="width: 118px">
                            <span style="font-size: 10pt; font-family: Verdana">State:</span></td>
                        <td style="width: 98px">
                            <asp:TextBox ID="txtState" runat="server" Width="217px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 143px">
                            <span style="font-size: 10pt; font-family: Verdana">City:</span></td>
                        <td style="width: 98px">
                            <asp:TextBox ID="txtCity" runat="server" Width="217px"></asp:TextBox></td>
                        <td style="width: 118px">
                            <span style="font-size: 10pt; font-family: Verdana">Pin:</span></td>
                        <td style="width: 98px">
                            <asp:TextBox ID="txtPin" runat="server" Width="217px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 143px; height: 12px">
                            <span style="font-size: 10pt; font-family: Verdana">Mode of Transport:</span></td>
                        <td style="width: 98px; height: 12px">
                            <asp:TextBox ID="txtTranseportMode" runat="server" Width="217px">By Road</asp:TextBox></td>
                        <td style="width: 118px; height: 12px">
                            <span style="font-size: 10pt; font-family: Verdana">Vehicle Number:</span></td>
                        <td style="width: 98px; height: 12px">
                            <asp:TextBox ID="txtVehicleNumber" runat="server" Width="217px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 143px">
                            <span style="font-size: 10pt; font-family: Verdana">Customer ECC No:</span></td>
                        <td style="width: 98px">
                            <asp:TextBox ID="txtECCNumber" runat="server" Width="217px"></asp:TextBox></td>
                        <td style="width: 118px">
                            <span style="font-size: 10pt; font-family: Verdana">Customer Type:</span></td>
                        <td style="width: 98px">
                            <asp:TextBox ID="txtCustomerType" runat="server" Width="217px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="4">
                        </td>
                    </tr>
                </table>
                <table style="width: 100%" border="1">
                    <tr>
                        <td colspan="4" style="background-color: lightsteelblue">
                            <span style="font-family: Verdana"><strong>PO/Product Information:</strong></span></td>
                    </tr>
                    <tr>
                        <td style="width: 138px; height: 21px">
                            <span style="font-size: 10pt; font-family: Verdana">PO Code:</span></td>
                        <td style="width: 85px; height: 21px">
                            <asp:DropDownList ID="comboPOCode" runat="server" Width="222px" DataTextField="PurchaseOrderCode" DataValueField="PurchaseOrderID" OnSelectedIndexChanged="comboPOCode_SelectedIndexChanged" AutoPostBack="True" DataSourceID="sqlPOCodes" AppendDataBoundItems="True">
                                <asp:ListItem Value="0">Select PO Code</asp:ListItem>
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="sqlPOCodes" runat="server" ConnectionString="<%$ ConnectionStrings:FitrumInvoiceConnectionString %>"
                                DeleteCommand="GetPurchaseOrdersOfCustomer" DeleteCommandType="StoredProcedure"
                                SelectCommand="GetPurchaseOrdersOfCustomer" SelectCommandType="StoredProcedure">
                                <DeleteParameters>
                                    <asp:Parameter Name="CustomerCode" Type="Int32" />
                                </DeleteParameters>
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="comboCustomerCode" Name="CustomerCode" PropertyName="SelectedValue"
                                        Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                        </td>
                        <td style="width: 121px; height: 21px">
                            <span style="font-size: 10pt; font-family: Verdana">PO Date:</span></td>
                        <td style="width: 100px; height: 21px">
                            <asp:TextBox ID="txtPODate" runat="server" Width="217px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 138px; height: 21px;">
                            <span style="font-size: 10pt; font-family: Verdana">Rate Of Duty:</span></td>
                        <td style="width: 85px; height: 21px;">
                            <asp:TextBox ID="txtRateOfDuty" runat="server" Width="217px"></asp:TextBox></td>
                        <td style="width: 121px; height: 21px;">
                            <span style="font-size: 10pt; font-family: Verdana">Selected Products:</span></td>
                        <td style="width: 100px; height: 21px;">
                            <asp:Label ID="Label3" runat="server" Font-Names="Verdana" Font-Size="10pt" Text="Product not selected Yet" Width="125px"></asp:Label>
                            <asp:Label ID="Label4" runat="server" Font-Names="Verdana" Font-Size="10pt" Height="30px"
                                Text="*" Visible="False" Width="32px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="4" style="text-align: center">
                            <asp:Label ID="lblCount" runat="server" Font-Bold="True" ForeColor="#FF3333" Text="Please select only 8 items"
                                Visible="False"></asp:Label></td>
                    </tr>
                </table>
                <table style="width: 100%">
                    <tr>
                        <td style="width: 100px; height: 20px; background-color: lightsteelblue; text-align: left;">
                            <span style="font-family: Verdana"><strong>PO Items Details:</strong></span></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; height: 227px; text-align: right;">
                            <asp:GridView ID="grdPOItems" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                ForeColor="#333333">
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="SRNO" HeaderText="Sr. No." >
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Select Product">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkSelectedItem" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    
                                    
                                     <asp:TemplateField HeaderText="Product Name">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtPOItemName" runat="server" ReadOnly="false"  Value='<%# Eval("ProductName") %>' MaxLength="20"></asp:TextBox>
                                        </ItemTemplate>
                                         <ControlStyle Width="60px" />
                                         <HeaderStyle HorizontalAlign="Left" Width="30px" />
                                    </asp:TemplateField>
                                    
                                    
                                     <asp:TemplateField HeaderText="Product Name" >
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtProductCode" runat="server" ReadOnly="false"  Value='<%# Eval("ProductCode") %>'>
                                           
                                           </asp:TextBox>
                                        </ItemTemplate>
                                         <ControlStyle Width="20px" />
                                         <HeaderStyle HorizontalAlign="Left" Width="20px" />
                                    </asp:TemplateField>
                                   
                                   
                                                                        
                                    
                                     <asp:TemplateField HeaderText="Customer Part No.">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtCustomerPartNo" runat="server" ReadOnly="false"  Value='<%# Eval("CustomerPartNo") %>'></asp:TextBox>
                                        </ItemTemplate>
                                         <ControlStyle Width="100px" />
                                         <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="FFTL Part No.">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtFFTLPartNo" runat="server" ReadOnly="false"  Value='<%# Eval("FFTLPartNo") %>'>
                                           
                                           </asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle Width="100px" />
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    
                                  
                                  
                                    <asp:TemplateField HeaderText="Package Description">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtPackageDescription" runat="server" MaxLength="12"></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle Width="140px" />
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Total Quantity">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            &nbsp;&nbsp;
                                            <asp:TextBox ID="txtQuntity" runat="server"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtQuntity"
                                                ErrorMessage="*" ValidationExpression="^[+]?\d+(\.\d+)?$"></asp:RegularExpressionValidator>
                                        </ItemTemplate>
                                        <ControlStyle Width="100px" />
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Unit">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtUnit" runat="server" ReadOnly="false"  Value='<%# Eval("UnitOfMesurement") %>'>
                                           
                                           </asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle Width="50px" />
                                        <HeaderStyle HorizontalAlign="Left" Width="50px" />
                                    </asp:TemplateField>
                                    
                                    
                                    
                                     <asp:TemplateField HeaderText="Price Rate">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtPriceRate" runat="server" ReadOnly="false"  Value='<%# Eval("PriceRate") %>' Width="155px"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPriceRate"
                                                ErrorMessage="*" ValidationExpression="^[+]?\d+(\.\d+)?$"></asp:RegularExpressionValidator>
                                        </ItemTemplate>
                                         <ControlStyle Width="80px" />
                                         <HeaderStyle HorizontalAlign="Left" Width="30px" />
                                    </asp:TemplateField>
                                   
                                    <asp:TemplateField HeaderText="Total">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtTotal" runat="server" ReadOnly="True"></asp:TextBox>
                                        </ItemTemplate>
                                        <ControlStyle Width="100px" />
                                        <HeaderStyle HorizontalAlign="Left" Width="50px" />
                                    </asp:TemplateField>
                                   
                                    <asp:TemplateField HeaderText="CH1"  >
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtChapterHeading1" runat="server" ReadOnly="false"  Value='<%# Eval("ChapterHeading1") %>' Visible = "true">
                                           
                                           </asp:TextBox>
                                        </ItemTemplate>
                                         <ControlStyle Width="20px" />
                                         <HeaderStyle HorizontalAlign="Left" Width="20px" />
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="CH2"  >
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtChapterHeading2" runat="server" ReadOnly="false"  Value='<%# Eval("ChapterHeading2") %>' Visible = "true">
                                           
                                           </asp:TextBox>
                                        </ItemTemplate>
                                         <ControlStyle Width="20px" />
                                         <HeaderStyle HorizontalAlign="Left" Width="20px" />
                                    </asp:TemplateField>
                                </Columns>
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" VerticalAlign="Top" />
                                <EditRowStyle BackColor="#999999" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" VerticalAlign="Top" />
                            </asp:GridView>
                            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="* : Indicates enter numeric values."
                                Width="207px"></asp:Label></td>
                    </tr>
                </table>
                <span style="font-size: 10pt; font-family: Verdana">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                            </td>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 100px; text-align: center">
                                        <asp:Button ID="btnTotal" runat="server" OnClick="btnTotal_Click" Text="Calculate Total" /></td>
                        </tr>
                        <tr>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 100px; text-align: right">
                                Net Amount:<asp:TextBox ID="txtNetAmount" runat="server" Width="230px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 100px">
                            </td>
                        </tr>
                    </table>
                </span>
                <table style="width: 100%" border="1">
                    <tr>
                        <td colspan="4" style="background-color: lightsteelblue">
                            <span style="font-family: Verdana"><strong>Duties:</strong></span></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; height: 26px;">
                            <asp:Label ID="lblExciseDuty" runat="server" Font-Names="Verdana" Font-Size="10pt"
                                Text="Excise Duty"></asp:Label></td>
                        <td style="width: 100px; height: 26px;">
                            <asp:TextBox ID="txtExciseDuty" runat="server" Width="173px"></asp:TextBox></td>
                        <td style="width: 100px; height: 26px;">
                            <asp:Label ID="lblCessDuty" runat="server" Font-Names="Verdana" Font-Size="10pt"
                                Text="Cess Duty:"></asp:Label></td>
                        <td style="width: 100px; height: 26px;">
                            <asp:TextBox ID="txtCessDuty" runat="server" Width="173px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; height: 15px;" valign="top">
                            <asp:Label ID="lblECessDuty" runat="server" Font-Names="Verdana" Font-Size="10pt"
                                Text="E.Cess Duty:"></asp:Label></td>
                        <td style="width: 100px; height: 15px;" valign="top">
                            <asp:TextBox ID="txtECessDuty" runat="server" Width="174px"></asp:TextBox></td>
                        <td style="width: 100px; height: 15px;" valign="top">
                            <asp:Label ID="lblSHCessDuty" runat="server" Font-Names="Verdana" Font-Size="10pt"
                                Text="S.H. Cess Duty:" Width="128px"></asp:Label></td>
                        <td style="width: 100px; height: 15px;" valign="top">
                            <asp:TextBox ID="txtSHCessDuty" runat="server" Width="173px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:Label ID="lblVATRate" runat="server" Font-Names="Verdana" Font-Size="10pt" Text="VAT Rate:"></asp:Label>
                            <asp:DropDownList ID="comboVATRate" runat="server" AutoPostBack="True" 
                                Width="65px" OnSelectedIndexChanged="comboVATRate_SelectedIndexChanged">
                                <asp:ListItem Value="-1">Select VAT</asp:ListItem>
                                <asp:ListItem Value="0"></asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
				<asp:ListItem>12.5</asp:ListItem>
				
                            </asp:DropDownList></td>
                        <td style="width: 100px">
                            <asp:TextBox ID="txtVATRate" runat="server" Width="173px"></asp:TextBox></td>
                        <td style="width: 100px">
                            <asp:Label ID="Label2" runat="server" Font-Names="Verdana" Font-Size="10pt" Text="Gross Without VAT:"
                                Width="154px"></asp:Label></td>
                        <td style="width: 100px">
                            <asp:TextBox ID="txtGrossWithoutVAT" runat="server" Width="173px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 100px; height: 21px">
                            <span style="font-size: 10pt; font-family: Verdana">Net Total:</span></td>
                        <td style="width: 100px; height: 21px">
                            <asp:TextBox ID="txtNetTotal" runat="server" Width="173px"></asp:TextBox></td>
                        <td style="width: 100px; height: 21px">
                            <span style="font-size: 10pt; font-family: Verdana">Gross Total:</span></td>
                        <td style="width: 100px; height: 21px">
                            <asp:TextBox ID="txtGrossValue" runat="server" Width="173px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="4" style="height: 8px">
                        </td>
                    </tr>
                </table>
                <table style="width: 100%" border="1">
                    <tr>
                        <td colspan="2" style="background-color: lightsteelblue; height: 4px;">
                            <span style="font-family: Verdana"><strong>Figures In Words:</strong></span></td>
                    </tr>
                    <tr>
                        <td style="width: 391px; height: 40px">
                            Total Central Excise duty payable:Rs( in words):</td>
                        <td style="width: 100px; height: 40px; text-align: center">
                            <asp:TextBox ID="txtExciseDutyInWords" runat="server" Height="53px" TextMode="MultiLine" Width="539px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 391px">
                            Amount of Invoice in Words : Rupees :</td>
                        <td style="width: 100px">
                            <asp:TextBox ID="txtAmountOfInvoiceInWords" runat="server" Height="53px" TextMode="MultiLine" Width="539px"></asp:TextBox></td>
                    </tr>
                </table>
                <div style="text-align: center">
                    &nbsp;</div>
            </td>
        </tr>
        <tr>
            <td style="height: 199px; text-align: center;">
                <table style="width: 100%" border="1">
                    <tr>
                        <td colspan="4" style="background-color: lightsteelblue; text-align: left;">
                            <span style="font-family: Verdana"><strong>Dates:</strong></span></td>
                    </tr>
                    <tr>
                        <td style="width: 119px; height: 21px">
                            Date of Invoice:</td>
                        <td style="width: 100px; height: 21px">
                            <asp:Label ID="lblDateOfInvoice" runat="server" Font-Names="Verdana" Font-Size="10pt" Text="Label"
                                Width="201px"></asp:Label></td>
                        <td style="width: 134px; height: 21px">
                            Time of Issue of Invoice:</td>
                        <td style="width: 100px; height: 21px">
                            <asp:Label ID="lblTimeOfInvoice" runat="server" Font-Names="Verdana" Font-Size="10pt" Text="Label"
                                Width="198px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 119px; height: 7px;">
                            Date of Removal:</td>
                        <td style="width: 100px; height: 7px;">
                            <asp:TextBox ID="txtDateOfRemoval" runat="server" Width="196px"></asp:TextBox></td>
                        <td style="width: 134px; height: 7px;">
                            Time of Removal:</td>
                        <td style="width: 100px; height: 7px;">
                            <asp:TextBox ID="txtTimeOfRemoval" runat="server" Width="196px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="4">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                        </td>
                    </tr>
                </table>
                    <table style="text-align: center">
                        <tr>
                            <td style="width: 100px">
                                </td>
                            <td style="width: 100px">
                                </td>
                            <td style="width: 100px">
                                </td>
                        </tr>
                        <tr>
                            <td style="width: 100px">
                                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td>
                            <td style="width: 100px">
                                <asp:Button ID="btnPrint" runat="server" Text="Print" OnClick="btnPrint_Click" /></td>
                            <td style="width: 100px">
                                <asp:Button ID="btnCancel" runat="server" Text="Close" OnClick="btnCancel_Click" /></td>
                        </tr>
                    </table>
                <asp:Label ID="lblSaveSuccess" runat="server" Font-Names="Verdana" Font-Size="10pt"
                    ForeColor="#009900" Text="Invoice Saved Successfully !" Visible="False"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

