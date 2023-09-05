namespace BubberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticatinResult Login(string email, string password)
    {
        return new AuthenticatinResult(
            Guid.NewGuid(),
            "FirstName",
            "LastName",
            email,
            "token"
        );
    }

    public AuthenticatinResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticatinResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            "token"
        );
    }
}
