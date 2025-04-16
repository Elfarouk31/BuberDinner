using BuberDinner.APPLICATION.Services.Authentication;

namespace BuberDinner.APPLICATION.Services.Authentication;

public interface IAuthenticationServices
{
    AuthenticationResult Login(string email, string password);
    AuthenticationResult Register(string firstName, string lastName, string email, string password);
}