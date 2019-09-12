using Core;
using OpenQA.Selenium;

namespace Pages
{
    public class GoogleHomePage : BasePage
    {
        public GoogleHomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://www.google.com";

        public IWebElement TextInputSearch => this.driver.FindElement(By.CssSelector("input[name='q']"));


        public GoogleSearchResultPage GoogleIt(string searchString)
        {
            this.TextInputSearch.SendKeys(searchString + Keys.Enter);
            return new GoogleSearchResultPage(this.driver);
        }
    }
}
