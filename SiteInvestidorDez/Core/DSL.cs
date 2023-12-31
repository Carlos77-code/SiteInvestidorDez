﻿using NUnit.Framework;
using OpenQA.Selenium;

namespace SiteInvestidorDez.Core
{
    public class DSL : GlobalVariables
    {
        public void EscreveTexto(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public void ClicaElemento(string element)
        {
            driver.FindElement(By.XPath(element)).Click();
        }

        public void ClickElementResult(string element)
        {
            driver.FindElement(By.XPath(element)).Click();
        }

        public void ValidaDados(string xpath, string value)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }

        public void ValidaClass(string elementClass, string value)
        {
            Assert.That(driver.FindElement(By.ClassName(elementClass)).Text, Does.Contain(value));
        }
    }
}
