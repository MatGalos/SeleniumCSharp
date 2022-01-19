// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumCSharp
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test,Order(2), Category("Order Skip Atribute")]
        public void TestMethod1()
        {
            IWebDriver driver= new ChromeDriver();
            driver.Url = "https://www.facebook.com/reg/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']")) ;
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
        [Test,Order(1), Category("Order Skip Atribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/reg/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test,Order(0), Category("Order Skip Atribute")]
        public void TestMethod3()
        {
            Assert.Ignore("IE not supporting site");
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com/reg/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

    }
}
