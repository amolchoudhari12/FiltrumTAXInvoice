<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsDetails.aspx.cs" Inherits="Reports_ProductsDetails" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%">
            <tr>
                <td style="width: 100px; height: 21px;">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <rsweb:reportviewer id="ReportViewer1" runat="server" font-names="Verdana" font-size="8pt"
                        height="900px" width="900px">
<LocalReport ReportPath="App_Code\Reports\ProductDetails.rdlc">
    <DataSources>
        <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1_rptGetProductDetails1" />
    </DataSources>
    
    
</LocalReport>
</rsweb:reportviewer>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData"
                        TypeName="DataSet1TableAdapters.rptGetProductDetailsTableAdapter"></asp:ObjectDataSource>
                    &nbsp;&nbsp;
                    
                   
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
