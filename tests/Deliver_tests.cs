using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Desafio_QA_Buildbox.utils;
using Desafio_QA_Buildbox.pages;
using System.Threading;
using System;
using AventStack.ExtentReports;

namespace Desafio_QA_Buildbox.tests;

public class Deliver_tests : WebDriverConfig
{
    IWebDriver driver;
    ExtentTest test;
    DeliverPage_POM deliver;
    WebDriverWait wait;
    string testPageName = "Deliver Tests - ";
    string fileName = "DeliverResults.html";
    string url = "https://buger-eats.vercel.app/";
    bool test_result = false;

    public void SetupChrome()
    {
        WebDriverConfig.path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "/Reports/", "Deliver - Reports/");    //sets the path to the reports Folder
        driver = WebDriverInitialConfig(driver, url, ref test, testPageName);   //creates an instance for web driver
    }

    [TearDown]
    public void CloseChrome()
    {
        WebDriverConfig.SetupReport(fileName);
        CloseWebDriver(driver);
    }
}