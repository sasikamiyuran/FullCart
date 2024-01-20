using FullCart.Application.Services.AuthService;
using FullCart.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FullCart.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthService _authService;
        public class AuthenticationRequestBody
        {
            public string? UserName { get; set; }
            public string? Password { get; set; }
        }


        public AuthenticationController(IConfiguration configuration, IAuthService authService)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _authService = authService ?? throw new ArgumentNullException();
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(AuthenticationRequestBody authenticationRequest)
        {
            var token = await _authService.GenerateToken(authenticationRequest.UserName, authenticationRequest.Password);

            if(token  == null)
            {
                return Unauthorized();
            }

             return Ok(token);

            ////Step 1: valicate username/password
            //var user = ValidateUserCredentials(authenticationRequest.UserName, authenticationRequest.Password);

            //if(user == null)
            //{
            //    return Unauthorized();
            //}

            ////Step 2: create a token
            //var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["Authentication:SecretForKey"]));
            //var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            ////The claim
            //var claimForToken = new List<Claim>();
            //claimForToken.Add(new Claim("sub", "1"));


            //var jwtSecurityToken = new JwtSecurityToken(
            //        _configuration["Authentication:Issuer"],
            //        _configuration["Authentication:Audience"],
            //        claimForToken,
            //        DateTime.UtcNow,
            //        DateTime.UtcNow.AddHours(1),
            //        signingCredentials
            //    );

            //var tokenToReturn = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            //return Ok(tokenToReturn);
        }

        private string ValidateUserCredentials(string? userName, string? password)
        {
            var userId = User.Identity.Name;
            return "testStr";
        }
    }
}
