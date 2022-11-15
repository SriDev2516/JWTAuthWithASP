using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAuthDemo.JWT
{
    public interface IJWTAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
