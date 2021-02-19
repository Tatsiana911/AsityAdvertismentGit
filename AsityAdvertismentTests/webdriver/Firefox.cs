using OpenQA.Selenium;

namespace webdriver
{
    internal class Firefox : IWebDriver
    {
        private string v;

        public Firefox(string v)
        {
            this.v = v;
        }
    }
}