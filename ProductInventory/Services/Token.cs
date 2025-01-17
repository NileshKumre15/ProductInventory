using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventory.Services
{
    public class Token
    {
        public static string GenerateToken()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        }
    }
}