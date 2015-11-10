namespace DI.App
{
    public class UserManagementService : IUserService
    {
        private User _user = new User(){ UserName="Arda", EMail="mail@email.com" };
        public User GetUser(int userId)
        {
            return _user;
        }

        public string GetUserName()
        {
            return this._user.UserName;
        }
    }
}