using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerWebsite
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //event handler for the return to homepage button
        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("Default.aspx");
        }
    }
}