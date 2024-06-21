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
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Submit_Profile.Visible = false;
            Cancel_Profile.Visible = false;
            if (Session["user"] != null)
            {
                getUserDetail();
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


        protected void Button_Edit_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            if (user != null) {
                Tbox_Nama_Depan.Text = user.name;
                TBox_Date.Text = user.dob != null ? user.dob?.ToString("yyyy-MM-dd") : "";
                Gender_Radio_Button_List.SelectedValue = user.gender;

                Submit_Profile.Visible = true;
                Cancel_Profile.Visible = true;
            }
        }

        protected void Submit_Profile_Click(object sender, EventArgs e)
        {
            User session = (User)Session["user"];

            String name = Tbox_Nama_Depan.Text;
            String dobString = TBox_Date.Text;
            DateTime dob = DateTime.Now;
            if(dobString != "")
            {
                dob = DateTime.Parse(dobString);
            }

            String gender = Gender_Radio_Button_List.SelectedValue;

            User user = UserFactory.changeProfile(name, dob, gender);
            UserRepository.UpdateProfile(session.Id, user);

            Session["user"] = new User()
            {
                name = name,
                email = session.email,
                username = session.username,
                dob = dob,
                gender = gender,
                Id = session.Id,
                password = session.password,
            };

            Response.Redirect("~/View/Profile.aspx");
        }

        protected void Cancel_Profile_Click(object sender, EventArgs e)
        {
            Tbox_Nama_Depan.Text = "";
            TBox_Date.Text = "";
            Gender_Radio_Button_List.ClearSelection();
        }
    }
}