using OpenQA.Selenium;
using Pitstop.UITest.PageModel.Pages;
using Pitstop.UITest.PageModel.Pages.CustomerManagement;
using Pitstop.UITest.PageModel.Pages.VehicleManagement;
using Pitstop.UITest.PageModel.Pages.WorkshopManagement;
using Pitstop.UITest.PageModel.Pages.RentalManagement;
using Pitstop.UITest.PageModel.Pages.ReviewManagement;

namespace Pitstop.UITest.PageModel
{
    public class MainMenu
    {
        private readonly PitstopApp _pitStop;

        public MainMenu(PitstopApp pitstop)
        {
            _pitStop = pitstop;
        }

        public HomePage Home()
        {
            _pitStop.WebDriver.FindElement(By.Id("MainMenu.Home")).Click();
            return new HomePage(_pitStop);
        }

        public CustomerManagementPage CustomerManagement()
        {
            _pitStop.WebDriver.FindElement(By.Id("MainMenu.CustomerManagement")).Click();
            return new CustomerManagementPage(_pitStop);
        }

        public VehicleManagementPage VehicleManagement()
        {
            _pitStop.WebDriver.FindElement(By.Id("MainMenu.VehicleManagement")).Click();
            return new VehicleManagementPage(_pitStop);
        }

        public WorkshopManagementPage WorkshopManagement()
        {
            _pitStop.WebDriver.FindElement(By.Id("MainMenu.WorkshopManagement")).Click();
            return new WorkshopManagementPage(_pitStop);
        }
        
        public RentalManagement RentalManagement()
        {
            _pitStop.WebDriver.FindElement(By.Id("MainMenu.RentalManagement")).Click();
            return new RentalManagement(_pitStop);
        }

        public ReviewManagementPage ReviewManagement()
        {
            _pitStop.WebDriver.FindElement(By.Id("MainMenu.ReviewManagement")).Click();
            return new ReviewManagementPage(_pitStop);
        }
        
        public AboutPage About()
        {
            _pitStop.WebDriver.FindElement(By.Id("MainMenu.About")).Click();
            return new AboutPage(_pitStop);
        }
    }
}