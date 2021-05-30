<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="党史教育.Users1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center">    
        <asp:Label  ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="个人资料"></asp:Label>    
        <br /><br />
        姓&nbsp;&nbsp;&nbsp;&nbsp;名： <asp:TextBox ID="userName" runat="server"></asp:TextBox>
        <br /><br />
        密&nbsp;&nbsp;&nbsp;&nbsp;码： <asp:TextBox ID="password" runat="server"></asp:TextBox>
        <br /><br />
        联系方式： <asp:TextBox ID="tel" runat="server"></asp:TextBox>
        <br /><br />
        邮&nbsp;&nbsp;&nbsp;&nbsp;箱： <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <br /><br />
        
        <asp:Button ID="update" runat="server" Font-Bold="True" Font-Size="Medium" Text=" 修改" OnClick="update_Click" />
        <asp:Label ID="ppp" runat="server"></asp:Label>
    </div>
</asp:Content>
