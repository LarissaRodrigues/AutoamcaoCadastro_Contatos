using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace teste.page
{
    public class CadastraUsuarioPage
    {

        public CadastraUsuarioPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "RegistrarId")]
        public IWebElement registrarUsuario { get; set; }

        [FindsBy(How = How.Name, Using = "Input.Email")]
        public IWebElement inserirEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Input_Password")]
        public IWebElement insereSenha { get; set; }

        [FindsBy(How = How.Id, Using = "Input_ConfirmPassword")]
        public IWebElement confirmaSenha { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn")]
        public IWebElement btn_enviar { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/h1")]
        public IWebElement mensagemConfirmacao { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/div/div/form/div[1]/ul/li")]
        public IWebElement verificaEmailObrigatorio { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/div/div/form/div[1]/ul/li")]
        public IWebElement verificaSenhaObrigatoria { get; set; }

        [FindsBy(How = How.Id, Using = "confirm-link")]
        public IWebElement confirmaCadastro { get; set; }


    }
}
