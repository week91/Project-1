using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model1;
using Newtonsoft.Json;


namespace NewsApi.Controllers
{
    [Route("[controller]/[action]")]
    
    [ApiController]
    public class ValuesJwtController : ControllerBase
    {
        private readonly IHttpContextAccessor _context;

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
      

        public ValuesJwtController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IConfiguration configuration, IHttpContextAccessor context
                )
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        [Authorize]
       
        public IActionResult GetLogin()
        {
            var re = Request.Headers["Authorization"].ToString();
            var tt = re.Substring(7);
            var jwt = tt;
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(jwt);
            var jti = token.Claims.First(claim => claim.Type == "sub").Value;
            var jtii = token.Claims.First(claim => claim.Type == "jti").Value;
            var response = new
            {
                id = jtii,
                email= jti,
            };
            return Ok(response);

        }                   

        [AllowAnonymous]

        public IActionResult GetRole()
        {
            return Ok($"Ваша роль: администратор {User.Identity.Name}");
        }
    }
}
