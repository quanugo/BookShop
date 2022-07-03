<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage2.Master" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="PRN292_Project.history" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/history.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container_fullwidth">
    <br />
            
            <br />
            <h3 class="title">Lịch sử giao dịch
            </h3>
            <br />
            <br />
            <asp:TextBox ID="tbFind" runat="server" Height="16px" Width="382px" placeholder="Nhập mã đơn hàng của bạn" ></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Height="22px" Text="Tìm kiếm" Width="68px" OnClick="btnSearch_Click" />
            <br />
            <br />
            <asp:GridView ID="gvOrder" runat="server" EnableModelValidation="True" Width="824px" AutoGenerateColumns="false" EnableViewState ="false">
                <Columns>
                    
                    <asp:BoundField HeaderText="Mã đơn hàng" DataField="OrderID" />
                    <asp:BoundField HeaderText="Người mua" DataField="Email" />
                    <asp:BoundField HeaderText="Địa chỉ" DataField="Address"/>
                    <asp:BoundField HeaderText="Ngày mua" DataField="OrderDate" />
                    <asp:BoundField HeaderText="Trạng thái" DataField="Status"/>
                </Columns>
            </asp:GridView>
        </div>
</asp:Content>
