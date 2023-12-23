using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SiteInvestidorDez.Core
{
    public class Begin : DSL
    {
        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://investidor10.com.br/");
            driver.Manage().Window.Maximize();
            driverQuit = false;
        }

        [TearDown]
        public void FimDoTeste()
        {
            if (driverQuit) driver.Quit();
        }
    }
}