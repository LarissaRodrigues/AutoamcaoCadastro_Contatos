using OpenQA.Selenium;
using teste.page;
using teste.Suporte;

namespace teste.Classes
{
    public class ContatosHlp : BaseClass
    {
        ContatosPage page;
        IWebDriver _driver;

        public ContatosHlp(IWebDriver driver)
        {
            page = new ContatosPage(driver);
            _driver = driver;
        }

        public void preencheCadastro(string texto, string endereco, string cidade, string cep, string telefone, string email)
        {
            espera();
            clicar(page.btn_adicionarContato);
            espera();
            clicar(page.btn_criarContato);
            preencherCampo(page.nome, texto);
            clicar(page.solteiro);
            preencherCampo(page.endereco, endereco);
            preencherCampo(page.cidade, cidade);
            clicar(page.UF);
            preencherCampo(page.cep, cep);
            preencherCampo(page.telefone, telefone);
            preencherCampo(page.email, email);
            clicar(page.btn_gravar);

        }

        public void deletaCadastro()
        {
            espera();
            clicar(page.btn_adicionarContato);
            clicar(page.btn_deletar);
            clicar(page.btn_confirmar);
        }

        public void editaCadastro(string texto)
        {
            espera();
            clicar(page.btn_adicionarContato);
            espera();
            clicar(page.btn_editar);
            limpaCampo(page.nome);
            preencherCampo(page.nome, texto);
            clicar(page.btn_gravar);
        }
    }
}
