using NUnit.Framework;
using TechTalk.SpecFlow;
using ui.test.Drivers;
using ui.test.Pages;

namespace ui.test.Steps
{
    [Binding]
    public class InventoryStep : Browser
    {
        public InventoryPage inventoryPage = new InventoryPage();

        [Then(@"os valores dos produtos devem ser '(.+)' e '(.+)'")]
        public void EntaoInsiroAsSeguintesInformacoesPessoais(string nomeProduto, string precoProduto)
        {
            Assert.That(inventoryPage.getProdutoPrice(nomeProduto).Text, Is.EqualTo(precoProduto));
        }
    }
}