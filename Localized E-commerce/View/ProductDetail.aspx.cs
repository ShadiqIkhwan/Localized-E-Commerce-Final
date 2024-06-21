using Localized_E_commerce.Factory;
using Localized_E_commerce.Models;
using Localized_E_commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Localized_E_commerce.View
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getProductDetail();
            }
        }

        public void getProductDetail()
        {
            String id = Request.QueryString["Id"];

            if (id != null) {
                var product = ProductRepository.getProductById(Int32.Parse(id));
                MainImage.ImageUrl = product.mainImage;

                var images = product.Images.ToList();

                if (images != null) {
                    List_Image.DataSource = images;
                    List_Image.DataBind();
                }
                
                Product_ID.Value = product.Id.ToString();
                Product_Title.Text = product.name;
                Product_Price.Text = String.Format("{0:C}", product.price) + ",-";
                Quantity.Text = 0.ToString();

                var sizes = product.Sizes.ToList();

                if (sizes != null) {
                    Size_Repeater.DataSource = sizes;
                    Size_Repeater.DataBind();
                }

                Product_Descripition.Text = product.description;

                List<Product> products = ProductRepository.getAllProduct();

                if (products != null) { 
                    Product_List.DataSource = products;
                    Product_List.DataBind();
                }

            }
        }

        protected void Button_Add_To_Cart_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(Quantity.Text);

            if(quantity > 0)
            {
                String productId = Product_ID.Value;
                User user = (User)Session["user"];

                if (productId != null && user != null)
                {
                    int userId = user.Id;
                    String size = HF_Size.Value.ToString();
                    Cart cart = CartFactory.AddToCart(userId, Convert.ToInt32(productId), quantity, size);

                    CartRepository.AddToCart(cart);

                    Response.Redirect("~/View/home.aspx");

                }
                else if(user == null)
                {
                    Response.Redirect("~/View/login.aspx");
                }
            }
        }

        protected void Min_Cart_Click(object sender, EventArgs e)
        {
            int quantityVal = Convert.ToInt32(Quantity.Text);

            if(quantityVal > 0)
            {
                Quantity.Text = (quantityVal - 1).ToString();
            }
            

        }

        protected void Plus_Cart_Click(object sender, EventArgs e)
        {
            int quantityVal = Convert.ToInt32(Quantity.Text);
            Quantity.Text = (quantityVal + 1).ToString();
        }

        protected void List_Image_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "Select")
            {
                String imgUrl = e.CommandArgument.ToString();
                MainImage.ImageUrl = imgUrl;
            }
        }

        protected void Size_Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                String value = e.CommandArgument.ToString();
                HF_Size.Value = value;

                getProductDetail();
            }
        }

        protected void Size_Repeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                
                var btnItem = (Button)e.Item.FindControl("ButtonSize");
                String buttonValue = btnItem.Text;

                if (btnItem != null)
                {
                    String hiddenValue = HF_Size.Value;
                    btnItem.CssClass = (buttonValue == hiddenValue) ? "size-item active" : "size-item";
                }
            }
        }
    }
}