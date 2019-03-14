using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTest
{

    public class SmokeTestForSubscribeToCourse
    {
        IWebDriver driver;
   

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://old.qalight.com.ua/zapisatsya-na-kursy/");
        }

        [TearDown]
        public void TearDown()
        {   
            driver.Quit();
        }


        [Category("Smoke")]
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


            IWebElement sourceDropDown = driver.FindElement(By.XPath("*//option[@value= 'интернет (поисковая система)']"));
            sourceDropDown.Click();


            IWebElement sendButton = driver.FindElement(By.CssSelector("[type='submit']"));
            sendButton.Click();

            IWebElement alert = driver.FindElement(By.CssSelector("div> .alert-success"));


            Assert.That(alert, Is.Not.Null);

        }

    }
}
