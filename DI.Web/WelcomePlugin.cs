using System;

namespace Webby.Web
{
    public class WelcomePlugin : IPluginService
    {
        public string Name
        {
            get
            {
                return "Hello World, This is Webby, DI sample for ASP.NET 5";
            }
        }
    }

}