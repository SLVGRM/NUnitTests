﻿using OpenQA.Selenium;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumAndNUnit
{
    [TestFixture]
    public class WebinarPageTests : BaseTest
    {
        [Test]
        public void WebinarPage_ShouldBeVisible_OnMainPage()
        {
            _driver.Navigate().GoToUrl(_webinarPage.webinarPageUrl);
            _driver.Url.Should().Be("https://normativ.kontur.ru/webinars");
        }
    }
}