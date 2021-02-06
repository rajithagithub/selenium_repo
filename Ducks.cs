using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium1
{
    public class GooglePage
    {
        IWebDriver driver;
        By SearchBar = By.Name("q");
        By SearchButton = By.XPath("//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]");
        By ImfeelingLucky = By.XPath("//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[2]");
        By ImagesButton = By.ClassName("hide-focus-ring");
        By Gmail = By.XPath("//*[@id='gbw']/div/div/div[1]/div[1]/a");
        By Apps = By.XPath("//*[@id='gbwa']/div/a");
        By All = By.XPath("//*[@id='yDmH0d']/div[2]/c-wiz/div[1]/div/div[1]/div[1]/div/div/a[1]");

        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void GotoGoogle()
        {
            driver.Url = ("https://www.google.com/");
        }
        public void MaximizeTheWindow()
        {
            driver.Manage().Window.Maximize();
        }
        public void FindDucks()
        {
            driver.FindElement(SearchBar).SendKeys("Ducks");
        }
        public void ClicktheSearchButton()
        {
            driver.FindElement(SearchButton).Click();
        }
        public void ClicktheImagesButton()
        {
            driver.FindElement(ImagesButton).Click();
        }
        public void LetsgobacktoAllResults()
        {
            driver.FindElement(All).Click();
        }
        public void wehavefoundducks()
        {
            driver.Url = ("https://large-type.com/#we%20have%20found%20ducks");
        }
    }
}