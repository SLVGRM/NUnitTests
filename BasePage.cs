﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumAndNUnit

{
    public class BasePage
    {
        protected IWebDriver _driver;
        
        
        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }
    }
}