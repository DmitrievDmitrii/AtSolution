using System.Linq;
using NUnit.Framework;
using Pages;

namespace Tests
{
    public class SearchTests : TestsBase
    {
        [Test]
        [TestCase("yandex.ru")]
        [TestCase("mail.ru")]
        public void SearchYandex(string searchString)
        {
            var googlePage = new GoogleHomePage(this.DriverManager.Driver);
            googlePage.Open();
            var link = googlePage
                .GoogleIt(searchString)
                .SearchResults
                .First()
                .LinkAddress;
            Assert.AreEqual($"https://{searchString}/", link, "wrong link on first search result");
        }
    }
}
