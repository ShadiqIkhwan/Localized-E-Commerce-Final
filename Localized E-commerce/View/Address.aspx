<%@ Page Title="" Language="C#" MasterPageFile="~/View/main.Master" AutoEventWireup="true" CodeBehind="Address.aspx.cs" Inherits="Localized_E_commerce.View.Address" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="./Address.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="address">
        <div class="list-address">
            <asp:Repeater ID="Repeater_Address" runat="server">
                <ItemTemplate>
                    <div class="address-item">
                        <div class="address-detail">
                            <div class="title"><%# Eval("AddressName") %> | <%# Eval("PhoneNUmber") %></div>
                            <asp:Button Text="Ubah" ID="Address_Change" runat="server" OnClick="Address_Change_Click" CssClass="button-edit" />
                        </div>
                        <div class="full-address">
                            <%# Eval("Address1") %>
                        </div>
                        <div class="type-container">
                            <asp:HiddenField ID="HF_Address" runat="server" Value='<%# Eval("Id") %>' />
                            <asp:CheckBox OnCheckedChanged="CheckBox_Address_CheckedChanged" ID="CheckBox_Address" runat="server" Checked='<%# (bool)(Eval("Type").ToString() == "Primary") %>' AutoPostBack="true" />
                            <div>Gunakan sebagai alamat pengiriman</div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Button ID="Btn_Add_Address" CssClass="btn-add" runat="server" Text="Tambah Alamat Baru" OnClick="Btn_Add_Address_Click" />
        </div>
    </div>

    <script>

    </script>
</asp:Content>
