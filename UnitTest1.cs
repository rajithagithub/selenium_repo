using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.ObjectModel;

namespace selenium1
{
    [TestFixture]
    public class FindingDucks
    {
        [Test]
        public void LetsfindsomeDucks()
        {
            IWebDriver driver = new ChromeDriver();
            GooglePage page = new GooglePage(driver);
            page.GotoGoogle();
            page.MaximizeTheWindow();
            page.FindDucks();
            page.ClicktheSearchButton();
            page.ClicktheImagesButton();
            Thread.Sleep(3000);
            page.LetsgobacktoAllResults();
            Thread.Sleep(3000);
            //List of webelements based on partiallink list
            IList<IWebElement> links = driver.FindElements(By.PartialLinkText("Duck"));

            //success if number of elements is >1
            if (links.Count > 1)
            {
                page.wehavefoundducks();
                Thread.Sleep(4000);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("we have no Ducks");
            }
            driver.Quit();

        }


    }
}