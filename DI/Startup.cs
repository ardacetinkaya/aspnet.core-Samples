using System;
using Microsoft.Framework.DependencyInjection;
namespace DI.App
{
    
    public class Program
    {
        public static void Main()
        {
            var services = new ServiceCollection();
            services.AddTransient<IUserService>(s=> new UserManagementService());
            
            IServiceProvider provider = services.BuildServiceProvider();
            
            IUserService userService = provider.GetService<IUserService>(); 
            var userName = userService.GetUserName();
            
            Console.WriteLine($"Hello {userName}");
            
            var user = userService.GetUser(3);
            System.Console.WriteLine(user.UserName);
            System.Console.WriteLine(user.EMail);
        }
    }
    
    
}