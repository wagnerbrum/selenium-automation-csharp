using OpenQA.Selenium;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class InventoryItemPage : Browser
    {
        // private IWebElement buttonAddToCart => driver.FindElement(By.CssSelector("#inventory_item_container .btn_primary"));
        // public void buttonAddToCartClick() => buttonAddToCart.Click();
        
        public IWebElement buttonAddToCart(string produto) => driver.FindElement(By.XPath("//*[@id=\"add-to-cart-" + produto.Replace(" ", "-").ToLower() + "\"]"));
    }
}