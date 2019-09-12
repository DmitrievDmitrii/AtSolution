﻿using OpenQA.Selenium;

namespace Pages.Elements
{
    public class SearchResult
    {
        public By Selector =>By.CssSelector("div.rc");
        private readonly IWebElement element;

        public SearchResult(IWebElement element)
        {
            this.element = element;
        }

        public string LinkAddress => element.FindElement(By.CssSelector("div.rc>div>a")).GetAttribute("href");
    }
}
