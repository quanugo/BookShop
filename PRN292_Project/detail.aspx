<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage2.Master" AutoEventWireup="true" CodeBehind="detail.aspx.cs" Inherits="PRN292_Project.detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
    <link href="css/detail.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container_fullwidth">
        <div class="container">
          <div class="row">
            <div class="col-md-9">
              <div class="products-details">
                <div class="preview_image">
                  <div class="preview-small">
                    <asp:Image ID="Image1" runat="server" />
                  </div>                
                </div>
                <div class="products-description">
                  <h5 class="name">
                  Tên: <asp:Label ID="Name" runat="server" ></asp:Label>
                  </h5>                
                
                  <p>
                  Tác giả: <asp:Label ID="Author" runat="server" ></asp:Label>
                  </p>
                    <p>
                   Xuất bản: <asp:Label ID="Publisher" runat="server" ></asp:Label>
                  </p>
                  <p>
                   Thể loại: <asp:Label ID="Genre" runat="server" ></asp:Label >
                  </p>
                  <hr class="border">
                  <div class="price">
                    Price : 
                    <span class="new_price">
                        <asp:Label ID="Price" runat="server" ></asp:Label>
                      <sup>
                        VND
                      </sup>
                    </span>
                   
                  </div>
                  <hr class="border">
                  <div class="wided">                   
                    <div class="button_group">
                      <button class="button" >
                        Add To Cart
                      </button>                    
                    </div>
                  </div>
                  <div class="clearfix">
                  </div>
                  <hr class="border">
                  <img src="images/share.png" alt="" class="pull-right">
                </div>
              </div>
              <div class="clearfix">
              </div>
              <div class="tab-box">
                <div id="tabnav">
                  <ul>
                    <li>
                      <a href="#Description">
                        DESCRIPTION
                      </a>
                    </li>                   
                  </ul>
                </div>
                <div class="tab-content-wrap">
                  <div class="tab-content" id="Description">
                     <p><asp:Label ID="Description" runat="server" Text="Label"></asp:Label></p> 
                  </div>                                   
                </div>
              </div>
              <div class="clearfix">
              </div>
            </div>
              </div>
            </div>
        </div>
</asp:Content>
