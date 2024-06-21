﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Localized_E_commerce.View.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link href="register.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <nav class="navbar">
      <div class="navbar-section">
          <div class="logo">LOCALIZED</div>
      </div>
    </nav>

    <div class="container">
        <div class="form-container">
            <div class="welcome">
                Selamat Datang
            </div>
            <asp:TextBox ID="TBox_name" runat="server" CssClass="text-box" placeholder="Name"></asp:TextBox>
            <asp:TextBox ID="TBox_username" runat="server" CssClass="text-box" placeholder="Username"></asp:TextBox>
            <asp:TextBox ID="TBox_email" runat="server" CssClass="text-box" placeholder="Email"></asp:TextBox>
            <asp:TextBox ID="TBox_password" runat="server" CssClass="text-box" placeholder="Password"></asp:TextBox>
            <asp:TextBox ID="TBox_confirm_password" runat="server" CssClass="text-box" placeholder="Confirm Password"></asp:TextBox>
            <asp:Label ID="Label_Status" runat="server" Text="" CssClass="text-status"></asp:Label>
            <asp:Button ID="Btn_Register" runat="server" Text="Daftar" CssClass="btn-login" OnClick="Btn_Register_Click"/>
            <asp:HyperLink ID="ToLogin" runat="server" NavigateUrl="~/View/login.aspx">Sudah punya akun?</asp:HyperLink>
        </div>
    </div>

    <footer>
      <div class="footer-container">
          <div class="column">
              <div class="title">Localized</div>
              <div class="footer-item">Tentang Kami</div>
              <div class="footer-item">Blog</div>
              <div class="footer-item">Karir</div>
            </div>
            <div class="column">
              <div class="title">Layanan Pelanggan</div>
              <div class="footer-item">Pusat Bantuan</div>
              <div class="footer-item">Syarat dan Ketentuan</div>
              <div class="footer-item">Kebijakan Privasi</div>
            </div>
            <div class="column">
              <div class="title">Localized</div>
              <div class="sosial-media">
                <a href="">
                  <img src="../Assets/facebook.svg" alt="" />
                </a>
                <a href="">
                  <img src="../Assets/linkedin.svg" alt="" />
                </a>
                <a href="">
                  <img src="../Assets/youtube.svg" alt="" />
                </a>
                <a href="">
                  <img src="../Assets/instagram.svg" alt="" />
                </a>
              </div>
            </div>
      </div>
    </footer>
</form>
</body>
</html>
