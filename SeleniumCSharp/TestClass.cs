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

namespace SeleniumCSharp
{
    [TestFixture]
    public class TestClass:BaseTest
    {
        [Test,Category("Smoke testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField=driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByValue("9");
            element.SelectByIndex(9);
            element.SelectByText("wrz");
        }
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']")) ;
            emailTextField.SendKeys("Selenium C#");
        }
        [Test, Category("Smoke testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
}
