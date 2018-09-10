
namespace KinopoiskTests.Entities
{
    public class FieldForDropDown
    {
        private readonly string _logout;

        public string Logout { get { return _logout; } }

        public FieldForDropDown() { }

        public FieldForDropDown(string logout)
        {
            this._logout = logout;
        }
    }
}
