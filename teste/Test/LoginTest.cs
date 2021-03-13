using NUnit.Framework;
using selenium;
using Selenium;
using teste.Classes;

namespace teste.Test
{
    public class LoginTest : WebDriverFactory
    {
        LoginHlp hp;

        [SetUp]
        public void setUp()
        {
            CreateDriver(Browser.Chrome);
            CarregarPagina();
            hp = new LoginHlp(_driver);
        }

        [Test]

        public void realizaLogin()
        {
            hp.realizarLogin("Teste11@gmail.com", "Mudar@123");
        }

        [Test]

        public void verificaSenhaObrigatoria()
        {
            hp.campoSenhaObrigatorio("Teste11@gmail.com", "The Password field is required.");
        }

        [Test]

        public void verificaSenhaIncorreta()
        {
            hp.senhaIncorreta("Teste11@gmail.com", "Mudar", "Invalid login attempt.");
        }


        [Test]

        public void verificaEmailObrigatorio()
        {
            hp.emailObrigatorio("Mudar@123", "The Email field is required.");
        }
    }
}
