using Desafio_QA_Buildbox.utils;
using Desafio_QA_Buildbox.pages;
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
    string url = "https://buger-eats.vercel.app/deliver";
    bool test_result = false;

    public void SetupChrome()
    {
        string currentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        WebDriverConfig.path = System.IO.Path.Combine(currentPath, "GitHub\\Desafio-QA-Buildbox\\Reports\\", "Deliver - Reports\\");    //sets the path to the reports Folder
        driver = WebDriverInitialConfig(driver, url, ref test, testPageName);   //creates an instance for web driver
    }
    
    [Test]
    public void RunAllTests()       //Run all tests and save all results in one report file
    {
        try
        {
            T01_VerifyElementsOnScreen();
            driver.Close();

            T02_SignupInHappyWay();
            driver.Close();

            T03_TrySignUpWithSpaceBarInput();
            driver.Close();

            T04_TrySignUpWithoutAnyInputs();

            fileName = "All Deliver Page Tests Results";
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
            WebDriverConfig.test_name = "Verify Elements On Deliver Screen.";
            fileName = "Test 01 - Verify Elements on Deliver Screen";
            SetupChrome();

            deliver = new DeliverPage_POM(driver, url);

            test_result = deliver.VerifyElementsOnScreen(test);
            Assert.IsTrue(test_result);

            test.Log(Status.Pass, "Elements has been displayed.");
            test.Log(Status.Pass, "Test Passed.");
        }
        catch (Exception e)
        {
            test.Log(Status.Fail, "Test Failed.");
            System.Console.WriteLine(e.Message);
        }
    }

    [Test]
    public void T02_SignupInHappyWay()      //This test try sign Up in Happy Way
    {
        try
        {
            WebDriverConfig.test_name = "Sign up in Happy Way.";
            fileName = "Test 02 - Sign up in Happy Way";
            SetupChrome();

            deliver = new DeliverPage_POM(driver, url);

            test_result = deliver.SignUpInHappyWay(test);
            Assert.IsTrue(test_result);

            test.Log(Status.Pass, "Signed up successfully.");
            test.Log(Status.Pass, "Test Passed.");
        }
        catch (Exception e)
        {
            test.Log(Status.Fail, "Test Failed.");
            System.Console.WriteLine(e.Message);
        }
    }

    [Test]
    public void T03_TrySignUpWithSpaceBarInput()        //This test will try to sign up with Space Bar Input
    {
        try
        {
            WebDriverConfig.test_name = "Try Sign Up With Space Bar Input.";
            fileName = "Test 03 - Try Sign Up With Space Bar Input";
            SetupChrome();

            deliver = new DeliverPage_POM(driver, url);

            test_result = deliver.TrySignUpWithSpaceBarInput(test);
            Assert.IsTrue(test_result);

            test.Log(Status.Pass, "Failed to Sign Up with space bar input, as expected.");
            test.Log(Status.Pass, "Test Passed.");
        }
        catch (Exception e)
        {
            test.Log(Status.Fail, "Test Failed.");
            System.Console.WriteLine(e.Message);
        }
    }

    [Test]
    public void T04_TrySignUpWithoutAnyInputs()     //This test will try to sign up with all input fields empty.
    {
        try
        {
            WebDriverConfig.test_name = "Try Sign Up Without Any Inputs.";
            fileName = "Test 04 - Try Sign Up Without Any Inputs";
            SetupChrome();

            deliver = new DeliverPage_POM(driver, url);

            test_result = deliver.TrySignUpWithoutAnyInputs(test);
            Assert.IsTrue(test_result);

            test.Log(Status.Pass, "Failed to Sign Up without any inputs, as expected.");
            test.Log(Status.Pass, "Test Passed.");
        }
        catch (Exception e)
        {
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