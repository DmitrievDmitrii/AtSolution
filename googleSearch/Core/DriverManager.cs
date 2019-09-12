using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Core
{
    public class DriverManager
    {
        public IWebDriver Driver { get; private set; }

        public void CreateDriver(BrowserType browser)
        {
            switch (browser)
            {
                case BrowserType.Chrome:
                    this.Driver = new ChromeDriver(Directory.GetCurrentDirectory());
                    break;
            }
        }

        public void QuitDriver()
        {
            this.Driver?.Quit();
        }
    }

    public enum BrowserType
    {
        Chrome
    }
}
