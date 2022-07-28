using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //Post: api/Auth
        [HttpPost]
        public IActionResult Post([FromBody] LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("خطا در احراز هویت !");
            }

            if (login.Username != "StudentAdmin" || login.password != "OJHD*39y")
            {
                return Unauthorized();
            }

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("TokenAuthApi")["Mag"]
                ));

            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokenOption = new JwtSecurityToken(
                issuer: new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("CurrentServerApi")["Url"],
                claims: new List<Claim>
                {
                    new Claim(ClaimTypes.Name,login.Username),
                    new Claim(ClaimTypes.Role,"Admin")
                },
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signinCredentials
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOption);

            return Ok(new { token = tokenString });
        }
    }
}
