using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace TransactionUpdate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult GetToken()
        {
            var claims = new[]
    {
        new Claim(ClaimTypes.Name, "Admin"),
        // Add other claims as needed (e.g., roles)
    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "https://localhost:7206",
                audience: "https://localhost:7206",
                claims: claims,
                expires: DateTime.UtcNow.AddDays(7),
                signingCredentials: creds
            );

           var generatedToken = new  JwtSecurityTokenHandler().WriteToken(token);

            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
          
         
            return Ok(new { token = generatedToken });
        }
    }
}
