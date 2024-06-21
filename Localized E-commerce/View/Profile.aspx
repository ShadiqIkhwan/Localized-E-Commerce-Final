<%@ Page Title="" Language="C#" MasterPageFile="~/View/main.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Localized_E_commerce.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="./Profile.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="profile">
        <div class="profile-container">
            <div class="circle-profile" ></div>
            <div class="profile-image-container">
                <asp:Image CssClass="profile-image" ImageUrl="../Assets/no-profile.jpg" runat="server" />
            </div>

        </div>

        <div class="text-container">
            <asp:Label CssClass="profile-name" ID="Lbl_Name" runat="server" />
            <asp:Label CssClass="email" ID="Lbl_Email" runat="server" />
        </div>

        <div class="profile-list">
            <div class="profile-item">
                <div class="profile-item-title">Info Pribadi</div>
                <asp:ImageButton ID="Info_Pribadi" CssClass="chevron-right" ImageUrl="../Assets/next.png" runat="server" OnClick="Info_Pribadi_Click" />
            </div>
            <div class="profile-item">
                <div class="profile-item-title">Alamat Pengiriman</div>
                <asp:ImageButton ID="Alamat_Pengiriman" CssClass="chevron-right" ImageUrl="../Assets/next.png" runat="server" OnClick="Alamat_Pengiriman_Click"/>
            </div>
            <div class="profile-item">
                <div class="profile-item-title">Riwayat Pesanan</div>
                <asp:ImageButton ID="Riwayat_Pesanan" CssClass="chevron-right" ImageUrl="../Assets/next.png" runat="server" OnClick="Riwayat_Pesanan_Click" />
            </div>

        </div>


    </div>
</asp:Content>
