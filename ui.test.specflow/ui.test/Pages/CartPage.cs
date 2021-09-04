using OpenQA.Selenium;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class CartPage : Browser
    {
        public IWebElement buttonCart => driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a"));
        public IWebElement checkoutCartBtn => driver.FindElement(By.XPath("//*[@id=\"checkout\"]"));

        public void buttonCartClick() => buttonCart.Click();
        public void checkoutCartBtnClick() => checkoutCartBtn.Click();
    }
}