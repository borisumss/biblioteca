
namespace LibraryPanelView
{
    public interface ILibraryPanel
    {
        void BorrowBook();
        void AddBook();
        void ReturnBook();
        void SaveBook();
        void UserStatus();
        void UserActivity();
        void UserLogout();
        void UserAuthentication();
    }
}