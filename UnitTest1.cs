

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_Automation
{
    [TestClass]
    public class TestTextBox
    {
        public object PageFactory { get; private set; }

        [TestMethod]


        public void Test()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            var chromeOptions = new ChromeOptions();
            //   chromeOptions.AddArguments(new List<string>() { "headless" });

            chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            chromeOptions.AddUserProfilePreference("block_third_party_cookies", true);

            var hdriver = new ChromeDriver();

            // This will open up the URL
            hdriver.Url = "https://www.geeksforgeeks.org/";
            hdriver.GetScreenshot();

        }
    }
}