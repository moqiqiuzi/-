<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="contribution.aspx.cs" Inherits="党史教育.contribution" %>
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

        .label {
            height: 30px;
            width: 157px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div style="font-size:x-large;font-weight:bold">发表投稿</div> <br/>
	标题：<asp:TextBox runat="server" ID="title" type="text" class="tb"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
      <br /><br />
    <asp:TextBox ID="article" runat="server" Height="500px" TextMode="MultiLine" Width="100%" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Italic="False" Font-Size="Larger"></asp:TextBox>
&nbsp;<br/>    
	<div style="float: left;width: 46%;height:140px;background-color:#efefef;padding-top:15px;padding-left:26px;"> 
		作&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;者：
		<asp:TextBox ID="author" runat="server" class="tb" Font-Size="Large"></asp:TextBox>
		<br /><br />
        文章类型：&nbsp;<asp:DropDownList ID="ddlType" runat="server" CssClass="tb"></asp:DropDownList>
	</div>

	<div style="float: right;width: 46%;height:140px;background-color:#efefef;padding-top:15px;padding-left:26px;">
		联系电话：
		<asp:TextBox ID="phone" runat="server" class="tb"></asp:TextBox>
		<br/><br />
		邮箱地址：
		<asp:TextBox ID="email" runat="server" class="tb"></asp:TextBox>
	</div>
    <div style="text-align:center;height:30px;margin-top:180px;">    <asp:Button ID="btn1" runat="server" class="btn" Text="预览" OnClick="btn1_Click"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btn2" runat="server" class="btn" Text="发布" OnClick="btn2_Click"></asp:Button>    </div>
    <asp:Label ID="cmddd" runat="server"></asp:Label>
</asp:Content>
