<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="cart1.aspx.cs" Inherits="PRN292_Project.cart1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/cart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container_fullwidth">  
          
              <h3 class="title">
                Shopping Cart
              </h3>
              <div class="clearfix">
              </div>
              <table class="shop-table">
                <thead>
                  <tr>
                    <th>
                      Image
                    </th>
                    <th>
                      Details
                    </th>
                    <th>
                      Price
                    </th>
                    <th>
                      Quantity
                    </th>
                    <th>
                      Total
                    </th>
                    <th>
                      Delete
                    </th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td>
                      <img src="image/avatar.png" />
                    </td>
                    <td>
                      <div class="shop-details">
                        <div class="productname">
                          Lincoln Corner Unit Products
                        </div>
                        <p>
                          <img src="image/star.png" />
                          <a class="review_num" href="#">
                            02 Review(s)
                          </a>
                        </p>
                        
                        <p>
                          Product Code : 
                          <strong class="pcode">
                            Dress 120
                          </strong>
                        </p>
                      </div>
                    </td>
                    <td>
                      <h5>
                        $200.00
                      </h5>
                    </td>
                    <td>
                      <select name="">
                        <option selected value="1">
                          1
                        </option>
                        <option value="1">
                          2
                        </option>
                        <option value="1">
                          3
                        </option>
                      </select>
                    </td>
                    <td>
                      <h5>
                        <strong class="red">
                          $200.00
                        </strong>
                      </h5>
                    </td>
                    <td>
                      <a href="#">
                        <img src="image/remove.png" alt="">
                      </a>
                    </td>
                  </tr>
                  <tr>
                    <td>
                      <img src="image/avatar.png" />
                    </td>
                    <td>
                      <div class="shop-details">
                        <div class="productname">
                          Lincoln Corner Unit Products
                        </div>
                        <p>
                          <img alt="" src="image/star.png">
                          <a class="review_num" href="#">
                            02 Review(s)
                          </a>
                        </p>
                        
                        <p>
                          Product Code : 
                          <strong class="pcode">
                            Dress 132
                          </strong>
                        </p>
                      </div>
                    </td>
                    <td>
                      <h5>
                        $200.00
                      </h5>
                    </td>
                    <td>
                      <select name="">
                        <option selected value="1">
                          1
                        </option>
                        <option value="2">
                          2
                        </option>
                        <option value="3">
                          3
                        </option>
                      </select>
                    </td>
                    <td>
                      <h5>
                        <strong class="red">
                          $200.00
                        </strong>
                      </h5>
                    </td>
                    <td>
                      <a href="#">
                        <img src="image/remove.png" alt="">
                      </a>
                    </td>
                  </tr>
                  <tr>
                    <td>
                      <img src="image/avatar.png" />
                    </td>
                    <td>
                      <div class="shop-details">
                        <div class="productname">
                          Lincoln Corner Unit Products
                        </div>
                        <p>
                          <img alt="" src="image/star.png">
                          <a class="review_num" href="#">
                            02 Review(s)
                          </a>
                        </p>
                        
                        <p>
                          Product Code : 
                          <strong class="pcode">
                            Dress 050
                          </strong>
                        </p>
                      </div>
                    </td>
                    <td>
                      <h5>
                        $200.00
                      </h5>
                    </td>
                    <td>
                      <select name="">
                        <option selected value="1">
                          1
                        </option>
                        <option value="2">
                          2
                        </option>
                        <option value="3">
                          3
                        </option>
                      </select>
                    </td>
                    <td>
                      <h5>
                        <strong class="red">
                          $200.00
                        </strong>
                      </h5>
                    </td>
                    <td>
                      <a href="#">
                        <img src="image/remove.png" alt="">
                      </a>
                    </td>
                  </tr>
                </tbody>
                <tfoot>
                  <tr>
                    <td colspan="6">
                      <button class="pull-left">
                        Continue Shopping
                      </button>
                      <button class=" pull-right">
                        Confirm Order
                      </button>
                    </td>
                  </tr>
                </tfoot>
              </table>
              <div class="clearfix">
              </div>                                            
              
          
            </div>
</asp:Content>
