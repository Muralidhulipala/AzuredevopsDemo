using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace azuredevopspipelinedemo
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
           //// new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Url = "https://www.geico.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);

        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.Id("ssp-service-zip")).Click();
            driver.FindElement(By.CssSelector("[value='Go']")).Click();

        }
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}