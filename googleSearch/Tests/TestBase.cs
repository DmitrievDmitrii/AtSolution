using Core;
using NUnit.Framework;

namespace Tests
{
    public class TestsBase
    {
        protected DriverManager DriverManager;

        [OneTimeSetUp]
        public void Setup()
        {
            this.DriverManager = new DriverManager();
            this.DriverManager.CreateDriver(BrowserType.Chrome);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            this.DriverManager.QuitDriver();
        }
    }
}