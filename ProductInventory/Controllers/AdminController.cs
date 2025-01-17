using ProductInventory.Models;
using ProductInventory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductInventory.Controllers
{
    public class AdminController : ApiController
    {


        private readonly AuthService _authService;

        public AdminController()
        {
            _authService = new AuthService();
        }

        [HttpPost]
        [Route("api/admin/login")]
        public IHttpActionResult Login([FromBody] Admin adminUser)
        {
            if (_authService.ValidateAdminUser(adminUser.Username, adminUser.Password))
            {
                // Create and return a token (for simplicity, we'll use a basic string)
                var token = "secure_token"; // In a real-world scenario, generate a JWT or secure token
                return Ok(token);
            }
            return Unauthorized();
        }
        //    private readonly List<Admin> _adminUsers = new List<Admin>
        //{
        //    new Admin { ID = 1, Username = "admin", Password = "password" },
        //    new Admin { ID = 2, Username = "Nilesh", Password = "Nilesh15" }


        //};

        //    [HttpPost]
        //    [Route("api/admin/login")]
        //    public IHttpActionResult Login(Admin loginUser)
        //    {
        //        var admin = _adminUsers.FirstOrDefault(u => u.Username == loginUser.Username && u.Password == loginUser.Password);
        //        if (admin == null)
        //        {
        //            return Unauthorized();
        //        }

        //        return Ok("Login successful");
        //    }
        //}
    }
}
