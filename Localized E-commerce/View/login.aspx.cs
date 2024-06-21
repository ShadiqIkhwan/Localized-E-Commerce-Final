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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null) {
                Response.Redirect("~/View/home.aspx");
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            String email = TBox_email_username.Text;
            String password = TBox_password.Text;

            if(email == "" || password == "")
            {
                Label_Status.Text = "Semua field harus diisi";
                return;
            }
            
            User login = UserRepository.login(email, password);

            if (login == null) {
                Label_Status.Text = "User tidak ditemukan";
            }
            else
            {
                Session["user"] = login;
                Response.Redirect("~/View/home.aspx");
            }
        }
    }
}