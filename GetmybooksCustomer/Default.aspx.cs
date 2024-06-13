using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GetmybooksClasses;

namespace CustomerWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayCustomers();
            }
        }

        void DisplayCustomers()
        {
            //creates an instance of the Customer Collection
            GetmybooksClasses.clsCustomerCollection Customers = new GetmybooksClasses.clsCustomerCollection();
            //sets the name of the primary key
            lstCustomer.DataValueField = "CustomerID";
            //sets the data field to display
            lstCustomer.DataTextField = "Username";
            //binds the data to the list
            lstCustomer.DataBind();
        }

        //event handler for the edit button
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 CustomerID;
            //if a record has been selected from the list
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
                //store the data in the session
                Session["CustomerID"] = CustomerID;
                //redirect to the edit page
                Response.Redirect("Customer.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        //event handler for the delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 CustomerID;
            //if a record has been selected from the list
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
                //store the data in the session
                Session["CustomerID"] = CustomerID;
                //redirect to the delete page
                Response.Redirect("Delete.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
            
        }

        //event handler for the view orders button
        protected void btnOrders_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record
            Int32 CustomerID;
            //if a record has been selected from the list
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the primary key value of the record
                CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
                //store the data in the session
                Session["CustomerID"] = CustomerID;
                //redirects to the view orders page
                Response.Redirect("Orders.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record first.";
            }

        }

        //event handler for the create new account button
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["CustomerID"] = -1;
            //redirect back to the customer details page
            Response.Redirect("Customer.aspx");
        }
    }
}