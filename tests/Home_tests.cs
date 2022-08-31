using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Desafio_QA_Buildbox.utils;
using Desafio_QA_Buildbox.pages;
using System.Threading;
using System;
using AventStack.ExtentReports;

namespace Desafio_QA_Buildbox.tests;

public class Home_tests : WebDriverConfig
{
    IWebDriver driver;
    ExtentTest test;
    HomePage_POM home;
    WebDriverWait wait;
    string testPageName = "Home Tests - ";
    string fileName = "HomeResults.html";
    string url = "https://buger-eats.vercel.app/";
    bool test_result = false;

    public void SetupChrome()
    {
        WebDriverConfig.path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "/Reports/", "Home - Reports/");   //sets the path to the reports Folder
        driver = WebDriverInitialConfig(driver, url, ref test, testPageName);   //creates an instance for web driver
    }

    [TearDown]
    public void CloseChrome()
    {
        WebDriverConfig.SetupReport(fileName);
        CloseWebDriver(driver);
    }
}