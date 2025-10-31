<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
        <table width="100%" border="1" style="border-top-style: ridge; border-right-style: ridge; border-left-style: ridge; border-bottom-style: ridge" >
            <tr>
           <td colspan="3" style="height: 62px; background-color: lavender; text-align: right;" >
           
           <table width="100%">
           
           <tr>
           <td style="height: 43px; text-align: center;" valign="top" colspan="5">
               <strong><span style="font-size: 24pt"><span style="font-family: Haettenschweiler; background-color: lavender;">Filtrum
                   Fibretechnologies Private Limited<br />
                   <br />
                   <span style="color: #6666ff; text-decoration: underline">Invoice System</span></span></span></strong><span
                       style="color: #6666ff"><span> &nbsp; </span>
                   <span style="font-size: 10pt; font-family: Verdana">&nbsp;</span></span></td>
           
           </tr>
           
           </table>
               <span style="font-size: 10pt; font-family: Verdana"> </span>
           
           </td>
           
           
            </tr>
            
            <tr>
            
            <td style="background-color: lavender; position: static; height: 70%; text-align: center;" valign="middle" colspan="3" >
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <table border="1" style="width: 392px; height: 176px; background-color: mistyrose;">
                    <tr>
                        <td colspan="2" style="width: 150px; background-color: lightpink; text-align: center">
                            <span style="font-size: 14pt; font-family: Verdana"><strong>Login </strong></span>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 150px; height: 27px; text-align: right">
                            <span style="font-size: 10pt; font-family: Verdana">UserName:</span></td>
                        <td style="width: 156px; height: 27px">
                            <asp:TextBox ID="txtUsername" runat="server" Width="205px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 150px; height: 29px; text-align: right">
                            <span style="font-size: 10pt; font-family: Verdana">Password:</span></td>
                        <td style="width: 156px; height: 29px">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="204px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 150px">
                            &nbsp;</td>
                        <td style="width: 156px">
                            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="153px" /></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="width: 100px; height: 33px; text-align: center; vertical-align: top;">
                            <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Bold="True"></asp:Label></td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                &nbsp;</td>
            </tr>
            
            
            <tr>
            
            <td colspan="3" style="text-align: center; background-color: lightgrey;">
                <span lang="EN-GB" style="font-size: 12pt; font-family: 'Times New Roman'; mso-fareast-font-family: 'Times New Roman';
                    mso-ansi-language: EN-GB; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    <span style="mso-spacerun: yes">&nbsp; &nbsp; &nbsp; &nbsp;<span style="font-size: 10pt;
                        font-family: Verdana">&nbsp; </span></span><span style="font-size: 10pt; font-family: Verdana">
                            Copyright
                    © 2007 AVC Softwares. All Rights Reserved. </span></span>
            </td>
            </tr>
            
            
        </table>
    
    

    </div>
    </form>
</body>
</html>
