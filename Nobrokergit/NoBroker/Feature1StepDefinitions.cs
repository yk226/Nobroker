using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using com.sun.tools.@internal.jxc.ap;

namespace NoBroker
{

    [Binding]
    public class Feature1StepDefinitions
    {
        //var driverPath = Path.GetFullPath(@"..\");
        IWebDriver driver = new ChromeDriver(Path.GetFullPath(@"..\"));

        [Given(@"I load nobroker url")]
        public void GivenILoadNobrokerUrl()
        {
            driver.Url = "https://www.nobroker.in/";

        }

        [Given(@"I select Buy option")]
        public void GivenISelectBuyOption()
        {

            driver.FindElement(By.XPath("//div[text()='Buy']")).Click();
        }

        //[Given(@"I select mumbai city")]
        //public void GivenISelectMumbaiCity()
        //{
        //    driver.FindElement(By.XPath("//div[@class='css-v2nw5i-control nb-select__control']")).Click();
        //    //action.MoveToElement(driver.FindElement(By.XPath("//div[@class='css-v2nw5i-control nb-select__control']"))).Click();
        //    Thread.Sleep(6000);
        //    driver.FindElement(By.XPath("//div[text()='Mumbai']")).Click();
        //}


        [Given(@"I select ""([^""]*)"" city")]
        public void GivenISelectCity(string mumbai)
        {
            driver.FindElement(By.XPath("//div[@class='css-v2nw5i-control nb-select__control']")).Click();
            driver.Manage().Timeouts().ImplicitWait =TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//div[text()=" + mumbai + "]")).Click();
        }


        //[Given(@"search the malad east and malad west")]
        //public void GivenSearchTheMaladEastAndMaladWest()
        //{
        //    //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        //    //WebElement element = wait.Until(ExpectedExceptionAttribute.GetCustomAttribute);
        //    IWebElement locality = driver.FindElement(By.Id("listPageSearchLocality"));
        //    locality.SendKeys("MaladEast-Malkani Estate");
        //    //Thread.Sleep(6000);
        //    driver.FindElement(By.XPath("//div[@class='suggestion-item']")).Click();
        //    //Thread.Sleep(10000);
        //    locality.SendKeys("Malad west-Sundar Ln");
        //    Thread.Sleep(15000);
        //    driver.FindElement(By.XPath("(//div[@class='suggestion-item'])[1]")).Click();
        //    Thread.Sleep(15000);
        //}

        [Given(@"search the ""([^""]*)"" and ""([^""]*)""")]
        public void GivenSearchTheAnd(string p0, string p1)
        {
            IWebElement locality = driver.FindElement(By.Id("listPageSearchLocality"));
            locality.SendKeys(p0);
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//div[@class='suggestion-item']")).Click();
            Thread.Sleep(6000);
            locality.SendKeys(p1);
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("(//div[@class='suggestion-item'])[1]")).Click();
            Thread.Sleep(6000);
        }


        [Given(@"I select apartment type")]
        public void GivenISelectApartmentType()
        {
            driver.FindElement(By.XPath("//div[text()='Apartment Type']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//span[text()='2 BHK']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//span[text()='3 BHK']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }

        [Given(@"I click on serch")]
        public void GivenIClickOnSerch()
        {
            driver.FindElement(By.XPath("//button[text()='Search']")).Click();
            Thread.Sleep(15000);
        }

        [Given(@"I select only fourth property")]
        public void GivenISelectOnlyFourthProperty()
        {
            driver.FindElement(By.XPath("/html/body/div[5]/div/main/div[2]/div[3]/div[2]/div[1]/div/article[4]/div[2]/div/section[1]/div[1]/span[1]/h2/svg")).Click();
            //driver.SwitchTo().Window(driver.WindowHandles[1]);

        }





    }
}
