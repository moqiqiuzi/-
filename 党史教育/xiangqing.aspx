<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="xiangqing.aspx.cs" Inherits="党史教育.xiangqing"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        *{
            line-height:35px
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="home.aspx">首页</a>&gt;
    <asp:hyperlink id="lnkClassification" runat="server" text="当前分类" />
    <br />
    <br />
    <div style=" text-align:center">
    <asp:Label ID="LbName" runat="server" style=" height: auto; overflow: hidden;line-height: 1.5em;text-align: center;font-weight: bold; font-size:30px;"></asp:Label>
    <br /></div>
    <br />
    <div style=" text-align:center">
    时间：<asp:Label ID="LbTime" runat="server" style=" height: 30px; line-height: 30px;text-align: center;border-bottom: 1px dashed #ccc; margin-bottom: 15px;"></asp:Label>
    <asp:Label ID="LbSourse" runat="server" />
    <br /></div>
    <div style="margin:30px">
    <asp:Label ID="Lbarticle" runat="server" style="font-size: 14pt;font-family: 宋体;" /></div>
    <br />
    <br />
    </asp:Content>