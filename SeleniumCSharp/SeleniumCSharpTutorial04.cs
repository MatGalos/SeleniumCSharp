using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test, Author("Mateusz Galos", "mateusz.galos@microsoft.wsei.edu.pl"), Description("Facebook Login Verify"), TestCaseSource("DataDrivenTesting")]
        public void Test1(string URLName)
        {
            IWebDriver driver=null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/reg/";
                driver.Url = URLName;
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
                //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='fhbgadskjhgfkj']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch(Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\magic\\source\\repos\\SeleniumCSharp12569\\SeleniumCSharp\\Screenshots\\s1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
            
        }
        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/reg/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://accounts.google.com/");
            return list;
        }
        //[Test, Author("Mateusz Galos", "mateusz.galos@microsoft.wsei.edu.pl"), Description("Facebook Login Verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com/reg/";
        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
        //    emailTextField.SendKeys("Selenium C#");
        //    driver.Quit();
        //}
    }
}
