using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using RegexPattern;

namespace UnitTestCases
{
    [TestClass]
    public class UnitTest1
    {
        public class Tests
        {
            Validation validation;
            [SetUp]
            public void Setup()
            {
                validation = new Validation();
            }
            //<summary>
            //uc1 : Comparing the first name of user
            //</summary>
            [Test]
            public void Comparing_the_First_Name_of_User()
            {


                {
                    //Arrange
                    string firstName = "jayesh";
                    string expected = "First Name is invalid";
                    try
                    {
                        //Act
                        validation.First_Name(firstName);
                    }
                    catch (RegexCustomExpection expection)
                    {
                        //Assert
                        Assert.AreEqual(expected, expection.Message);
                    }
                }
            }
            //<summary>
            //uc2 : Comparing the last name of user
            //</summary>
            [Test]
            public void Comparing_the_Last_Name_of_User()
            {
                //Arrange
                string lastName = "borase";
                string expected = "Last Name is invalid";
                try
                {
                    //Act
                    validation = new Validation();
                    validation.Last_Name(lastName);
                }
                catch (RegexCustomExpection expection)
                {
                    //Assert
                    Assert.AreEqual(expected, expection.Message);
                }
            }
        //<summary>
        //uc3 : Comparing the EmailId of user
        //</summary>
        [Test]
        public void Comparing_the_EmailId_of_User()
        {
            //Arrange
            string Email_Id = "jayshborase";
            string expected = "Email is invalid";
            try
            {
                //Act
                validation = new Validation();
                validation.EmailId(Email_Id);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
            //<summary>
        //uc3 : Comparing the EmailId of user
        //</summary>
        [Test]
        public void Comparing_the_EmailId_of_User()
        {
            //Arrange
            string Email_Id = "jayshborase";
            string expected = "Email is invalid";
            try
            {
                //Act
                validation = new Validation();
                validation.EmailId(Email_Id);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc5 : Comparing the password of user
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User()
        {
            //Arrange
            string password = " ";
            string expected = "Password is invalid";
            try
            {
                //Act                
                validation.Validate_PassWord(password);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
    }

    
  }
