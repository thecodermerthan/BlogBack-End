using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Utilities.JWTTool
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser);
    }
}
