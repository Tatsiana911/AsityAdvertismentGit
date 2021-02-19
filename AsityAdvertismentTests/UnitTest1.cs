using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AsityAdvertismentTests

{
    [AllureNUnit]
    public class TestClass
    {
        private IWebDriver driver; /*скачать драйвер FireFox и добавить в папку с проектом*/
        private readonly By _CompanyNameButton =  By.XPath("//input[@id='fnlnmn']");
        private readonly By _phoneNumberButton = By.XPath("//input[@id='phone']");
        private readonly By _priceUSDButton = By.XPath("//input[@id='price-usd']");

        [SetUp]
        public void StartWebBrowser()

        {
            driver = new webdriver.Firefox(@"C:AsityAdvertismentGit\AsityAdvertismentTests\driver\geckodriver.exe");
            driver.Url = "http://localhost:51818/addadv/";
            driver.Manage().Window.Minimize();

        }


        [Test]
        public void CheckIn()
        {
            IWebElement CompanyNameField = driver.FindElement(_CompanyNameButton);
            CompanyNameField.Clear();
            CompanyNameField.SendKeys("DATASPECTRUM UK LIMITED");

            IWebElement phoneNumberField = driver.FindElement(_phoneNumberButton);
            phoneNumberField.Clear();
            phoneNumberField.SendKeys("441424776400");
            Thread.Sleep(2000);

            IWebElement priceUSDField = driver.FindElement(_priceUSDButton);
            priceUSDField.Clear();
            priceUSDField.SendKeys("1100");
            priceUSDField.SendKeys(Keys.Enter);

            Assert.AreEqua1 ("expected", "actusl");
           

        }

    }
    [TearDown]
    public void CloseWebBrowser()
    {
        driver.Quit();
    }
}

