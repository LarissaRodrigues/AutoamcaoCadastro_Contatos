using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Selenium;
using System.IO;
using Microsoft.Extensions.Configuration;
using System;
using NUnit.Framework;

namespace selenium
{
    public class WebDriverFactory
    {
        public static IConfiguration _configuration;
        public static IWebDriver _driver;

        public static IWebDriver CreateDriver(Browser browser)
        {
            //recupero o caminho do driver para execução
            string pathDriver = recuperaDadosPath(browser);

            switch (browser)
            {
                case Browser.FireFox:
                    FirefoxOptions options = new FirefoxOptions();
                    options.AcceptInsecureCertificates = true;
                    _driver = new FirefoxDriver(pathDriver, options);

                    break;

                case Browser.Chrome:
                    //Criação do driver com o navegador passado por parametro
                    ChromeOptions optionsChrome = new ChromeOptions();
                    optionsChrome.AcceptInsecureCertificates = true;
                    _driver = new ChromeDriver(pathDriver, optionsChrome);
                    break;

            }

            return _driver;
        }

        private static string recuperaDadosPath(Browser browser)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            _configuration = builder.Build();

            if (Browser.Chrome.Equals(browser))
            {
                return _configuration.GetSection("Selenium:PathDriverChrome").Value;
            }
            else if (Browser.FireFox.Equals(browser))
            {
                return _configuration.GetSection("Selenium:PathDriverFirefox").Value;
            }
            return _configuration.GetSection("Selenium:PathDriverChrome").Value;
        }

        public void CarregarPagina()
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            _driver.Navigate().GoToUrl("https://localhost:5001");
        }


        [TearDown]
        public void FecharPagina()
        {
            _driver.Quit();
        }
    }
}

