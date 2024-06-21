<%@ Page Title="" Language="C#" MasterPageFile="~/View/main.Master" AutoEventWireup="true" CodeBehind="HistoryTransaction.aspx.cs" Inherits="Localized_E_commerce.View.HistoryTransaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="./HistoryTransaction.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="history">
        <div class="history-list">
            <asp:Repeater runat="server" ID="Repeater_History" >
                <ItemTemplate>
                    <div class="history-item">
                        <div class="history-header">
                            <asp:Label CssClass="history-number" ID="Lbl_Number" runat="server" Text='<%# "No. Pesanan " + Eval("Id")  %>' />
                            <asp:Label CssClass="history-date" ID="Lbl_Date" runat="server" Text='<%# Eval("TransactionDate") %>' />
                        </div>
                        <div class="detail-list">
                            <asp:Repeater ID="Repeater_Detail" runat="server" DataSource='<%# Eval("TransactionDetails") %>'>
                                <ItemTemplate >
                                    <div class="history-container">
                                        <div class="history-image">
                                            <img src="<%# Eval("Product.mainImage") %>" />
                                        </div>
                                        <div class="history-detail-text">
                                            <div class="product-name"><%# Eval("Product.name") %></div>
                                            <div class="product-quantity">Jumlah: <%# Eval("Quantity") %></div>
                                            <div class="product-quantity">Total Harga: <%# String.Format("{0:C}", Convert.ToInt32(Eval("Quantity")) * Convert.ToInt32(Eval("Product.price"))) %></div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                            <div class="status-container">
                                <asp:Label runat="server" Text='<%# Eval("Status") %>'  />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
