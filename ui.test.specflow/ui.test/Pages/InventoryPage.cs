using OpenQA.Selenium;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class InventoryPage : Browser
    {
        #region System logged common

        private IWebElement buttonMenuBurger => driver.FindElement(By.CssSelector("#menu_button_container #react-burger-menu-btn"));
        public void buttonMenuBurgerClick() => buttonMenuBurger.Click();

        private IWebElement menuWindow => driver.FindElement(By.CssSelector("#menu_button_container .bm-menu-wrap"));
        public bool menuWindowDisplayed() => menuWindow.Displayed;

        private IWebElement menuItemLogout => driver.FindElement(By.CssSelector("#menu_button_container #logout_sidebar_link"));
        public bool menuLogoutDisplayed() => menuItemLogout.Displayed;

        #endregion

        public IWebElement getProduto(string produto) => driver.FindElement(By.XPath("//*[text()='" + produto + "']"));
        public IWebElement getProdutoPrice(string produto) => getProduto(produto).FindElement(By.XPath("./../../..")).FindElement(By.CssSelector(".pricebar .inventory_item_price"));
    }
}