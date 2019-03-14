using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationTest
{

    public class SmokeTestForSubscribeToCourse
    {
        IWebDriver driver;
        IWebElement element;
   

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://old.qalight.com.ua/zapisatsya-na-kursy/");
          
       
                //driver.Navigate().Refresh();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }



        [Test]
        public void TestMethod1()
        {

            IWebElement surname = driver.FindElement(By.Id("z_sender0"));
            surname.SendKeys("Surname");

            IWebElement name = driver.FindElement(By.Id("z_text1"));
            name.SendKeys("Name");

            IWebElement phone = driver.FindElement(By.Id("z_text0"));
            phone.SendKeys("0111111111");

            IWebElement email = driver.FindElement(By.Id("z_sender1"));
            email.SendKeys("test@test.com");

            IWebElement skype = driver.FindElement(By.Id("z_text2"));
            skype.SendKeys("test");

            IWebElement sourceDropDown = driver.FindElement(By.CssSelector("[name='_e926ba2b2813f56de8fc13877057e908']"));
            sourceDropDown.Click();

            IWebElement sendButton = driver.FindElement(By.CssSelector("[type='submit']"));

            sendButton.Click();

     


            //var windowHandle = driver.CurrentWindowHandle;

            ////IWebElement element = driver.FindElement(By.CssSelector("test css"));

            ////var elements = driver.FindElements(By.CssSelector("test multi css"));





        }


    }
}
