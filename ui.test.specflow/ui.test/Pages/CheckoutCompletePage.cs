using OpenQA.Selenium;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class CheckoutCompletePage : Browser
    {
        private IWebElement headerMessage => driver.FindElement(By.CssSelector("#checkout_complete_container .complete-header"));

        public string headerMessageText => headerMessage.Text;
    }
}