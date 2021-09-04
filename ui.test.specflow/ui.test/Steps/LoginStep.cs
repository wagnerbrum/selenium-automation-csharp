using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ui.test.Drivers;
using ui.test.Pages;

namespace ui.test.Steps
{
    [Binding]
    public class LoginStep : Browser
    {
        public LoginPage loginPage = new LoginPage();
        public InventoryPage inventoryPage = new InventoryPage();

        [Given(@"que acesso o site")]
        public void DadoQueAcessoOSite()
        {
            Browser.loadPage("https://www.saucedemo.com/");
        }

        [When(@"informo as seguintes credenciais")]
        public void QuandoInformoAsSeguintesCredenciais(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            string username = (string)data.Username;
            string password = (string)data.Password;

            loginPage.loginSendKeys(username, password);
        }
        
        [When(@"me autentico no sistema")]
        public void QuandoMeAutenticoNoSistema()
        {
            loginPage.loginClick();
        }
        
        [Then(@"vejo que estou na login page")]
        public void EntaoVejoQueEstouNaLoginPage()
        {
            // Assert.That(loginPage.isbotImgExists(), Is.True); ?? WHAT ??
            Assert.IsTrue(loginPage.botImgDisplayed());
        }

        [Then(@"o menu do usuário está visivel")]
        public void EntaoOMenuDoUsuarioEstaVisivel()
        {
            inventoryPage.buttonMenuBurgerClick();
            Assert.IsTrue(inventoryPage.menuWindowDisplayed());
        }
        
        [Then(@"o usuário aparece logado")]
        public void EntaoOUsuarioApareceLogado()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(inventoryPage.menuLogoutDisplayed());
        }
        
        [Then(@"um erro aparece informando que o usuário está bloqueado")]
        public void EntaoUmErroApareceInformandoQueOUsuarioEstaBloqueado()
        {
            Assert.IsTrue(loginPage.alertErrorDisplayed());
            Assert.That(loginPage.alertErrorText(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }
    }
}