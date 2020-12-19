using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;


namespace Vk
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }
        
        public void CrossingTheBanner()
            {
                driver.Manage().Window.Size = new System.Drawing.Size(974, 1040);
                {
                    var element = driver.FindElement(By.CssSelector(".banner-img"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.CssSelector(".logo__link > img"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element).Perform();
                }
            }

            public void NavToggle()
            {
                driver.FindElement(By.Id("main_nav")).Click();
                {
                    var element = driver.FindElement(By.CssSelector("#main_nav > .nav-toggle__bar:nth-child(3)"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element).Perform();
                }
            }

            public void GoToBonusSystem()
            {
                driver.FindElement(By.Id("top_nav")).Click();
                driver.FindElement(By.LinkText("НАКОПИТЕЛЬНАЯ")).Click();
            }

            public void GoToCyberpunk()
            {
                driver.FindElement(By.CssSelector("#main_nav > .nav-toggle__bar:nth-child(3)")).Click();
                driver.FindElement(By.CssSelector(".main-slider__item:nth-child(3) .main-slider__lg-png img")).Click();
            }

            public void GoHome()
            {
                driver.FindElement(By.CssSelector(".logo__link > img")).Click();
            }

            public void OpenHomePage()
            {
                driver.Navigate().GoToUrl("https://steambuy.com/");
            }
            
            public void SearchOfGame(SearchData search)
            {
                driver.FindElement(By.CssSelector(".search__control")).Click();
                {
                    var element = driver.FindElement(By.CssSelector(".search__btn"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element).Perform();
                }
                driver.FindElement(By.CssSelector(".search__control")).SendKeys(search.Search);
                driver.FindElement(By.CssSelector(".search__btn")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.FindElement(By.LinkText("Need for Speed")).Click();
            }
    }
}