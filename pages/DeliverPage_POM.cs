using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using System.Threading;
using AventStack.ExtentReports;

namespace Desafio_QA_Buildbox.pages;

public class DeliverPage_POM : Pages
{
    public WebDriverWait wait;
    public string _url;

    public DeliverPage_POM(IWebDriver driver, string url) : base(driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        _url = url;
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.CssSelector, Using = "#page-deliver > header > a")]
    public IWebElement back_home_btn { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form")]
    public IWebElement form { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(2) > div:nth-child(2) > div:nth-child(1) > input[type=text]")]
    public IWebElement fullName_input { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(2) > div:nth-child(2) > div:nth-child(2) > input[type=text]")]
    public IWebElement cpf_input { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(2) > div:nth-child(3) > div:nth-child(1) > input[type=email]")]
    public IWebElement email_input { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(2) > div:nth-child(3) > div:nth-child(2) > input[type=text]")]
    public IWebElement whatsapp_input { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(3) > div:nth-child(2) > div:nth-child(1) > input[type=text]")]
    public IWebElement postalcode_input { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(3) > div:nth-child(2) > div:nth-child(2) > input[type=button]")]
    public IWebElement search_postalcode_btn { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(3) > div.field > input[type=text]")]
    public IWebElement address_input { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(3) > div:nth-child(4) > div:nth-child(1) > input[type=text]")]
    public IWebElement address_number_input { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(3) > div:nth-child(4) > div:nth-child(2) > input[type=text]")]
    public IWebElement address_details_input { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(3) > div:nth-child(5) > div:nth-child(1) > input[type=text]")]
    public IWebElement district_input { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(3) > div:nth-child(5) > div:nth-child(2) > input[type=text]")]
    public IWebElement city_input { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(4) > ul > li:nth-child(1)")]
    public IWebElement motorcycle_method { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(4) > ul > li:nth-child(2)")]
    public IWebElement bicycle_method { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(4) > ul > li:nth-child(3)")]
    public IWebElement van_or_car_method { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > div > input[type=file]")]
    public IWebElement cnh_image_upload { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > button")]
    public IWebElement submit_btn { get; set; }


    public bool VerifyElementsOnScreen(ExtentTest test)
    {
        try
        {
            Assert.That(driver.Title, Is.EqualTo("Buger Eats"));
            Assert.IsTrue(form.Displayed);
            Assert.IsTrue(back_home_btn.Displayed);
            Assert.IsTrue(submit_btn.Displayed);

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