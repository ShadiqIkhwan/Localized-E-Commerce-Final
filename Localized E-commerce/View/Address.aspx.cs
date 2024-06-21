using Localized_E_commerce.Models;
using Localized_E_commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AddressModel = Localized_E_commerce.Models.Address;

namespace Localized_E_commerce.View
{
    public partial class Address : System.Web.UI.Page
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
                    GetAllAddress();
                }
            }
        }

        private void GetAllAddress()
        {
            User sessionUser = (User)Session["user"];

            if (sessionUser != null)
            {
                List<AddressModel> addresses = AddressRepository.GetAllAddress(sessionUser.Id);
                if (addresses != null)
                {
                    Repeater_Address.DataSource = addresses;
                    Repeater_Address.DataBind();
                }

            }
        }

        protected void Address_Change_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int ButtonIndex = ((RepeaterItem)button.NamingContainer).ItemIndex;

            RepeaterItem repeaterItem = (RepeaterItem)Repeater_Address.Items[ButtonIndex];
            HiddenField addressHF = (HiddenField)repeaterItem.FindControl("HF_Address");

            Response.Redirect("~/View/EditAddress.aspx?id=" + addressHF.Value);
        }

        protected void CheckBox_Address_CheckedChanged(object sender, EventArgs e)
        {
            User session = (User )Session["user"];
            CheckBox chk = sender as CheckBox;
            int chkIndex = ((RepeaterItem)chk.NamingContainer).ItemIndex;

            RepeaterItem repeaterItem = (RepeaterItem)Repeater_Address.Items[chkIndex];
            HiddenField addressHF = (HiddenField)repeaterItem.FindControl("HF_Address");

            AddressRepository.ChangeTypeAllToNotPrimary(session.Id, Convert.ToInt32(addressHF.Value));

            GetAllAddress();
        }

        protected void Btn_Add_Address_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/AddAddress.aspx");
        }
    }
}