<%@ Page Title="" Language="C#" MasterPageFile="~/View/main.Master" AutoEventWireup="true" CodeBehind="Cartlist.aspx.cs" Inherits="Localized_E_commerce.View.Cartlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Cartlist.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    
    <div class="cart-list">
        <div class="select-all">
            <asp:CheckBox CssClass="check-all" ID="chkAll" Text="Select All" runat="server" OnCheckedChanged="chkAll_CheckedChanged" AutoPostBack="false" />
        </div>
        <div class="container">
            <div class="list-item">
                <asp:Repeater ID="Checkbox_Repeater" runat="server">
                    <ItemTemplate>
                        <div class="item">
                            <asp:HiddenField ID="HF_ID" runat="server" Value='<%# Eval("Id") %>' />
                            <asp:HiddenField ID="HF_ProductID" runat="server" Value='<%# Eval("productId") %>' />
                            <asp:HiddenField ID="hfPrice" runat="server" Value='<%# Eval("price") %>' />
                            <asp:HiddenField ID="HF_Quantity" runat="server" Value='<%# Eval("quantity") %>' />
                            <asp:HiddenField ID="HF_Size" runat="server" Value='<%# Eval("size") %>' />

                            <asp:CheckBox ID="Chk_Item" runat="server" 
                                  data-price='<%# Eval("price") %>' OnClick="updateTotalPrice()" />
                            <img src="<%# Eval("mainImage") %>" alt="<%# Eval("name") %>" />
                            <div class="title"><%# Eval("name") %></div>
                            <div class="right-column">
                                <div class="price">
                                    <%# String.Format("{0:C}", Convert.ToInt32(Eval("price"))) %>
                                </div>
                                <div class="button-container">
                                    <asp:Button ID="Remove_Cart" runat="server" CssClass="btn-delete" Text="Hapus" OnClick="Remove_Cart_Click" />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            
            <div class="price-container">
                <div class="subtotal-container">
                    <div class="subtotal">Sub Total</div>
                    <asp:Label ID="lblTotalPrice" runat="server" Text="0" CssClass="price" />
                </div>
                <div class="choosed-item">
                    <asp:Label ID="lblTotalCount" runat="server" Text="0" /> item
                </div>

                <asp:Button ID="Btn_Checkout" OnClick="Btn_Checkout_Click" runat="server" Text="+ Beli" CssClass="btn-checkout" />
            </div>
        </div>
    </div>
    <script>
        var checkAll = document.querySelector('input[type="checkbox"][id$="chkAll"]');
        checkAll.addEventListener("change", function () {

            var checkboxes = document.querySelectorAll('input[type="checkbox"][id*="Chk_Item"]');
            for (var i = 0; i < checkboxes.length; i++) {
                checkboxes[i].checked = checkAll.checked;
            }

            updateTotalPrice()


        })

        function updateTotalPrice() {
            var total = 0;
            var count = 0;

            var inputPrices = document.querySelectorAll('[id*="hfPrice"]');
            var checkboxes = document.querySelectorAll('input[type="checkbox"][id*="Chk_Item"]');
            for (var i = 0; i < checkboxes.length; i++) {
                if (checkboxes[i].checked) {
                    var price = parseFloat(inputPrices[i].value);
                    total += price;
                    count++;
                    
                }
            }
            document.getElementById('<%= lblTotalPrice.ClientID %>').innerText = total.toFixed(0);
            document.getElementById('<%= lblTotalCount.ClientID %>').innerText = count;

        }


    </script>
</asp:Content>
