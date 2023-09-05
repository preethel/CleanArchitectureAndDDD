namespace BubberDinner.Application.Services.Authentication;


public record AuthenticatinResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);
