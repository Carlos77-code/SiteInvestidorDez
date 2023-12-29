using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace SiteInvestidorDez.Core
{
    public class Begin : DSL
    {
        private void AbreNavegador()
        {
            var headlesMode = new ChromeOptions();
            headlesMode.AddArgument("window-size=1366x768");
            headlesMode.AddArgument("disk-cache-size=0");
            headlesMode.AddArgument("headless");

            var devMode = new ChromeOptions();
            devMode.AddArgument("disk-cache-size=0");
            devMode.AddArgument("start-maximized");

            if (headlessTest) { driver = new ChromeDriver(headlesMode);}
            else { driver = new ChromeDriver(devMode); driverQuit = false; }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [SetUp]
        public void InicioTeste()
        {
            AbreNavegador();
            driver.Navigate().GoToUrl("https://investidor10.com.br/");
        }

        [TearDown]
        public void FimDoTeste()
        {
            if (driverQuit) driver.Quit();
        }
    }
}