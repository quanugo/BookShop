<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="dsvanhoc.aspx.cs" Inherits="PRN292_Project.dsvanhoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/home.css" rel="stylesheet" type="text/css" media="screen" runat="server" />
	<link href="https://fonts.googleapis.com/css2?family=Yeseva+One&display=swap" rel="stylesheet"/>
    <style type="text/css">
        .auto-style1 {
            left: -280px;
            top: -9px;
            width: 144px;
        }

        .auto-style2 {
            font-size: 16px;
            font-family: Cambria;
        }

        .auto-style3 {
            width: 100%;
        }

        td, input {
            font-family: Cambria;
            font-size: 12px;
            text-align: center;
            padding: 5px;
            margin: 5px;
            vertical-align: top;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div id="stsv-02">  <h3 class="tde" style="text-align:center"><span>Văn học</span></h3></div>
    
    <br /> <br /><br /><br /><br /><br />
    <div id="middle">
       <asp:DataList ID="DataList2" style="text-align:center" runat="server" DataKeyField="BookID" RepeatColumns="4">

                <ItemTemplate>
                    <table class="auto-style3">
                        <tr>
                            <td>
                            <asp:Image ID="Image1" runat="server" Height="165px" ImageUrl='<%# Eval("imagePath") %>' Width="130px" alt='<%# Eval("imagePath") %>'/>
                            </td>
                        </tr>
                        <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("BookName") %>'></asp:Label>
                        </td>
                    </tr>
                         <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Price") %>'> </asp:Label> VND
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink ID="HyperLink1" runat="server" Text="Add To Cart" NavigateUrl="www.facebook.com" ></asp:HyperLink> 
                        </td>
                        
                    </tr>   
                    </table>
                </ItemTemplate>
            </asp:DataList>
    </div>       
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div id="right">
            <div id="share_box">
                <div id="share_header">Share this page</div>
                <div id="share_content">
                    <img src="gif/tenor%20(2).gif" width="180"/>
                </div>
            </div>
        </div>
</asp:Content>
