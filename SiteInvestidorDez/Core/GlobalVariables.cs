using OpenQA.Selenium;

namespace SiteInvestidorDez.Core
{
    public class GlobalVariables
    {
        //Define "driver" como trigger para os WebElements
        public IWebDriver driver;

        //Define "Fechar navegador ao final do teste" como padrão
        public bool driverQuit = true;
    }
}
