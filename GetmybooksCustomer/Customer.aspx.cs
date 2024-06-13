using GetmybooksClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerWebsite
{
    public partial class Customer : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 CustomerID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the customer id to be processed
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
            if (IsPostBack == false)
            {
                //populate the list of customers
                DisplayCustomer();
                //if this is not a new record
                if (CustomerID != -1)
                {
                    //displays the current data for the record
                    DisplayCustomer();
                }
            }
        }

        //event handler for the ok button
        protected void btnOk_Click_Click(object sender, EventArgs e)
        {

            if (CustomerID == -1)
            {
                //adds the new record
                Add();
            }
            else
            {
                //updates the record
                Update();
            }

            //creates a new instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //captures the first name
            string FirstName = txtFirstName.Text;
            //captures the last name
            string LastName = txtLastName.Text;
            //captures the customer address
            string CustomerAddress = txtCustomerAddress.Text;
            //captures the customer email
            string CustomerEmail = txtCustomerEmail.Text;
            //captures the phone number
            string PhoneNumber = txtPhoneNumber.Text;
            //captures the username
            string Username = txtUsername.Text;
            //captures the password
            string Password = txtPassword.Text;
            //variable to store any error messages
            string Error = "";
            //validates the data
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            if (Error == "")
            {
                //captures the first name
                ACustomer.FirstName = FirstName;
                //captures the last name
                ACustomer.LastName = LastName;
                //captures the customer address
                ACustomer.CustomerAddress = CustomerAddress;
                //captures the customer email
                ACustomer.CustomerEmail = CustomerEmail;
                //captures the phone number
                ACustomer.PhoneNumber = PhoneNumber;
                //captures the username
                ACustomer.Username = Username;
                //captures the password
                ACustomer.Password = Password;
                //store the customer in the session object
                Session["ACustomer"] = ACustomer;
                //redirect to the main page
                Response.Redirect("Default.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }

            
        }

        //function for adding new records
        void Add() 
        {
            //creates an instance of the customer details page
            clsCustomerCollection CustomerWebsite = new clsCustomerCollection();
            //validates the data on the web form
            string Error = CustomerWebsite.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtCustomerAddress.Text, txtCustomerEmail.Text, txtPhoneNumber.Text, txtUsername.Text, txtPassword.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //gets the data entered by the user
                CustomerWebsite.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerWebsite.ThisCustomer.LastName = txtLastName.Text;
                CustomerWebsite.ThisCustomer.CustomerAddress = txtCustomerAddress.Text;
                CustomerWebsite.ThisCustomer.CustomerEmail = txtCustomerEmail.Text;
                CustomerWebsite.ThisCustomer.PhoneNumber = txtPhoneNumber.Text;
                CustomerWebsite.ThisCustomer.Username = txtUsername.Text;
                CustomerWebsite.ThisCustomer.Password = txtPassword.Text;
                //adds the record
                CustomerWebsite.Add();
            }
            else
            {
                //reports an error
                lblError.Text = "There were problems with the data entered." + Error;
            }

        }

        //function for updating records
        void Update()
        {
            //creates an instance of the customer details page
            GetmybooksClasses.clsCustomerCollection CustomerWebsite = new GetmybooksClasses.clsCustomerCollection();
            //validates the data on the web form
            string Error = CustomerWebsite.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtCustomerAddress.Text, txtCustomerEmail.Text, txtPhoneNumber.Text, txtUsername.Text, txtPassword.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //finds the record to update
                CustomerWebsite.ThisCustomer.Find(CustomerID);
                //gets the data entered by the user
                CustomerWebsite.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerWebsite.ThisCustomer.LastName = txtLastName.Text;
                CustomerWebsite.ThisCustomer.CustomerAddress = txtCustomerAddress.Text;
                CustomerWebsite.ThisCustomer.CustomerEmail = txtCustomerEmail.Text;
                CustomerWebsite.ThisCustomer.PhoneNumber = txtPhoneNumber.Text;
                CustomerWebsite.ThisCustomer.Username = txtUsername.Text;
                CustomerWebsite.ThisCustomer.Password = txtPassword.Text;
                //updates the record
                CustomerWebsite.Update();
            }
            else
            {
                //reports an error
                lblError.Text = "There were problems with the data entered." + Error;
            }

        }

        void DisplayCustomer()
        {
            //creates an instance of customer website
            clsCustomerCollection CustomerWebsite = new clsCustomerCollection();
            //finds the record to update
            CustomerWebsite.ThisCustomer.Find(CustomerID);
            //displays the data for this record
            txtFirstName.Text = CustomerWebsite.ThisCustomer.FirstName;
            txtLastName.Text = CustomerWebsite.ThisCustomer.LastName;
            txtCustomerAddress.Text = CustomerWebsite.ThisCustomer.CustomerAddress;
            txtCustomerEmail.Text = CustomerWebsite.ThisCustomer.CustomerEmail;
            txtPhoneNumber.Text = CustomerWebsite.ThisCustomer.PhoneNumber;
            txtUsername.Text = CustomerWebsite.ThisCustomer.Username;
            txtPassword.Text = CustomerWebsite.ThisCustomer.Password;
        }

        //event handler for the cancel button
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirects to the main page
            Response.Redirect("Default.aspx");
        }
    }
}