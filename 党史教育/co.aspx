<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="co.aspx.cs" Inherits="党史教育.co" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
     .btn {
         color:#ba261a;
         background-color:white;
         font-size:medium;
         border:1px solid #ba261a;
         width:100px;
         height:30px;
     }

     .btn:hover{
         background-color:#ba261a;
         color:white;
     }


    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div style="text-align:center;padding-top:15px;"><asp:Label ID="title" runat="server" ForeColor="Red" Font-Size="Larger" /></div>
            <br />
        <div style="align-items:center;width:100%;padding-top:8px;padding-left:15%">
            <asp:Label ID="article" runat="server" Height="600px" TextMode="MultiLine" Width="70%" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></asp:Label>
&nbsp;<br/><br />
        </div>
        <div style="text-align:center">
            <asp:Button runat="server" CssClass="btn" OnClick="Unnamed2_Click" Height="30px" Width="150px" Text="返回编辑"/>
        </div>
    </form>
</body>
</html>
