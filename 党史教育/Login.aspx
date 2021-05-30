<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="党史教育.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
         .tb {
            width: 250px;
            height:25px;
            border-color:gray;
            
        }
         .btn {
         color:#CCCC00;
         background-color: #CC3300;
         font-size:medium;
         border:1px solid #ba261a;
         width:100px;
         height:30px;
     }
         .cv{
             color:#666666;
             font-size:medium;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%;height:100%;align-items:center; background-color: #DEAFA9;" >
        <form runat ="server">
     <div class="login_panel" style="padding-top:50px;">
    <div style="align-items:center;width: 50%;height:400px;padding-top:50px;background-color: #D66762;" >
        <div style="font-size:x-large;font-weight:bold;text-align:center;color:#CCCC00;">登录</div> <br/><br />
            <div style="text-align:center;color:#CCCC00;padding-top:10px;padding-bottom:10px;font-size:large;">
                用 户 名 ：
                <asp:TextBox ID="tbUsername" runat="server"   type="text" CssClass="tb"/><br /><br />
                <asp:RequiredFieldValidator runat="server" id="reqUsername" controltovalidate="tbUsername" errormessage="必须填写用户名" CssClass="cv"></asp:RequiredFieldValidator>
            </div>
            <div style="text-align:center;color:#CCCC00;padding-top:10px;padding-bottom:20px;font-size:large;">
                密&nbsp; 码 ：
                <asp:TextBox runat="server" ID="tbPassword" type="text" CssClass="tb" /><br /><br />
                <asp:RequiredFieldValidator runat="server" id="reqPassword" controltovalidate="tbPassword" errormessage="必须填写密码" CssClass="cv"></asp:RequiredFieldValidator>
            </div>
            <div style="text-align:center;padding-top:10px;padding-bottom:50px;font-size:large;">
                <asp:Button ID= "btLogin" Text="登录" runat="server"  OnClick="btLogin_Click" CssClass="btn" />
                &nbsp;&nbsp;<asp:Button ID= "btRegister" Text="注册" runat="server"  OnClick="btRegister_Click" CssClass="btn" CausesValidation="False" />
                &nbsp;&nbsp;<asp:Button ID= "btBack" Text="返回" runat="server"  OnClick="btBack_Click" CssClass="btn" CausesValidation="False" /><br /><br />
            </div>
    </div>
    </div>
    
    </form>
    </div>
</asp:Content>
