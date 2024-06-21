<%@ Page Title="" Language="C#" MasterPageFile="~/View/main.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Localized_E_commerce.View.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <script>
        var redirect = function (obj) {
            window.location = "ProductDetail.aspx?Id=" + obj;
        }
    </script>
    <div class="hero-section">
        <div class="hero">Mulai Belanja</div>
        <div class="category">
            <div class="title">Kategori</div>
            <div class="category-list">
              <div class="category-item category-item-1">
                <div class="image">
                  <img src="../Assets/shirt-svgrepo-com 1.svg" alt="" />
                </div>
                <div class="text">Pakaian</div>
              </div>
              <div class="category-item category-item-2">
                <div class="image">
                  <img src="../Assets/handbag-svgrepo-com 1.svg" alt="" />
                </div>
                <div class="text">Aksesoris</div>
              </div>
              <div class="category-item category-item-3">
                <div class="image">
                  <img src="../Assets/cosmetics-svgrepo-com 1.svg" alt="" />
                </div>
                <div class="text">Dekorasi</div>
              </div>
              <div class="category-item category-item-4">
                <div class="image">
                  <img src="../Assets/cooking-stew-svgrepo-com 1.svg" alt="" />
                </div>
                <div class="text">Perlengkapan Rumah Tangga</div>
              </div>
            </div>
          </div>

        <div class="beranda">
            <div class="title">Beranda</div>
              <div class="product-grid">
                  <asp:Repeater ID="Repeater1" runat="server">
                      <ItemTemplate>
                          <div class="product-item" onclick="redirect(<%# Eval("Id") %>)">
                              <div class="image-container">
                                    <img src="<%# Eval("mainImage")  %>" alt="<%# Eval("name") %>" />
                                  </div>
                              <div class="product-caption">
                                <div class="product-name"><%# Eval("name") %></div>
                                <div class="product-description"><%# Eval("description") %></div>
                                <div class="product-price">Rp. <%# Eval("price") %>,-</div>
                              </div>
                      
                            </div>
                      </ItemTemplate>
                    </asp:Repeater>
              </div>
          </div>
    </div>

    
</asp:Content>
