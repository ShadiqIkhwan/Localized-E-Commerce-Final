using Localized_E_commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Localized_E_commerce.View
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            String name = TBox_name.Text;
            String username = TBox_username.Text;
            String email = TBox_email.Text;
            String password = TBox_password.Text;   
            String confirm_password = TBox_confirm_password.Text;

            if (name == "" || username == "" || email == "" || password == "" || confirm_password == "")
            {
                Label_Status.Text = "Semua field harus disi";
                return;
            }
            else if (password != confirm_password)
            {
                Label_Status.Text = "Password tidak sama";
                return;
            }
            else if (email.IndexOf("@") == -1 || email.IndexOf("@") == 0 || email.IndexOf("@") == email.Length - 1) {
                Label_Status.Text = "Email harus menggunakan format yang benar";
                return;
            }

            Label_Status.Text = UserRepository.register(name, username, email, password);
            return;
        }
    }
}