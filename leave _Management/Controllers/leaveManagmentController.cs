using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace leave__Management.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class leaveManagmentController : ControllerBase
    {
        private readonly IJwtAuthenticationManager jwtAuthenticationManager;

        public leaveManagmentController(IJwtAuthenticationManager jWTAuthenticationManager)
        {
            this.jwtAuthenticationManager = jWTAuthenticationManager;
        }

        // GET: api/Name
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "New York", "New Jersey" };
        }

        // GET: api/Name/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "New Jersey";
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserCred userCred)
        {
            var token = jwtAuthenticationManager.Authenticate(userCred.Username, userCred.Password);

            if (token == null)
                return Unauthorized();

            return Ok(token);
        }
    }
}