using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Localized_E_commerce.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                if (!IsPostBack)
                {
                    getUserDetail();
                }
            }
            else
            {
                Response.Redirect("~/View/login.aspx");
            }
            
        }

        public void getUserDetail()
        {
            User sessionUser = (User)Session["user"];
            if (sessionUser != null)
            {
                Lbl_Name.Text = sessionUser.name;
                Lbl_Email.Text = sessionUser.email;
            }
        }

        protected void Info_Pribadi_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/View/EditProfile.aspx");
        }

        protected void Alamat_Pengiriman_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/View/Address.aspx");
        }

        protected void Riwayat_Pesanan_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/View/HistoryTransaction.aspx");
        }
    }

}