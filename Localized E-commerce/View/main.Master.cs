using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Localized_E_commerce.View
{
    public partial class main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Img_Not_Login.Visible = true;
                HL_Not_Login.Visible = true;
                ButtonProfile.Visible = false;
            }
            else
            {
                User sessionUser = (User)Session["user"];

                Img_Not_Login.Visible = false;
                HL_Not_Login.Visible = false;
                ButtonProfile.Visible = true;
                ButtonProfile.Text = "Hi, " + sessionUser.name;
            }
        }

        protected void MenuUser_MenuItemClick(object sender, MenuEventArgs e)
        {
            String value = e.Item.Value;
            if(value == "Profile")
            {
                Response.Redirect("~/View/Profile.aspx");
            }
            else if(value == "Cart")
            {
                Response.Redirect("~/View/Cartlist.aspx");
            }
            else
            {
                Session.Remove("user");
                Response.Redirect("~/View/login.aspx");
            }
        }
    }
}