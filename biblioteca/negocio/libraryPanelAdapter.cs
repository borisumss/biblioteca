using LibraryPanelView;
using LibraryManagerInterface;
using UserManagerInterface;

namespace LibraryPanel
{
    public class LibraryPanelAdapter(ILibraryManager libraryManager, IUserManager userManager) : ILibraryPanel
    {
        ILibraryManager libraryManager = libraryManager;
        IUserManager userManager = userManager;
        public void AddBook()
        {
            libraryManager.AddBook();
        }

        public void BorrowBook()
        {
            libraryManager.BorrowBook();
        }

        public void ReturnBook()
        {
            libraryManager.ReturnBook();
        }

        public void SaveBook()
        {
            libraryManager.SaveBook();
        }

        public void UserActivity()
        {
            userManager.UserActivity();
        }

        public void UserAuthentication()
        {
            userManager.UserAuthentication();
        }

        public void UserLogout()
        {
            userManager.UserLogout();
        }

        public void UserStatus()
        {
            userManager.UserStatus();
        }
    }
}