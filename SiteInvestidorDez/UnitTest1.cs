using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SiteInvestidorDez
{
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void InicioTeste()
        {
        }

        [Test]
        public void Teste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://investidor10.com.br/");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void FimDoTeste()
        {

        }
    }
}