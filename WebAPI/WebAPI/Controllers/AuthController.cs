using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Dtos;
using WebAPI.Helpers;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ProjectorDBContext _context;
        private readonly JwtService _jwtService;

        public AuthController(ProjectorDBContext context, JwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        //api/auth

        [HttpPost("login")]
            public IActionResult Login(LoginDto dto)
        {
            var user = _context.Persons.FirstOrDefault(p => p.username == dto.username);


            if(user == null || user.password != dto.password)
                return BadRequest(new { message = "Invalid Credentials" });

            var jwt = _jwtService.Generate(user.id);


            Response.Cookies.Append("jwt", jwt, new CookieOptions
            {
                HttpOnly = true
            });

            return Ok(new {
                message = "Cookie Generated Successfully"
            });

        }


        [HttpGet("verify")]
        public IActionResult Verify(){

            try
            {
                var jwt = Request.Cookies["jwt"];

                var token = _jwtService.Verify(jwt);

                int uid = int.Parse(token.Issuer);

                var user = _context.Persons.FirstOrDefault(p => p.id == uid);


                return Ok(user);
            }catch(Exception _)
            {
                return Unauthorized();
            }


        }




        [HttpPost("logout")]
            public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");

            return Ok(new { message = "Cookie Deleted" });
        }



        private bool PersonExists(int id)
        {
            return _context.Persons.Any(e => e.id == id);
        }

        




    }
}
