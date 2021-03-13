using NUnit.Framework;
using Selenium;
using teste.Classes;

namespace Testes
{
    public class TestesPesquisaGoogle
    {


        public TestesPesquisaGoogle()
        {

        }

        [Test]

        public void TestarFireFox()
        {
            ExecutaTesteGoogles(Browser.FireFox);

        }

        [Test]
        public void TestarChrome()
        {
            ExecutaTesteGoogles(Browser.Chrome);

        }

        private void ExecutaTesteGoogles(Browser browser)
        {
            Google testeGoogle = new Google(browser);

            testeGoogle.CarregarPagina();
            var results = testeGoogle.BuscaGoogle("Texto");
            Assert.True(results.Count > 0);
            testeGoogle.FecharPagina();
        }
    }
}
