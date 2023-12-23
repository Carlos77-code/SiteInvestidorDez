using NUnit.Framework;
using OpenQA.Selenium;
using SiteInvestidorDez.Core;

namespace SiteInvestidorDez
{
    class BuscaAcao : Begin
    {
        [Test]
        public void Teste()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/section[1]/div/div/div[1]/div/form/div/span/input[2]")).SendKeys("MXRF11");
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/section[1]/div/div/div[1]/div/form/div/button")).Click();
            driver.FindElement(By.XPath("//*[@id=\'results\']/div/div[2]/div[1]/div")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id=\'header_action\']/div[1]/div[2]/h1")).Text, Does.Contain("MXRF11"));
            Assert.That(driver.FindElement(By.XPath("//*[@id=\'dividends-section\']/header/h2")).Text, Does.Contain("MXRF11 DIVIDENDOS"));

            //driver.FindElement(By.XPath("//*[@id=\'pop_up_ads\']/div/button")).Click();
        }
    }
}
