namespace Webby.Web
{

    public class HomeController
    {
        IPluginService plugin;

        public HomeController(IPluginService service)
        {

            this.plugin = service;
        }
        public string Index()
        {
           
            return plugin.Name;
        }
    }
}