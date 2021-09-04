using OpenQA.Selenium;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class LoginPage : Browser
    {
        #region Login Page

        private IWebElement botImg => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div[1]/div[2]"));
        public bool botImgDisplayed() => botImg.Displayed;

        private IWebElement inputUsername => driver.FindElement(By.CssSelector("form #user-name"));
        private IWebElement inputPassword => driver.FindElement(By.CssSelector("form #password"));
        private IWebElement buttonLogin => driver.FindElement(By.CssSelector("form #login-button"));
        private IWebElement alertError => driver.FindElement(By.CssSelector("form div.error-message-container.error h3"));
        public bool alertErrorDisplayed() => alertError.Displayed;
        public string alertErrorText() => alertError.Text;

        public void loginSendKeys(string username, string password)
        {
            inputUsername.SendKeys(username);
            inputPassword.SendKeys(password);
        }

        public void loginClick() => buttonLogin.Click();

        #endregion
    }
}