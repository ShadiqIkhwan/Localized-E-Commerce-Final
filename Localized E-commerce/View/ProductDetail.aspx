<%@ Page Title="" Language="C#" MasterPageFile="~/View/main.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="Localized_E_commerce.View.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="ProductDetail.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <div class="product-detail">
            <div class="image-container">
                <div class="main-image">
                    <asp:Image ID="MainImage" runat="server" />
                </div>
                <div class="list-image">
                    <asp:Repeater ID="List_Image" runat="server" OnItemCommand="List_Image_ItemCommand">
                        <ItemTemplate>
                            <asp:ImageButton ID="Img_Thumbnail" runat="server" CssClass="image-item" ImageUrl='<%# Eval("image1") %>' AlternateText="Thumbnail" CommandName="Select" CommandArgument='<%# Eval("image1") %>' />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <div class="detail-container">
                <asp:Label ID="Product_Title" runat="server" CssClass="product-title" />
                <asp:Label ID="Product_Price" runat="server" CssClass="product-price" />
                <asp:HiddenField ID="Product_ID" runat="server" />
                <asp:Label runat="server" ID="Lbl_Size" CssClass="label-text" Text="Ukuran:" />
                <asp:HiddenField ID="HF_Size" runat="server" />
                <div class="size-list">

                    <asp:Repeater runat="server" ID="Size_Repeater" OnItemCommand="Size_Repeater_ItemCommand" OnItemDataBound="Size_Repeater_ItemDataBound">
                        <ItemTemplate>
                            <asp:Button ClientIDMode="Static" ID="ButtonSize" runat="server" Text='<%# Eval("size1") %>' CommandName="Select" CommandArgument='<%# Eval("size1") %>' />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div class="quantity-container">
                    <asp:Button ID="Min_Cart" Text="-" OnClick="Min_Cart_Click" runat="server" />
                    <asp:TextBox CssClass="quantity" ID="Quantity" runat="server" autocomplete="off" />
                    <asp:Button ID="Plus_Cart" Text="+" OnClick="Plus_Cart_Click" runat="server" />
                </div>
                <asp:Button CssClass="cart-button" Text="+ Keranjang" runat="server" ID="Button_Add_To_Cart" OnClick="Button_Add_To_Cart_Click" />
            </div>
        </div>
        <div class="information">
            <div class="label-text">Information</div>
            <asp:Label ID="Product_Descripition" runat="server" />
        </div>

        <div class="product-list">
            <asp:Repeater ID="Product_List" runat="server">
                <ItemTemplate>
                    <div class="product-item">
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

</asp:Content>
