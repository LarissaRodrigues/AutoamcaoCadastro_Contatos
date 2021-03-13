using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace teste.page
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "btnLogarPrincipalId")]
        public IWebElement logar { get; set; }

        [FindsBy(How = How.Id, Using = "Input_Email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "Input_Password")]
        public IWebElement senha { get; set; }

        [FindsBy(How = How.Id, Using = "Input_RememberMe")]
        public IWebElement ckd_lembrar { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn")]
        public IWebElement btn_logar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account']/div[1]/ul/li")]
        public IWebElement senhaObrigatoria { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account']/div[1]/ul/li")]
        public IWebElement senhaInvalida { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account']/div[1]/ul/li")]
        public IWebElement emailObrigatorio { get; set; }





    }
}
