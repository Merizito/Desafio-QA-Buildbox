using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Chrome;

namespace Desafio_QA_Buildbox.utils;

public class WebDriverConfig : ExtentReports
{
    public static ExtentReports generalReports = new ExtentReports();
    public static ExtentReports singleTestReport = new ExtentReports();
    public static int test_number = 1;
    public static string file_name, test_PageName, test_name, path;

    public IWebDriver WebDriverInitialConfig(IWebDriver driver, string baseUrl, ref ExtentTest generalTest, string testPageName) //This method sets the initial configs of web driver
    {
        test_PageName = testPageName;

        generalTest = generalReports.CreateTest(testPageName + "Test " + test_number + ": " + test_name).Info("Test " + test_number + " Started."); //Test Name + first test log
        test_number++;

        var options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        // options.AddArgument("--headless");       //Run tests without driver interface
        options.AddArgument("--verbose");

        driver = new ChromeDriver(options); //Creates a new instance of ChromeDriver

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);  //Defines a implicit wait of 4 seconds
        generalTest.Log(Status.Info, "Chrome Browser Launched.");

        generalTest.Log(Status.Info, "Navigating to the defined url.");
        driver.Navigate().GoToUrl(baseUrl);

        return driver;
    }

    public void CloseWebDriver(IWebDriver driver) //This method closes the web driver
    {
        try
        {
            driver.Close();
            generalReports.Flush(); //This function generates the .html file with all information.
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    public static void SetupReport(string fileName)     //This method will setup report
    {
        file_name = fileName;

        var reportsFolder = System.IO.Path.Combine(path, file_name + ".html");  //Sets the path folder to save the report with report name and type of report file.
        var htmlReporter = new ExtentSparkReporter(reportsFolder);

        htmlReporter.Config.DocumentTitle = test_PageName + "Report";
        htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Dark;    //Generates the .html file with dark theme
        generalReports.AttachReporter(htmlReporter);
    }

}