<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="audit.aspx.cs" Inherits="党史教育.audit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
    
     .tb {
            width: 250px;
            height:28px;
            border-color:gray;
            border:1px solid black;
        }

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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        	<div style="font-size:x-large;font-weight:bold;text-align:center">审核</div> <br/>
	标题：<asp:Label runat="server" class="tb" ID="title" BorderColor="White"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;文章类型：<asp:label ID="leixing" runat="server" class="tb" Font-Size="Large" BackColor="White" BorderColor="White"></asp:label>
<br /><br />
    <asp:label runat="server" ID="article" Height="400px" TextMode="MultiLine" Width="100%" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></asp:label>
&nbsp;<br/>
	<div style="float: left;width: 46%;height:140px;background-color:#efefef;padding-top:15px;padding-left:26px;"> 
		作&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;者：
		<asp:label ID="source" runat="server" class="tb" Font-Size="Large" BorderColor=#efefef></asp:label>
        <br/><br />
        投&nbsp;稿&nbsp;日&nbsp;期：<asp:label ID="date" runat="server" class="tb" BorderColor=#efefef></asp:label>
	</div>

	<div style="float: right;width: 46%;height:140px;background-color:#efefef;padding-top:15px;padding-left:26px;">
		联系电话：
		<asp:label ID="tel" runat="server" class="tb" BorderColor=#efefef></asp:label>
		<br/><br />
		邮箱地址：
		<asp:label ID="email" runat="server" class="tb" BorderColor=#efefef></asp:label>
        <br/><br />
	</div>
    <div style="text-align:center;height:30px;margin-top:180px;">
        <asp:RadioButton ID="dontagree" runat="server" Text="不同意" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:RadioButton ID="agree" runat="server" Text="同意" />
        <br/><br />
        <asp:Button ID="submit" runat="server" Text="提交" class="btn" OnClick="submit_Click"/>
    </div>

</asp:Content>
