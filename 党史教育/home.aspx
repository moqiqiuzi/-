<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="党史教育.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        *{
            line-height:40px;
        }
        a:link{
            text-decoration:none;
            color:black;
        }
        a:hover{
            text-decoration:underline;
            color:red;
        }
        a:visited{
            text-decoration:none;
            color:orange;
        }
        .ph_news li{
            text-align:center;
            color:red;
            list-style-type:none;
        }
        .row{
            margin-top:30px;
            height:320px;
        }
        #row-1-left
        {
            float:left;
            width:56%;
        }
        #row-1-right
        {
            float:right;
            width:44%;
        }
        .left{
            margin-top:10px;
            float:left;
            width:47.5%;
        }
        .right{
            margin-top:10px;
            float:right;
            width:47.5%;
        }
        .total{
            margin:5%;
        }
        .ph_img a{
            line-height:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="total">
    <div class="ph_news"><h1><asp:Literal ID="zjyjLiteral1" runat="server"></asp:Literal></h1></div>
	<div class="row" id="row-1">
		<div class="left" id="row-1-left">
			<div class="ph_img">
                <asp:Literal ID="zjyjLiteral2" runat="server"></asp:Literal>
            </div>
        </div>
		<div class="right" id="row-1-right">
		 <asp:Literal ID="zjyjLiteral3" runat="server"></asp:Literal>
	    </div>
     </div>
    <div class="row" id="row-2">
	<div class="left" >
			<h2><a href="links.aspx?typeid=3" target="_blank">纪念活动</a></h2>
			<asp:Literal ID="jnhdLiteral" runat="server"></asp:Literal>
		</div>
		<div class="right">
			<h2><a href="links.aspx?typeid=1" target="_blank">要闻要论</a></h2>
	    <asp:Literal ID="ywylLiteral" runat="server"></asp:Literal>
        </div>
	</div>
    <div class="row" id="row-3">
		<h1 style="text-align:center">奋斗百年路</h1>
              <h2><a href="links.aspx?typeid=2" target="_blank">党史百年</a></h2>
        <div class="left">
            <div class="ph_img">
                <asp:Literal ID="dsbnLiteral1" runat="server"></asp:Literal>
            </div>
             <asp:Literal ID="dsbnLiteral2" runat="server"></asp:Literal>
        </div>
        <div class="right">
             <div class="ph_img">
            <asp:Literal ID="dsbnLiteral3" runat="server">  </asp:Literal>
            </div>
            <asp:Literal ID="dsbnLiteral4" runat="server"></asp:Literal>
        </div>
      </div>
      <div class="row" id="row-4">
          <h2><a href="links.aspx?typeid=2" target="_blank">党建视窗</a></h2>
           <div class="left">
               <div class="ph_img">
               <asp:Literal ID="djscLiteral1" runat="server"></asp:Literal>
               </div>
                <asp:Literal ID="djscLiteral2" runat="server"></asp:Literal>
             </div>
            <div class="right">
               <asp:Literal ID="djscLiteral3" runat="server"></asp:Literal>
             </div>
       </div>
    </div>
</asp:Content>
