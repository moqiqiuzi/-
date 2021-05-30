<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="党史教育.Register" %>
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
    <div class="register_account" style="padding-top:50px;">
    <div style="align-items:center;width: 50%;height:750px;padding-top:40px;background-color: #D66762;" >
        <div style="font-size:x-large;font-weight:bold;text-align:center;color:#CCCC00;">注册</div> <br/><br />
        <div style="text-align:center;color:#CCCC00;padding-top:10px;padding-bottom:10px;font-size:large;">
                用 户 名 ：
                 <asp:TextBox runat="server" ID="tbUsernameForRegister" type="text" CssClass="tb"/><br /><br />
            <asp:RequiredFieldValidator runat="server" id="reqUsernameforRegister" controltovalidate="tbUserNameForRegister" errormessage="必须填写用户名" CssClass="cv"></asp:RequiredFieldValidator>
            </div>
            <div style="text-align:center;color:#CCCC00;padding-top:10px;padding-bottom:10px;font-size:large;">
                密&nbsp; 码 ：
                 <asp:TextBox runat="server" ID="tbPassword1" type="text" CssClass="tb" /><br /><br />
                <asp:RequiredFieldValidator runat="server" id="reqPassword1" controltovalidate="tbPassword1" errormessage="必须填写密码" CssClass="cv"></asp:RequiredFieldValidator>
            </div>
            <div style="text-align:center;color:#CCCC00;padding-top:10px;padding-bottom:10px;font-size:large;">
                确认密码 ：
                 <asp:TextBox runat="server" ID="tbPassword2" type="text" CssClass="tb" /><br /><br />
                <asp:RequiredFieldValidator runat="server" id="reqPassword2" controltovalidate="tbPassword2" errormessage="必须确认密码" CssClass="cv"></asp:RequiredFieldValidator>
            </div>
            <div style="text-align:center;color:#CCCC00;padding-top:10px;padding-bottom:10px;font-size:large;">
                邮&nbsp; 箱 ：
                 <asp:TextBox runat="server" ID="tbEmail" type="text" CssClass="tb" /><br /><br />
                 <asp:RegularExpressionValidator ID="reqEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="不是邮箱格式"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w)*\.\w+([-.]\w+)*" CssClass="cv"></asp:RegularExpressionValidator>
            </div>
            <div style="text-align:center;color:#CCCC00;padding-top:10px;padding-bottom:50px;font-size:large;">
                手 机 号 ：
                 <asp:TextBox runat="server" ID="tbPhone" type="text" CssClass="tb" /><br /><br />
                 <asp:RegularExpressionValidator ID="reqPhone" runat="server" ControlToValidate="tbPhone" ErrorMessage="必须为11位手机号码" ValidationExpression="^1[0-9]{10}$" CssClass="cv"></asp:RegularExpressionValidator>
            </div>
            <div style="text-align:center;padding-top:10px;padding-bottom:50px;font-size:large;">
                <asp:Button ID= "btRegister" Text="注册" runat="server"  OnClick="btRegister_Click" CssClass="btn" />&nbsp;&nbsp;&nbsp;
                <asp:Button ID= "btCancel" Text="取消" runat="server"  OnClick="btCancel_Click" CssClass="btn" CausesValidation="False" /><br /><br />
                <asp:CompareValidator ID="cmpvPassword" runat="server" ControlToCompare="tbPassword1" ControlToValidate="tbPassword2" Display="Dynamic" ErrorMessage="密码和确认密码必须一致" ValidationGroup="register" CssClass="cv" ></asp:CompareValidator><br /><br />
                <asp:Button ID= "btBack" Text="返回" runat="server"  OnClick="btBack_Click" CssClass="btn" CausesValidation="False" /><br /><br />
            </div>
    </div>
    </div>

    </form>
    </div>
</asp:Content>
