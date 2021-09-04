using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ui.test.Drivers;
using ui.test.Pages;

namespace ui.test.Steps
{
    [Binding]
    public class CheckoutStep : Browser
    {
        public LoginPage loginPage = new LoginPage();
        public InventoryPage inventoryPage = new InventoryPage();
        public InventoryItemPage inventoryItemPage = new InventoryItemPage();
        public CartPage cartPage = new CartPage();
        public CheckoutStepOnePage checkoutStepOnePage = new CheckoutStepOnePage();
        public CheckoutStepTwoPage checkoutStepTwoPage = new CheckoutStepTwoPage();
        public CheckoutCompletePage checkoutCompletePage = new CheckoutCompletePage();

        [When(@"adiciono o produto (.+)")]
        public void QuandoAdicionoOProduto(string produto)
        {
            inventoryPage.getProduto(produto).Click();
            inventoryItemPage.buttonAddToCart(produto);
            // inventoryItemPage.buttonAddToCartClick();
        }

        [When(@"visualizo o carrinho")]
        public void QuandoVisualizoOCarrinho()
        {
            cartPage.buttonCartClick();
        }

        [When(@"sigo para as informações do Checkout")]
        public void QuandoSigoParaAsInformacoesDoCheckout()
        {
            cartPage.checkoutCartBtnClick();
        }

        [When(@"insiro as seguintes informações pessoais")]
        public void QuandoInsiroAsSeguintesInformacoesPessoais(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            string firstName = (string)data.FirstName;
            string lastName = (string)data.LastName;
            string zipPostalCode = ((string)data.ZipPostalCode).Replace("\"", "");

            checkoutStepOnePage.formSendKeys(firstName, lastName, zipPostalCode);
        }

        [When(@"sigo para o Overview do Checkout")]
        public void QuandoSigoParaOOverviewDoCheckout()
        {
            checkoutStepOnePage.buttonContinueClick();
        }

        [When(@"finalizo a compra")]
        public void QuandoFinalizoACompra()
        {
            checkoutStepTwoPage.buttonFinishClick();
        }

        [Then(@"a página de pedido completo é exibida contendo a mensagem (.+)")]
        public void EntaoPaginaPedidoCompletoContendoMensagem(string message)
        {
            Assert.That(checkoutCompletePage.headerMessageText, Is.EqualTo(message));
        }
    }
}