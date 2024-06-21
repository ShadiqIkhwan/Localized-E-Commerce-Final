using Localized_E_commerce.Factory;
using Localized_E_commerce.Models;
using Localized_E_commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using AddressModel = Localized_E_commerce.Models.Address;


namespace Localized_E_commerce.View
{
    public partial class EditAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User session = (User)Session["user"];

            if(session == null)
            {
                Response.Redirect("~/View/login.aspx");
            }
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            String newAddress = Tbox_Address.Text;
            String addressId = Request.QueryString["id"];
            if (addressId != null) {
                AddressModel address = AddressFactory.ChangeAddress(newAddress);
                System.Diagnostics.Debug.WriteLine(addressId.ToString());
                AddressRepository.ChangeAddress(Convert.ToInt32(addressId), address);

                Response.Redirect("~/View/Address.aspx");

            }
        }

        protected void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Address.aspx");
        }
    }
}