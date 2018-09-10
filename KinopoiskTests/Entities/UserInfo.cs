
namespace KinopoiskTests.Entities
{
    public class UserInfo
    {
        private readonly string _login;
        private readonly string _password;

        public string Login { get { return _login; } }
        public string Password { get { return _password; } }

        public UserInfo() { }

        public UserInfo(string login, string password)
        {
            this._login = login;
            this._password = password;
        }
    }
}
