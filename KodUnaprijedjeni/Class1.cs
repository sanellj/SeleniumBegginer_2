using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace KodUnaprijedjeni
{
    class Class1
    {
        IWebDriver driver = new FirefoxDriver();
        string url = "https://www.google.com";

        [Test]
        public void TestGoogleSearch()
        {
            Wait(1500);
            driver.Navigate().GoToUrl(url);
            Wait(1000);
            IWebElement searchField = driver.FindElement(By.Name("q"));
            searchField.SendKeys("C# selenium tests");
            Wait(2000);
            searchField.SendKeys(Keys.Enter);
            Wait(1000);
            driver.Close();
        }

        private void GoToWebsite (string url, int ms)
        {
            Wait(ms);
            driver.Navigate().GoToUrl(url);
            Wait(ms);
        }

        static private void Wait(int ms)
        {
            System.Threading.Thread.Sleep(ms);  
        }

        [SetUp]
        public void Init()
        {
            driver = new FirefoxDriver();
        }

        [TearDown]
        public void Destroy()
        {
            driver.Close();
        }

    }
}
