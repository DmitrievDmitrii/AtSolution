using System.Linq;
using Core;
using OpenQA.Selenium;
using Pages.Elements;

namespace Pages
{
    public class GoogleSearchResultPage : BasePage
    {
        public GoogleSearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://www.google.com/search?q=%20";

        public SearchResult[] SearchResults => this.driver.FindElements(By.CssSelector("div.rc"))
            .Select(element => new SearchResult(element)).ToArray();
    }
}
