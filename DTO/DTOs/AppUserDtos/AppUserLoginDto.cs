using DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.DTOs.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
