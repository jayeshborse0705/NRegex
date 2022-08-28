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
        
    }
}
