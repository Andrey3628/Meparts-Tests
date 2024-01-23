using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mepartTestsProject
{
	class PageCart						
    {
        IWebDriver driver;
        private WebDriverWait wait;
        private int sleep = 2500;

        [SetUp]
		public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://dev.mepart.ru/personal/cart/");
            driver.Manage().Window.Maximize();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [Test]
		public void test()
        {
            driver.FindElement(By.Id("input-autocomplit")).Click();
            Thread.Sleep(sleep);
            driver.FindElement(By.ClassName("input-group")).FindElement(By.TagName("input")).SendKeys("A113707110CA");
            Thread.Sleep(sleep); 
            driver.FindElement(By.Id("input-autocomplit-submit")).Click();
            Thread.Sleep(sleep);
            driver.FindElement(By.XPath("//*[contains(text(),'CHERY')]")).Click();
            Thread.Sleep(sleep); 
            driver.FindElement(By.ClassName("btn--bigbuy")).Click();
            Thread.Sleep(sleep);
            driver.FindElement(By.Id("basket-add-popup-submit")).Click();
            Thread.Sleep(sleep);
            driver.FindElement(By.Id("top-basket-counter")).Click();
            Thread.Sleep(sleep);
            driver.FindElement(By.ClassName("red-btn")).Click();
            Thread.Sleep(sleep);
            driver.FindElement(By.ClassName("checkout__content")).FindElement(By.Name("NAME")).SendKeys("Andrey");
            Thread.Sleep(sleep);
            driver.FindElement(By.ClassName("checkout__content")).FindElement(By.Name("PHONE")).SendKeys("9997776655");
            Thread.Sleep(sleep);
            driver.FindElements(By.ClassName("checkout__content"))[1].FindElements(By.TagName("input"))[1].Click();
            Thread.Sleep(sleep);
            driver.FindElement(By.XPath("//*[contains(text(),'Оплата онлайн')]")).Click();
            Thread.Sleep(sleep);
            driver.FindElements(By.ClassName("checkout__content"))[5].FindElement(By.TagName("button")).Click();
            Thread.Sleep(sleep); 
        }

        [TearDown]
		public void closeBrowser()
        {
            driver.Close();
        }

    }
}