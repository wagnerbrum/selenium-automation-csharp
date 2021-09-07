using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ui.test.Drivers;
using ui.test.Models;
using ui.test.Pages;

namespace ui.test.Steps
{
    [Binding]
    public class InventoryStep : Browser
    {
        public InventoryPage inventoryPage = new InventoryPage();

        [Then(@"os valores dos produtos devem ser igual aos contidos na seguinte tabela")]
        public void EntaoInsiroAsSeguintesInformacoesPessoais(Table table)
        {
            var products = table.CreateSet<InventoryProduct>();

            foreach (var product in products)
            {
                Assert.That(inventoryPage.getProdutoPrice(product.Name).Text, Is.EqualTo(product.Price));
            }
        }
    }
}