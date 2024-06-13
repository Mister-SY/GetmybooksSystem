using CustomerWebsite;
using GetmybooksClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Getmybooks_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //creates an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //tests to see if it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOk()
        {
            //creates an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //some test data that is assigned to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //adds an item to the list
            //creates the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Steve";
            TestItem.LastName = "Webb";
            TestItem.CustomerAddress = "Test Address LE9 2CJ";
            TestItem.CustomerEmail = "EmailTest@25.com";
            TestItem.PhoneNumber = "00006541294";
            TestItem.Username = "Steve123";
            TestItem.Password = "password1";
            //adds the item to the test list
            TestList.Add(TestItem);
            //assigns the data to the property
            AllCustomers.CustomerList = TestList;
            //tests to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //creates an instance of the class we want
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //creates some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 1;
            TestCustomer.FirstName = "Steve";
            TestCustomer.LastName = "Webb";
            TestCustomer.CustomerAddress = "Test Address LE9 2CJ";
            TestCustomer.CustomerEmail = "EmailTest@25.com";
            TestCustomer.PhoneNumber = "00006541294";
            TestCustomer.Username = "Steve123";
            TestCustomer.Password = "password1";
            //assigns the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //tests to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            //creates an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //some test data that is assigned to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //adds an item to the list
            //creates the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Steve";
            TestItem.LastName = "Webb";
            TestItem.CustomerAddress = "Test Address LE9 2CJ";
            TestItem.CustomerEmail = "EmailTest@25.com";
            TestItem.PhoneNumber = "00006541294";
            TestItem.Username = "Steve123";
            TestItem.Password = "password1";
            //adds the item to the test list
            TestList.Add(TestItem);
            //assigns the data to the property
            AllCustomers.CustomerList = TestList;
            //tests to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //creates an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 3;
            TestItem.FirstName = "Sam";
            TestItem.LastName = "Blue";
            TestItem.CustomerAddress = "Test Address LE5 2CJ";
            TestItem.CustomerEmail = "EmailTest@27.com";
            TestItem.PhoneNumber = "00336541299";
            TestItem.Username = "Bluezzz";
            TestItem.Password = "password3";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //adds the record
            PrimaryKey = AllCustomers.Add();
            //sets the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //finds the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //tests to see if the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //creates an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 3;
            TestItem.FirstName = "Sam";
            TestItem.LastName = "Blue";
            TestItem.CustomerAddress = "Test Address LE5 2CJ";
            TestItem.CustomerEmail = "EmailTest@27.com";
            TestItem.PhoneNumber = "00336541299";
            TestItem.Username = "Bluezzz";
            TestItem.Password = "password3";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //adds the record
            PrimaryKey = AllCustomers.Add();
            //sets the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //finds the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //deletes the record
            AllCustomers.Delete();
            //now finds the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //tests to see if the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //creates an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Steve";
            TestItem.LastName = "Webb";
            TestItem.CustomerAddress = "Test Address LE9 2CJ";
            TestItem.CustomerEmail = "EmailTest@25.com";
            TestItem.PhoneNumber = "00006541294";
            TestItem.Username = "Steve123";
            TestItem.Password = "password1";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //adds the record
            PrimaryKey = AllCustomers.Add();
            //sets the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.CustomerID = 3;
            TestItem.FirstName = "Sam";
            TestItem.LastName = "Blue";
            TestItem.CustomerAddress = "Test Address LE5 2CJ";
            TestItem.CustomerEmail = "EmailTest@27.com";
            TestItem.PhoneNumber = "00336541299";
            TestItem.Username = "Bluezzz";
            TestItem.Password = "password3";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //updates the record
            AllCustomers.Update();
            //finds the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //tests to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByCustomerIDMethodOk()
        {
            //creates an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //creates an instance of the filtered data
            clsCustomerCollection FilteredCustomerID = new clsCustomerCollection();
            //applies a blank int (should return all record)
            FilteredCustomerID.ReportByCustomerID(1);
            //tests to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomerID.Count);
        }

        [TestMethod]
        public void ReportByCustomerIDNotFound()
        {
            //creates an instance of the filtered data
            clsCustomerCollection FilteredCustomerID = new clsCustomerCollection();
            //applies a blank int (should return all record)
            FilteredCustomerID.ReportByCustomerID(0);
            //tests to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomerID.Count);
        }

        [TestMethod]
        public void ReportByCustomerIDTestDataFound()
        {
            //creates an instance of the filtered data
            clsCustomerCollection FilteredCustomerID = new clsCustomerCollection();
            //var to store outcome
            Boolean Ok = true;
            //apply a customer id that doesn't exist
            FilteredCustomerID.ReportByCustomerID(7);
            //checks that the correct number of records have been found
            if (FilteredCustomerID.Count == 2)
            {
                //checks that the customer id is 1
                if (FilteredCustomerID.CustomerList[0].CustomerID != 1)
                {
                    Ok = false;
                }
                //checks that the customer id is 2
                if (FilteredCustomerID.CustomerList[1].CustomerID != 2)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            //tests to see that there are no records
            Assert.IsTrue(Ok);
        }
    }
}
