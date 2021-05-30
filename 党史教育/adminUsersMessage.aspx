<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="adminUsersMessage.aspx.cs" Inherits="党史教育.adminUsersMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center">
        <h1>用户信息管理</h1>
        <div style="width:365px;margin:auto">
            <asp:Literal ID="userMessage" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>
