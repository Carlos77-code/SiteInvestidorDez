using NUnit.Framework;
using OpenQA.Selenium;

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
        }
    }
}
