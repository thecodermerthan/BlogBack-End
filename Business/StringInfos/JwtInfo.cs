using System;
using System.Collections.Generic;
using System.Text;

namespace Business.StringInfos
{
    public class JwtInfo
    {
        public const string Issuer = "http://localhost:49602";
        public const string Audience = "http://localhost:5000";
        public const string SecurityKey = "mert123";
        public const double Expires = 40;
    }
}
