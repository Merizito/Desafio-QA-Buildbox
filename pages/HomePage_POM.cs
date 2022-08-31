using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using System.Threading;
using AventStack.ExtentReports;

namespace Desafio_QA_Buildbox.pages;

public class HomePage_POM : Pages
{
    public WebDriverWait wait;
    public string _url;

    public HomePage_POM(IWebDriver driver, string url) : base(driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        _url = url;
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.CssSelector, Using = "#page-home > div > header > img")]
    public IWebElement buger_eats_logo { get; set; }

    [FindsBy(How = How.CssSelector, Using = "#page-home > div > main > a")]
    public IWebElement signup_btn { get; set; }

    [FindsBy(How = How.CssSelector, Using = "#page-home > div > main > h1")]
    public IWebElement h1_text { get; set; }


    public bool VerifyElementsOnScreen(ExtentTest test)
    {
        try
        {
            Assert.That(driver.Title, Is.EqualTo("Buger Eats"));
            Assert.IsTrue(buger_eats_logo.Displayed);
            Assert.IsTrue(signup_btn.Displayed);
            Assert.IsTrue(h1_text.Displayed);

            return true;
        }
        catch (Exception e)
        {
            test.Log(Status.Warning, e.Message);
            System.Console.WriteLine(e.Message);
            return false;
        }
    }
}