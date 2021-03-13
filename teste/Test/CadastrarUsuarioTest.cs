using NUnit.Framework;
using selenium;
using Selenium;
using teste.Classes;


namespace teste.Test
{
    public class CadastrarUsuarioTest : WebDriverFactory
    {
        private ContatoDto _contato = null;
        CadastrarUsuarioHlp testeCadastro;


        [SetUp]
        public void SetUp()
        {
            CreateDriver(Browser.Chrome);
            CarregarPagina();
            testeCadastro = new CadastrarUsuarioHlp(_driver);
            _contato = new ContatoDto();

        }

        [Test]
        public void TestarRealizaCadastro()
        {
            _contato.Nome = Faker.Internet.Email();
            testeCadastro.RealizarCadastro(_contato.Nome, "Mudar@123", "Mudar@123", "Conta criada com sucesso");

        }

        [Test]
        public void TestarEmailObrigatorio()
        {
            testeCadastro.validaEmailObrigatorio("Mudar@123", "Mudar@123", "The Email field is required.");
        }

        [Test]
        public void TestarSenhaObrigatorio()
        {
            _contato.Nome = Faker.Internet.Email();
            testeCadastro.validaSenhaObrigatoria(_contato.Nome, "The Password field is required.");
        }

    }
}
