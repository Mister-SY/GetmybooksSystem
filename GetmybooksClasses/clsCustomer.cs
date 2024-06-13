using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetmybooksClasses
{
    
    public class clsCustomer
    {
        //private data member for the CustomerID
        private Int32 mCustomerID;
        //public property for the CustomerID
        public int CustomerID
        {
            get
            {
                //returns the private data
                return mCustomerID;
            }
            set
            {
                //sets the value of the private data member
                mCustomerID = value;
            }

        }

        //private data member for the FirstName
        private string mFirstName;
        //public property for the FirstName
        public string FirstName
        {
            get
            {
                //returns the private data
                return mFirstName;
            }
            set
            {
                //sets the value of the private data member
                mFirstName = value;
            }

        }

        //private data member for the LastName
        private string mLastName;
        //public property for the LastName
        public string LastName
        {
            get
            {
                //returns the private data
                return mLastName;
            }
            set
            {
                //sets the value of the private data member
                mLastName = value;
            }

        }

        //private data member for the CustomerAddress
        private string mCustomerAddress;
        //public property for the CustomerAddress
        public string CustomerAddress
        {
            get
            {
                //returns the private data
                return mCustomerAddress;
            }
            set
            {
                //sets the value of the private data member
                mCustomerAddress = value;
            }

        }

        //private data member for the CustomerEmail
        private string mCustomerEmail;
        //public property for the CustomerEmail
        public string CustomerEmail
        {
            get
            {
                //returns the private data
                return mCustomerEmail;
            }
            set
            {
                //sets the value of the private data member
                mCustomerEmail = value;
            }

        }

        //private data member for the PhoneNumber
        private string mPhoneNumber;
        //public property for the PhoneNumber
        public string PhoneNumber
        {
            get
            {
                //returns the private data
                return mPhoneNumber;
            }
            set
            {
                //sets the value of the private data member
                mPhoneNumber = value;
            }

        }

        //private data member for the Username
        private string mUsername;
        //public property for the Username
        public string Username
        {
            get
            {
                //returns the private data
                return mUsername;
            }
            set
            {
                //sets the value of the private data member
                mUsername = value;
            }

        }

        //private data member for the Password
        private string mPassword;
        //public property for the Password
        public string Password
        {
            get
            {
                //returns the private data
                return mPassword;
            }
            set
            {
                //sets the value of the private data member
                mPassword = value;
            }

        }

        
        public bool Find(int customerID)
        {
            //creates an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //adds the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //executes the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copies the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                //returns that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string FirstName, string LastName, string CustomerAddress, string CustomerEmail, string PhoneNumber, string Username, string Password)
        {
            //create a string variable to store the error
            string Error = "";

            //if the FirstName is blank
            if (FirstName.Length == 0)
            {
                //records the error
                Error = Error + "The first name field must not be blank.";
            }
            //if the FirstName is greater than 10 characters
            if (FirstName.Length > 10)
            {
                //records the error
                Error = Error + "The first name must be less than 10 characters.";
            }

            //if the LastName is blank
            if (LastName.Length == 0)
            {
                //records the error
                Error = Error + "The last name field must not be blank.";
            }
            //if the LastName is greater than 10 characters
            if (LastName.Length > 10)
            {
                //records the error
                Error = Error + "The last name must be less than 10 characters.";
            }

            //if the CustomerAddress is blank
            if (CustomerAddress.Length == 0)
            {
                //records the error
                Error = Error + "The customer address must not be blank.";
            }
            //if the CustomerAddress is greater than 50 characters
            if (CustomerAddress.Length > 50)
            {
                //records the error
                Error = Error + "The customer address must be less than 50 characters.";
            }

            //if the CustomerEmail is blank
            if (CustomerEmail.Length == 0)
            {
                //records the error
                Error = Error + "The customer email must not be blank.";
            }
            //if the CustomerEmail is greater than 30 characters
            if (CustomerEmail.Length > 30)
            {
                //records the error
                Error = Error + "The customer email must be less than 30 characters.";
            }

            //if the PhoneNumber is blank
            if (PhoneNumber.Length == 0)
            {
                //records the error
                Error = Error + "The phone number must not be blank.";
            }
            //if the PhoneNumber is greater than 11 characters
            if (PhoneNumber.Length < 11)
            {
                //records the error
                Error = Error + "The phone number must be more than 11 characters.";
            }
            //if the PhoneNumber is lower than 11 characters
            if (PhoneNumber.Length > 11)
            {
                //records the error
                Error = Error + "The phone number must be less than 11 characters.";
            }

            //if the Username is blank
            if (Username.Length == 0)
            {
                //records the error
                Error = Error + "The username must not be blank.";
            }
            //if the Username is greater than 15 characters
            if (Username.Length > 15)
            {
                //records the error
                Error = Error + "The username must be less than 15 characters.";
            }

            //if the Password is blank
            if (Password.Length == 0)
            {
                //records the error
                Error = Error + "The password must not be blank.";
            }
            //if the Password is greater than 15 characters
            if (Password.Length > 15)
            {
                //records the error
                Error = Error + "The password must be less than 15 characters.";
            }

            //return any error messages
            return Error;
        }

    }
}
