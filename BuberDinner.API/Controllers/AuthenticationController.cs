using BuberDinner.APPLICATION.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationServices _authenticationService;

    public AuthenticationController(IAuthenticationServices authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest registerRequest)
    {
        AuthenticationResult result = _authenticationService.Register(registerRequest.FirstName, 
                                                                    registerRequest.LastName,
                                                                    registerRequest.Email,
                                                                    registerRequest.Password);

        AuthenticationResponse response = new AuthenticationResponse(result.id,
                                                                    result.FirstName,
                                                                    result.LastName,
                                                                    result.Email,
                                                                    result.Token);
            
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        AuthenticationResult result = _authenticationService.Login(request.email, request.password);

        AuthenticationResponse response = new AuthenticationResponse(result.id,
                                                                    result.FirstName,
                                                                    result.LastName,
                                                                    result.Email,
                                                                    result.Token); 

        return Ok(response);
    }
}