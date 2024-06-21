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
    public partial class HistoryTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User session = (User)Session["user"];
            if (session == null) {
                Response.Redirect("~/View/login.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    GetAllHistories();
                }
            }
        }

        public void GetAllHistories()
        {
            User session = (User)Session["user"];
            List<Transaction> transactions = TransactionRepository.GetAllHistory(session.Id);

            if(transactions != null)
            {
                Repeater_History.DataSource = transactions;
                Repeater_History.DataBind();
                
            }
        }
    }
}