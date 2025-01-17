using ProductInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventory.Services
{
    public class AuthService
    {
        private readonly NileshDBContext _context;

        public AuthService()
        {
            _context = new NileshDBContext();
        }

        public bool ValidateAdminUser(string username, string password)
        {
            return _context.Admins.Any(u => u.Username == username && u.Password == password);
        }
    }
}