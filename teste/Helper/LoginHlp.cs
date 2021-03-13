using OpenQA.Selenium;
using teste.page;
using teste.Suporte;

namespace teste.Classes
{
    public class LoginHlp : BaseClass
    {
        LoginPage page;
        IWebDriver _driver;



        public LoginHlp(IWebDriver driver)
        {
            page = new LoginPage(driver);
            _driver = driver;
        }

        public void realizarLogin(string texto, string senha)
        {
            clicar(page.logar);
            preencherCampo(page.email, texto);
            preencherCampo(page.senha, senha);
            clicar(page.ckd_lembrar);
            clicar(page.btn_logar);
        }

        public void senhaIncorreta(string texto, string senha, string mensagem)
        {
            clicar(page.logar);
            preencherCampo(page.email, texto);
            preencherCampo(page.senha, senha);
            clicar(page.ckd_lembrar);
            clicar(page.btn_logar);
            pontoDeVerificacao(page.senhaInvalida, mensagem);
        }
        public void campoSenhaObrigatorio(string texto, string mensagem)
        {
            clicar(page.logar);
            preencherCampo(page.email, texto);
            clicar(page.ckd_lembrar);
            clicar(page.btn_logar);
            pontoDeVerificacao(page.senhaObrigatoria, mensagem);
        }

        public void emailObrigatorio(string senha, string mensagem)
        {
            clicar(page.logar);
            preencherCampo(page.senha, senha);
            clicar(page.ckd_lembrar);
            clicar(page.btn_logar);
            pontoDeVerificacao(page.emailObrigatorio, mensagem);

        }
    }
}
