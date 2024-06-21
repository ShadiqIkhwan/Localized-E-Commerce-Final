<%@ Page Title="" Language="C#" MasterPageFile="~/View/main.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="Localized_E_commerce.View.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="./EditProfile.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="edit-profile">
        <div class="profile-container">
            <div class="circle-profile" ></div>
            <div class="profile-image-container">
                <asp:Image CssClass="profile-image" ImageUrl="../Assets/no-profile.jpg" runat="server" />
            </div>
        </div>
        <div class="text-container">
            <asp:Label CssClass="profile-name" ID="Lbl_Name" runat="server" />
            <asp:Label CssClass="email" ID="Lbl_Email" runat="server" />
            <asp:Button Text="Ubah" CssClass="btn-edit" runat="server" ID="Button_Edit" OnClick="Button_Edit_Click" />
        </div>

        <div class="list-form">
            <div class="form-group">
                <asp:Label runat="server" Text="Nama Depan" CssClass="form-label" />
                <div class="text-input">
                    <asp:TextBox ID="Tbox_Nama_Depan" runat="server" />
                    <asp:Image ImageUrl="~/Assets/pen-svgrepo-com 1.png" runat="server" CssClass="text-input-icon" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Tanggal Lahir" CssClass="form-label" />
                <div class="text-input">
                    <asp:TextBox ID="TBox_Date" runat="server" type="date" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Tanggal Lahir" CssClass="form-label" />
                <asp:RadioButtonList ID="Gender_Radio_Button_List" runat="server" CssClass="radio-button">
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                    <asp:ListItem Text="Tidak mau menjawab" Value="Unknown"></asp:ListItem>
                </asp:RadioButtonList>
            </div>
        </div>
        <div class="button-container" >
            <asp:Button Text="Simpan" runat="server" ID="Submit_Profile" CssClass="button-submit" OnClick="Submit_Profile_Click" />
            <asp:Button Text="Cancel" runat="server" ID="Cancel_Profile" CssClass="button-cancel" OnClick="Cancel_Profile_Click"/>

        </div>
    </div>
</asp:Content>
