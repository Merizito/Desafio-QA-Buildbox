using Desafio_QA_Buildbox.utils;
using Desafio_QA_Buildbox.pages;
using AventStack.ExtentReports;

namespace Desafio_QA_Buildbox.tests;

public class Home_tests : WebDriverConfig
{
    IWebDriver driver;
    ExtentTest test;
    HomePage_POM home;
    DeliverPage_POM deliver;
    WebDriverWait wait;
    string testPageName = "Home Tests - ";
    string fileName = "HomeResults.html";
    string url = "https://buger-eats.vercel.app/";
    bool test_result = false;

    public void SetupChrome()
    {
        string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        WebDriverConfig.path = System.IO.Path.Combine(currentPath, "GitHub\\Desafio-QA-Buildbox\\Reports\\", "Home - Reports\\");   //sets the path to the reports Folder
        driver = WebDriverInitialConfig(driver, url, ref test, testPageName);   //creates an instance for web driver
    }

    [Test]
    public void RunAllTests()       //Run all tests and save all results in one report file
    {
        try
        {
            T01_VerifyElementsOnScreen();
            driver.Close();

            T02_TryNavigateDeliverPage();

            fileName = "All Home Page Tests Results";
        }
        catch (Exception e)
        {
            test.Log(Status.Fail, "Some Test has Failed.");
            System.Console.WriteLine(e.Message);
        }
    }

    [Test]
    public void T01_VerifyElementsOnScreen()    //Verify if the elements are displayed on screen
    {
        try
        {
            WebDriverConfig.test_name = "Verify Elements On Home Screen.";
            fileName = "Test 01 - Verify Elements On Home Screen";
            SetupChrome();

            home = new HomePage_POM(driver, url);

            test_result = home.VerifyElementsOnScreen(test);
            Assert.IsTrue(test_result);

            test.Log(Status.Pass, "Elements has been displayed successfully.");
            test.Log(Status.Pass, "Test Passed.");
        }
        catch (Exception e)
        {
            if (test_result == false)
                test.Log(Status.Warning, "Failed to display elements.");

            test.Log(Status.Fail, "Test Failed.");
            System.Console.WriteLine(e.Message);
        }
    }

    [Test]
    public void T02_TryNavigateDeliverPage()    //This test will click on Sign Up button and verifies if redirect correctly to Deliver's Sign Up page
    {
        try
        {
            WebDriverConfig.test_name = "Try Navigate to Deliver Page.";
            fileName = "Test 02 - Try Navigate to Deliver Page";
            SetupChrome();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            deliver = new DeliverPage_POM(driver, url);
            home = new HomePage_POM(driver, url);

            wait.Until(driver => home.signup_btn.Displayed == true);

            test_result = home.TryNavigateDeliverPage(test);
            Assert.IsTrue(test_result);

            test.Log(Status.Pass, "Navigated to Deliver page successfully.");
            test.Log(Status.Pass, "Test Passed.");
        }
        catch (Exception e)
        {
            if (test_result == false)
                test.Log(Status.Warning, "Failed to navigate to deliver page.");

            test.Log(Status.Fail, "Test Failed.");
            System.Console.WriteLine(e.Message);
        }
    }

    [TearDown]
    public void CloseChrome()
    {
        WebDriverConfig.SetupReport(fileName);
        CloseWebDriver(driver);
    }
}