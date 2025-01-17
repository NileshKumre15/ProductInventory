using ProductInventory.Models;
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
        private readonly List<Admin> _adminUsers = new List<Admin>
    {
        new Admin { ID = 1, Username = "admin", Password = "password" },
        new Admin { ID = 1, Username = "Nilesh", Password = "Nilesh15" }

        
    };

        [HttpPost]
        [Route("api/admin/login")]
        public IHttpActionResult Login(Admin loginUser)
        {
            var admin = _adminUsers.FirstOrDefault(u => u.Username == loginUser.Username && u.Password == loginUser.Password);
            if (admin == null)
            {
                return Unauthorized();
            }

            return Ok("Login successful");
        }
    }
}
