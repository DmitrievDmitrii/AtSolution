using OpenQA.Selenium;

namespace Core
{
    public abstract class BasePage
    {
        public abstract string Url { get; }

        protected readonly IWebDriver driver;

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public virtual void Open()
        {
            this.driver.Url = Url;
        }
    }
}
