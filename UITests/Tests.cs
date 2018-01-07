using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace UITests
{
    [TestFixture(Xamarin.UITest.Platform.Android)]
    [TestFixture(Xamarin.UITest.Platform.iOS)]
    public class Tests
    {
        private string baseURL = "http://www.google.co.uk/";
        private RemoteWebDriver driver;
        private string browser;
        public TestContext TestContext { get; set; }

        IApp app;
        Xamarin.UITest.Platform platform;

        public Tests(Xamarin.UITest.Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen. Morrison Software Ltd");

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(this.baseURL);
            driver.FindElementById("search - box").Clear();
            driver.FindElementById("search - box").SendKeys("tire");
        }
    }
}
