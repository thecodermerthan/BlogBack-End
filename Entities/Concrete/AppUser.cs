using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Entities.Concrete
{
    public class AppUser : ITable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
