using NUnit.Framework;
using selenium;
using Selenium;
using teste.Classes;

namespace teste.Test
{
    public class ContatosTest : WebDriverFactory
    {
        ContatosHlp hp;
        ContatoDto _contato;
        LoginHlp login;

        [SetUp]
        public void setUp()
        {
            CreateDriver(Browser.Chrome);
            CarregarPagina();
            hp = new ContatosHlp(_driver);
            _contato = new ContatoDto();
            login = new LoginHlp(_driver);
            login.realizarLogin("Teste11@gmail.com", "Mudar@123");

        }

        [Test]

        public void realizaCadastroContato()
        {
            _contato.Nome = Faker.Name.FullName();
            _contato.Endereco = Faker.Address.StreetAddress();
            _contato.Cidade = Faker.Address.City();
            _contato.Cep = Faker.Address.ZipCode();
            _contato.Telefone = Faker.Phone.Number();
            _contato.Email = Faker.Internet.Email();

            hp.preencheCadastro(_contato.Nome, _contato.Endereco, _contato.Cidade, _contato.Cep, _contato.Telefone, _contato.Email);
        }

        [Test]

        public void deletaContato()
        {
            hp.deletaCadastro();
        }

        [Test]

        public void editaContato()
        {
            _contato.Nome = Faker.Name.FullName();
            hp.editaCadastro(_contato.Nome);
        }
    }
}
