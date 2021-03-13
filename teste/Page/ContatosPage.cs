using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace teste.page
{
    public class ContatosPage
    {
        public ContatosPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Contato")]
        public IWebElement btn_adicionarContato { get; set; }

        [FindsBy(How = How.Name, Using = "btnCriar")]
        public IWebElement btn_criarContato { get; set; }

        [FindsBy(How = How.Id, Using = "nomeId")]
        public IWebElement nome { get; set; }

        [FindsBy(How = How.Id, Using = "Solteiro")]
        public IWebElement solteiro { get; set; }

        [FindsBy(How = How.Id, Using = "enderecoId")]
        public IWebElement endereco { get; set; }

        [FindsBy(How = How.Id, Using = "cidadeId")]
        public IWebElement cidade { get; set; }

        [FindsBy(How = How.Id, Using = "estadoId")]
        public IWebElement UF { get; set; }

        [FindsBy(How = How.Id, Using = "cepId")]
        public IWebElement cep { get; set; }

        [FindsBy(How = How.Id, Using = "telefoneId")]
        public IWebElement telefone { get; set; }

        [FindsBy(How = How.Id, Using = "emailId")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "btnGravar")]
        public IWebElement btn_gravar { get; set; }

        [FindsBy(How = How.Name, Using = "btnDeletar")]
        public IWebElement btn_deletar { get; set; }

        [FindsBy(How = How.Name, Using = "bntConfirmar")]
        public IWebElement btn_confirmar { get; set; }

        [FindsBy(How = How.Name, Using = "btnEditar")]
        public IWebElement btn_editar { get; set; }

    }
}
