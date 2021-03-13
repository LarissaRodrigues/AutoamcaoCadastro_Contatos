using System;
using OpenQA.Selenium;
using teste.page;
using teste.Suporte;

namespace teste.Classes
{
    public class CadastrarUsuarioHlp : BaseClass
    {
        CadastraUsuarioPage page;
        IWebDriver _driver;

        public CadastrarUsuarioHlp(IWebDriver driver)
        {
            page = new CadastraUsuarioPage(driver);
            _driver = driver;
        }

        public void RealizarCadastro(string texto, string senha, string confirmaSenha, string mensagem)
        {
            clicar(page.registrarUsuario);
            preencherCampo(page.inserirEmail, texto);
            preencherCampo(page.insereSenha, senha);
            preencherCampo(page.confirmaSenha, confirmaSenha);
            clicar(page.btn_enviar);
            pontoDeVerificacao(page.mensagemConfirmacao, mensagem);
            clicar(page.confirmaCadastro);

        }

        public void validaEmailObrigatorio(string senha, string confirmaSenha, string mensagem)
        {
            clicar(page.registrarUsuario);
            preencherCampo(page.insereSenha, senha);
            preencherCampo(page.confirmaSenha, confirmaSenha);
            clicar(page.btn_enviar);
            string texto = page.verificaEmailObrigatorio.Text;
            pontoDeVerificacao(page.verificaEmailObrigatorio, mensagem);
        }

        public void validaSenhaObrigatoria(string texto, string mensagem)
        {
            clicar(page.registrarUsuario);
            preencherCampo(page.inserirEmail, texto);
            clicar(page.btn_enviar);
            pontoDeVerificacao(page.verificaSenhaObrigatoria, mensagem);
        }


    }
}
