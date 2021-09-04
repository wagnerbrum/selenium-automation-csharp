using OpenQA.Selenium;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class CheckoutStepTwoPage : Browser
    {
        private IWebElement buttonFinish => driver.FindElement(By.CssSelector("#checkout_summary_container #finish"));

        public void buttonFinishClick() => buttonFinish.Click();
    }
}