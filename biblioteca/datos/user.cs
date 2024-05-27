
namespace UserTemplate
{
    public class User(string name, string role)
    {
        public string name = name;
        public string role = role;

        public string GetName()
        {
            return name;
        }

        public string GetRole()
        {
            return role;
        }
    }
}