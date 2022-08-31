using SeleniumExtras.PageObjects;
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


    [FindsBy(How = How.Id, Using = "swal2-title")]
    public IWebElement signUp_success_text { get; set; }


    [FindsBy(How = How.CssSelector, Using = "body > div.swal2-container.swal2-center.swal2-backdrop-show > div > div.swal2-actions > button.swal2-confirm.swal2-styled")]
    public IWebElement signUp_success_close_btn { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(2) > div:nth-child(2) > div:nth-child(1) > span")]
    public IWebElement fullName_alert_error { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(2) > div:nth-child(2) > div:nth-child(2) > span")]
    public IWebElement cpf_alert_error { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(2) > div:nth-child(3) > div:nth-child(1) > span")]
    public IWebElement email_alert_error { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(3) > div:nth-child(2) > div:nth-child(1) > span")]
    public IWebElement postalCode_alert_error { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(3) > div:nth-child(4) > div:nth-child(1) > span")]
    public IWebElement addressNumber_alert_error { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > fieldset:nth-child(4) > span")]
    public IWebElement deliveryMethod_alert_error { get; set; }


    [FindsBy(How = How.CssSelector, Using = "#page-deliver > form > span")]
    public IWebElement cnh_alert_error { get; set; }


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

    public bool SignUpInHappyWay(ExtentTest test)
    {
        try
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(driver => form.Displayed == true);

            fullName_input.SendKeys("Buger Eats Teste");
            cpf_input.SendKeys("12332112332");
            email_input.SendKeys("bugereats_test@bugereats.com");
            whatsapp_input.SendKeys("11111111111");

            postalcode_input.SendKeys("32240470");
            search_postalcode_btn.Click();

            wait.Until(driver => address_input.GetAttribute("value") != "");

            Assert.IsTrue(address_input.GetAttribute("value") == "Rua dos Barnabitas");
            Assert.IsTrue(district_input.GetAttribute("value") == "Bandeirantes");
            Assert.IsTrue(city_input.GetAttribute("value") == "Contagem/MG");

            address_number_input.SendKeys("222");
            address_details_input.SendKeys("");

            motorcycle_method.Click();
            Assert.That(motorcycle_method.GetAttribute("class") == "selected");

            cnh_image_upload.SendKeys(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GitHub\\Desafio-QA-Buildbox\\files\\Upload\\", "cnh_upload.jpg"));

            submit_btn.Click();
            
            Assert.IsTrue(signUp_success_text.Displayed);
            signUp_success_close_btn.Click();

            return true;
        }
        catch (Exception e)
        {
            test.Log(Status.Warning, e.Message);    //Write exception message in report log
            System.Console.WriteLine(e.Message);
            return false;
        }
    }

    public bool TrySignUpWithSpaceBarInput(ExtentTest test)
    {
        try
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(driver => form.Displayed == true);

            fullName_input.SendKeys("            ");
            cpf_input.SendKeys("           ");
            email_input.SendKeys("        @bugereats.com");
            whatsapp_input.SendKeys("           ");

            postalcode_input.SendKeys("        ");
            search_postalcode_btn.Click();
            Assert.IsTrue(postalCode_alert_error.Displayed);

            motorcycle_method.Click();
            Assert.That(motorcycle_method.GetAttribute("class") == "selected");

            cnh_image_upload.SendKeys(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GitHub\\Desafio-QA-Buildbox\\files\\Upload\\", "cnh_upload.jpg"));

            submit_btn.Click();

            Assert.IsFalse(driver.FindElements(By.Id(signUp_success_text.ToString())).Count() > 0);

            return true;
        }
        catch (Exception e)
        {
            test.Log(Status.Warning, e.Message);
            System.Console.WriteLine(e.Message);
            return false;
        }
    }

    public bool TrySignUpWithoutAnyInputs(ExtentTest test)
    {
        try
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(driver => form.Displayed == true);

            submit_btn.Click();
            
            Assert.IsTrue(fullName_alert_error.Displayed);
            Assert.IsTrue(cpf_alert_error.Displayed);
            Assert.IsTrue(email_alert_error.Displayed);
            Assert.IsTrue(postalCode_alert_error.Displayed);
            Assert.IsTrue(addressNumber_alert_error.Displayed);
            Assert.IsTrue(deliveryMethod_alert_error.Displayed);
            Assert.IsTrue(cnh_alert_error.Displayed);

            test.Log(Status.Pass, "All alert errors has been displayed.");

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