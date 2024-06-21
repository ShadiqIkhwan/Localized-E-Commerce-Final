using Localized_E_commerce.Factory;
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
    public partial class AddAddress : System.Web.UI.Page
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
            User session = ( User )Session["user"];
            int userId = session.Id;
            String address = Tbox_Address.Text;
            String type = "Not";
            String addressName = TBoxName.Text;
            String phoneNumber = TBoxPhone.Text;

            AddressModel newAddress = AddressFactory.AddAddress(userId, address, type, addressName, phoneNumber);
            AddressRepository.AddAddress(newAddress);

            Response.Redirect("~/View/Address.aspx");
        }

        protected void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Address.aspx");
        }
    }
}