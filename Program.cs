using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void initialize() { 
        PropertiesCollection.driver = new ChromeDriver();

        

        //Navigating to google and finding the element
        PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");

        }
        [Test]
        public void ExecuteTest()
        {


            //Login to application

            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObjects pageEA = pageLogin.Login("Test", "Text");

            pageEA.FillUserForm("MA", "Jose", "Rafael");




            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            ////Initial
            //SeleniumSetMethods.EnterText("Initial", "TestText", PropertyType.Name);

            //Console.WriteLine("The value from my title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            ////Click 
            //SeleniumSetMethods.Click("Save", PropertyType.Name);



        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed Browser");
        }
    }
}
