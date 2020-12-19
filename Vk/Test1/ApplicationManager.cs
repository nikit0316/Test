using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Vk
{
    public class ApplicationManager
    {
        public IWebDriver driver;
        public IDictionary<string, object> vars {get; private set;}
        public IJavaScriptExecutor js;
        private string baseURL;

        private NavigationHelper navigation;
        private SearchHelper search;

        public IWebDriver Driver
        {
            get { return driver; }
        }
        public NavigationHelper Navigation
        {
            get
            {
                return navigation;
            }
        }

        public SearchHelper Search
        {
            get { return search; }
        }

        public ApplicationManager()
        {
                driver = new ChromeDriver(@"C:/");
                js = (IJavaScriptExecutor)driver;
                vars = new Dictionary<string, object>();
                navigation = new NavigationHelper(this,baseURL);
                search = new SearchHelper(this);
        }
        
        public void Stop()
        {
            driver.Quit();
        }

    }
}