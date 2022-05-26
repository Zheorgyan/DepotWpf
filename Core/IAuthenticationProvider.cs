namespace WpfApp.Core
{
    public interface IAuthenticationProvider
    {
        string Login { get; }
        string Password { get; }
        string[] Roles { get; }
        bool CheckAutentication(string login, string password);
    }
}
