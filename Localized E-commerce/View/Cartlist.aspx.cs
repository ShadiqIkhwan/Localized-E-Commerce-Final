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
    public partial class Cartlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User session = (User)Session["user"];

            if (session == null)
            {
                Response.Redirect("~/View/login.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    GetAllCartByUserId(session.Id);
                }
            }
        }

        protected void GetAllCartByUserId (int userId)
        {

            var carts = CartRepository.getCartByUserId(userId);
            if(carts != null)
            {
                Checkbox_Repeater.DataSource = carts;
                Checkbox_Repeater.DataBind();
            }

        }

        protected void chkAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void chkCarts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Btn_Checkout_Click(object sender, EventArgs e)
        {
            User session = (User)Session["user"];
            
            foreach (RepeaterItem item in Checkbox_Repeater.Items)
            {
                CheckBox chkItem = (CheckBox)item.FindControl("Chk_Item");
                
                if (chkItem != null && chkItem.Checked)
                {
                    if (chkItem.Checked)
                    {
                        HiddenField HFPoductId= (HiddenField)item.FindControl("HF_ProductID");
                        int productId = Convert.ToInt32(HFPoductId.Value);

                        HiddenField HFQuantity = (HiddenField)item.FindControl("HF_Quantity");
                        int quantity = Convert.ToInt32(HFQuantity.Value);

                        HiddenField HF_size = (HiddenField)item.FindControl("HF_Size");
                        String size = HF_size.Value;

                        HiddenField HF_Id = (HiddenField)item.FindControl("HF_ID");
                        int cartId = Convert.ToInt32(HF_Id.Value);

                        Transaction transaction = TransactionFactory.AddToTransaction(session.Id);
                        TransactionRepository.AddToTransaction(transaction); 

                        TransactionDetail transactionDetail = TransactionFactory.AddToTransactionDetail(transaction.Id, productId, quantity, size);
                        TransactionRepository.AddToTransactionDetail(transactionDetail);

                        CartRepository.DeleteCartByID(cartId);



                        Response.Redirect("~/View/home.aspx");
                    }
                    
                }
            }
        }

        protected void Remove_Cart_Click(object sender, EventArgs e)
        {
            Button ButtonDelete = sender as Button;
            int ButtonIndex = ((RepeaterItem)ButtonDelete.NamingContainer).ItemIndex;

            RepeaterItem repeaterItem = (RepeaterItem)Checkbox_Repeater.Items[ButtonIndex];
            HiddenField idHF = (HiddenField)repeaterItem.FindControl("HF_ID");

            int cartId = Convert.ToInt32(idHF.Value);
            CartRepository.DeleteCartByID(cartId);

            User session = (User)Session["user"];

            GetAllCartByUserId(session.Id);
        }
    }
}