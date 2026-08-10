using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Automation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a reference for Chrome Driver
            IWebDriver driver = new ChromeDriver();

            // Go to Google page
            driver.Navigate().GoToUrl("https://www.google.com/");

            // Make the browser full screen
            driver.Manage().Window.Maximize();

            // Find the element
            IWebElement webElement = driver.FindElement(By.Name("q"));

            // Type something in the search box
            webElement.SendKeys("This is the best automation course EVER!");

            // Close the browser
            driver.Quit();
        }
    }
}
