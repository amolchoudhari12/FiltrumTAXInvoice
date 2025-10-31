<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintInvoice_Part1.aspx.cs" Inherits="Reports_PrintInvoice_Part1" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;&nbsp;
    
    </div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td style="width: 99px" valign="top">
                   
                    
                   <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="800px" Height="1000px" ZoomMode="PageWidth" Font-Names="Verdana" Font-Size="8pt" ShowToolBar="False" SizeToReportContent="True">
                       <LocalReport ReportPath="App_Code\Reports\PrintInvoice_Part1.rdlc">
                           <DataSources>
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="Invoice" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="POItem" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="POItem1" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="Invoice1" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="Invoice2" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="Invoice3" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="POItem2" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource3" Name="Duties" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource3" Name="Duties1" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="POItem3" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="Invoice4" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="Invoice5" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource3" Name="Duties2" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="Invoice6" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource4" Name="POItem4" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource5" Name="POItem5" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource6" Name="POItem6" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource7" Name="POItem7" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource4" Name="POItem8" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource5" Name="POItem9" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource6" Name="POItem10" />
                               <rsweb:ReportDataSource DataSourceId="ObjectDataSource7" Name="POItem11" />
                           </DataSources>
                       </LocalReport>
                   </rsweb:ReportViewer>
                    <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="----->" /><br />
                    <strong>Page 1 of 2</strong><br />
                    <asp:ObjectDataSource ID="ObjectDataSource7" runat="server" SelectMethod="GetPOItems4"
                        TypeName="FiltrumTAXInvoice.SessionData"></asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" SelectMethod="GetPOItems3"
                        TypeName="FiltrumTAXInvoice.SessionData"></asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" SelectMethod="GetPOItems2"
                        TypeName="FiltrumTAXInvoice.SessionData"></asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetPOItems1"
                        TypeName="FiltrumTAXInvoice.SessionData"></asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetDuties"
                        TypeName="FiltrumTAXInvoice.SessionData"></asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetPOItems"
                        TypeName="FiltrumTAXInvoice.SessionData"></asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetInvoices"
                        TypeName="FiltrumTAXInvoice.SessionData"></asp:ObjectDataSource>
                    </td>
               
            </tr>
        </table>
    </form>
</body>
</html>