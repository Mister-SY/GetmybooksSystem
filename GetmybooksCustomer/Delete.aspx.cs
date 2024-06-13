using GetmybooksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerWebsite
{
    public partial class Delete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the id number of the customer to delete from the session object
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
        }

        void DeleteCustomer()
        {
            //function to delete the selected record

            //creates a new instance of the customer website
            clsCustomerCollection CustomerWebsite = new clsCustomerCollection();
            //finds the record to delete
            CustomerWebsite.ThisCustomer.Find(CustomerID);
            //deletes the record
            CustomerWebsite.Delete();

        }

        //event handler for the yes button
        protected void btnYes_Click_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteCustomer();
            //redirect back to the main page
            Response.Redirect("Default.aspx");
        }

        //event handler for the no button
        protected void btnNo_Click_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("Default.aspx");
        }
    }

}