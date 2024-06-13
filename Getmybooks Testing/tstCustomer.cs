using GetmybooksClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Getmybooks_Testing
{
    [TestClass]
    public class tstCustomer
    {
        //some test data
        //string FirstName = "Steve";
        //string LastName = "Webb";
        //string CustomerAddress = "Test Address LE9 2CJ";
        //string CustomerEmail = "EmailTest@25.com";
        //string PhoneNumber = "00006541294";


        [TestMethod]
        public void InstanceOK()
        {
            //creates an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //tests to see if it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerID()
        {
            //creates an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //creates some test data for the customer id
            int TestData = 1;
            //assigns customer data
            ACustomer.CustomerID = TestData;
            //tests to see if the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        public void FirstName()
        {
            //creates an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //creates some test data for the customer first name
            string TestData = "Steve";
            //assigns customer data
            ACustomer.FirstName = TestData;
            //tests to see if the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        public void LastName()
        {
            //creates an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //creates some test data for the customer last name
            string TestData = "Webb";
            //assigns customer data
            ACustomer.LastName = TestData;
            //tests to see if the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        public void CustomerAddress()
        {
            //creates an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //creates some test data for the customer address
            string TestData = "Test Address LE9 2CJ";
            //assigns customer data
            ACustomer.CustomerAddress = TestData;
            //tests to see if the two values are the same
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        public void CustomerEmail()
        {
            //creates an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //creates some test data for the customer email
            string TestData = "EmailTest@25.com";
            //assigns customer data
            ACustomer.CustomerEmail = TestData;
            //tests to see if the two values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        public void PhoneNumber()
        {
            //creates an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //creates some test data for the customer phone number
            string TestData = "00006541294";
            //assigns customer data
            ACustomer.PhoneNumber = TestData;
            //tests to see if the two values are the same
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);
        }

        public void Username()
        {
            //creates an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //creates some test data for the username
            string TestData = "Steve123";
            //assigns customer data
            ACustomer.Username = TestData;
            //tests to see if the two values are the same
            Assert.AreEqual(ACustomer.Username, TestData);
        }

        public void Password()
        {
            //creates an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //creates some test data for the password
            string TestData = "password1";
            //assigns customer data
            ACustomer.Password = TestData;
            //tests to see if the two values are the same
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        public void FindMethodOk()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            bool Found = false;
            //some test data to use with the method
            int CustomerID = 1;
            //invokes the method
            Found = ACustomer.Find(CustomerID);
            //tests to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            bool Found = false;
            //boolean variable to record if the data is ok
            bool Ok = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invokes the method
            Found = ACustomer.Find(CustomerID);
            //checks the customer id
            if (ACustomer.CustomerID != 1)
            {
                Ok = false;
            }
            //tests to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            bool Found = false;
            //boolean variable to record if the data is ok
            bool Ok = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invokes the method
            Found = ACustomer.Find(CustomerID);
            //checks the customer first name
            if (ACustomer.FirstName != "Steve")
            {
                Ok = false;
            }
            //tests to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            bool Found = false;
            //boolean variable to record if the data is ok
            bool Ok = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invokes the method
            Found = ACustomer.Find(CustomerID);
            //checks the customer last name
            if (ACustomer.FirstName != "Webb")
            {
                Ok = false;
            }
            //tests to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestCustomerAddress()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            bool Found = false;
            //boolean variable to record if the data is ok
            bool Ok = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invokes the method
            Found = ACustomer.Find(CustomerID);
            //checks the customer address
            if (ACustomer.CustomerAddress != "Test Address LE9 2CJ")
            {
                Ok = false;
            }
            //tests to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestCustomerEmail()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            bool Found = false;
            //boolean variable to record if the data is ok
            bool Ok = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invokes the method
            Found = ACustomer.Find(CustomerID);
            //checks the customer email
            if (ACustomer.CustomerEmail != "EmailTest@25.com")
            {
                Ok = false;
            }
            //tests to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestPhoneNumber()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            bool Found = false;
            //boolean variable to record if the data is ok
            bool Ok = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invokes the method
            Found = ACustomer.Find(CustomerID);
            //checks the customer number
            if (ACustomer.PhoneNumber != "000065412947")
            {
                Ok = false;
            }
            //tests to see if the result is correct
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestUsername()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            bool Found = false;
            //boolean variable to record if the data is ok
            bool Ok = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invokes the method
            Found = ACustomer.Find(CustomerID);
            //checks the customer username
            if (ACustomer.Username != "Steve123")
            {
                Ok = false;
            }
            //tests to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestPassword()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            bool Found = false;
            //boolean variable to record if the data is ok
            bool Ok = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invokes the method
            Found = ACustomer.Find(CustomerID);
            //checks the customer password
            if (ACustomer.Password != "password1")
            {
                Ok = false;
            }
            //tests to see if the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //tests to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //tests to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "A"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "Aa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "Aaaaaaaaa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "Aaaaaaaaaa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "Aaaaaaaaaaa"; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "Aaaaa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(100, 'a'); //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = ""; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //tests to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "A"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "Aa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "Aaaaaaaaa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "Aaaaaaaaaa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "Aaaaaaaaaaa"; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "Aaaaa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(100, 'a'); //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //creates an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = ""; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //tests to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "A"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "Aa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "Aaaaaaaaa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "Aaaaaaaaaa"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "Aaaaaaaaaaa"; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "Aaaaa"; //this should be ok                                  
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(100, 'a'); //this should fail
            //invokes the method
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmail = ""; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "@email.com"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "S@email.com"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "SteveWebb1234567890@email.com"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "SteveWebb12345678901@email.com"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "SteveWebb123456789012@email.com"; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "SteveWebb1@email.com"; //this should be ok
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(300, 'e'); //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "0"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "01"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "0123456789"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "01234567890"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "012345678900"; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "012345"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(110, 'e'); //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string Username = ""; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string Username = "A"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string Username = "Aa"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string Username = "Aaaaaaaaaaaaa"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void UsernameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string Username = "Aaaaaaaaaaaaa"; //this should pass
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string Username = "Aaaaaaaaaaaaaa"; //this should fail
            //invokes the method
            Error = ACustomer.Valid(FirstName, LastName, CustomerAddress, CustomerEmail, PhoneNumber, Username, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}
