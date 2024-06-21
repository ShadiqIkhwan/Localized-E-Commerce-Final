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
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductAll();
        }

        private void ProductAll()
        {
            LocalizedDatabaseEntities db = new LocalizedDatabaseEntities();
            var products = ProductRepository.getAllProduct();
            if(products != null)
            {
                Repeater1.DataSource = products;
                Repeater1.DataBind();
            }

        }
    }
}