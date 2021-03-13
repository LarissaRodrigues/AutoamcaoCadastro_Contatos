using OpenQA.Selenium;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace teste.Suporte
{
    public class BaseClass
    {
        public void clicar(IWebElement elemento)
        {
            elemento.Click();
        }

        public void preencherCampo(IWebElement elemento, string texto)
        {
            elemento.SendKeys(texto);
        }

        public void pontoDeVerificacao(IWebElement elemento, string texto)
        {
            var compara = elemento.Text;
            Assert.AreEqual(compara, texto);
        }

        public void limpaCampo(IWebElement elemento)
        {
            elemento.Clear();
        }

        public void espera(int millisecondsTimeOut = 800)
        {

            Thread.Sleep(millisecondsTimeOut);
        }
    }
}
