namespace DI.App
{   
    interface IUserService
    {
        string GetUserName();
        User GetUser(int userId);
        
    }
}