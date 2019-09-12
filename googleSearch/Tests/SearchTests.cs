using System.Linq;
using NUnit.Framework;
using Pages;

namespace Tests
{
    public class SearchTests : TestsBase
    {
        [Test]
        public void SearchYandex()
        {
            var googlePage = new GoogleHomePage(this.DriverManager.Driver);
            googlePage.Open();
            var link = googlePage
                .GoogleIt("yandex.ru")
                .SearchResults
                .First()
                .LinkAddress;
            Assert.AreEqual("https://yandex.ru/", link, "wrong link on first search result");
        }

    }
}
