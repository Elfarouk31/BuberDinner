using BuberDinner.APPLICATION.Services.Authentication;

namespace BuberDinner.APPLICATION.Services.Authentication;

public class AuthenticationServices : IAuthenticationServices
{
    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            "token");
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "FirstName", 
            "LastName",
            "Email",
            "Token");
    }
}
