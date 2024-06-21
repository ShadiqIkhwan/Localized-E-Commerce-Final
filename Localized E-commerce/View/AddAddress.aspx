<%@ Page Title="" Language="C#" MasterPageFile="~/View/main.Master" AutoEventWireup="true" CodeBehind="AddAddress.aspx.cs" Inherits="Localized_E_commerce.View.AddAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="./AddAddress.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
     <div class="add-address">
         <div class="form-group">
             <asp:Label ID="LbLName" Text="Nama" runat="server" />
             <asp:TextBox runat="server" ID="TBoxName" CssClass="text-input" />
         </div>
         <div class="form-group">
            <asp:Label ID="LblPhone" Text="Phone Number" runat="server" />
            <asp:TextBox runat="server" ID="TBoxPhone" CssClass="text-input" />
        </div>
         <div class="form-group">
            <asp:Label ID="Lbl_Address" Text="New Address" runat="server" />
            <asp:TextBox runat="server" TextMode="MultiLine" ID="Tbox_Address" CssClass="text-area" />
         </div>

         <asp:Button ID="Btn_Submit" runat="server" Text="Simpan" CssClass="btn-submit" OnClick="Btn_Submit_Click" />
         <asp:Button ID="Btn_Cancel" runat="server" Text="Cancel" CssClass="btn-cancel" OnClick="Btn_Cancel_Click" />
     </div>
</asp:Content>
