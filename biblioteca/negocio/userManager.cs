using UserManagerInterface;

namespace UserManagerClass
{
    public class UserManager : IUserManager
    {
        public void UserStatus()
        {
            Console.WriteLine("Esta en sin deudas");
        }

        public void UserActivity()
        {
            Console.WriteLine("Esta leyendo libros");
        }

        public void UserAuthentication()
        {
            Console.WriteLine("Es usuario a iniciado sesion...");
        }

        public void UserLogout()
        {
            Console.WriteLine("El usuario ha cerrado sesion...");
        }
    }
}