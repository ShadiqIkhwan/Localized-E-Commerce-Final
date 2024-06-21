<%@ Page Title="" Language="C#" MasterPageFile="~/View/main.Master" AutoEventWireup="true" CodeBehind="EditAddress.aspx.cs" Inherits="Localized_E_commerce.View.EditAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="./EditAddress.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="edit-address">
        <asp:Label ID="Lbl_Address" Text="New Address" runat="server" />
        <asp:TextBox runat="server" TextMode="MultiLine" ID="Tbox_Address" CssClass="text-input" />

        <asp:Button ID="Btn_Submit" runat="server" Text="Simpan" CssClass="btn-submit" OnClick="Btn_Submit_Click" />
        <asp:Button ID="Btn_Cancel" runat="server" Text="Cancel" CssClass="btn-cancel" OnClick="Btn_Cancel_Click" />
    </div>
</asp:Content>
