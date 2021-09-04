using OpenQA.Selenium;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class CheckoutStepOnePage : Browser
    {
        // firstName, lastName, zipPostalCode
        private IWebElement inputFirstName => driver.FindElement(By.CssSelector("form #first-name"));
        private IWebElement inputLastName => driver.FindElement(By.CssSelector("form #last-name"));
        private IWebElement inputPostalCode => driver.FindElement(By.CssSelector("form #postal-code"));
        private IWebElement buttonContinue => driver.FindElement(By.CssSelector("form #continue"));

        public void formSendKeys(string firstName, string lastName, string zipPostalCode)
        {
            inputFirstName.SendKeys(firstName);
            inputLastName.SendKeys(lastName);
            inputPostalCode.SendKeys(zipPostalCode);
        }

        public void buttonContinueClick() => buttonContinue.Click();
    }
}