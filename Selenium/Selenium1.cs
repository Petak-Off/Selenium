using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
namespace Tests
{
    public class Tests
    {
        [TestFixture]
        public class MyFirstTest
        {
            private IWebDriver driver;
            private WebDriverWait wait;

            [SetUp]
            public void Start()
            {
              
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            }

            [Test]
            [Obsolete]
            public void FirstTest()
            {
                driver.Url = "http://www.google.com/";
                driver.FindElement(By.ClassName("J9leP")).Click();
                driver.FindElement(By.Id("K68")).Click();
                driver.FindElement(By.Id("K84")).Click();
                driver.FindElement(By.Id("K188")).Click();
                //driver.FindElement(By.Name("q")).SendKeys("webdriver");
                driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
                //_ = wait.Until(ExpectedConditions.TitleIs("веб - Поиск в Google"));
            }   

            [TearDown]
            public void Stop()
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}