using WebDriverManager;
using WebDriverManager.DriverConfigs;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace Core.WeDriverService
{
    public class WebDriverManager
    {
        public void SetupDriver(string browserName)
        {
            //Default value
            IDriverConfig config = new ChromeConfig();
            switch (browserName.ToLower())
            {
                case "firefox":
                    config = new FirefoxConfig();
                    break;
                case "microsoftedge":
                    config = new EdgeConfig();
                    break;


            }
            SetupConfig(config);
        }


        private void SetupConfig(IDriverConfig config)
        {
            new DriverManager().SetUpDriver(config, "Latest", Architecture.X32);
        } 

    }
}
