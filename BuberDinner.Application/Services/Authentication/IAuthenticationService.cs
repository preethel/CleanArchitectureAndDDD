namespace BubberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticatinResult Register(string firstName, string lastName, string email, string password );
    AuthenticatinResult Login(string email, string password);
}