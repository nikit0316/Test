using OpenQA.Selenium;

namespace Vk
{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected bool acceptNextAlert = true;
        protected ApplicationManager manager;
        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver;
        }
    }
}