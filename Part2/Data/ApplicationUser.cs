using Microsoft.AspNetCore.Identity;
using System;

namespace Part2.Data

{
    public class ApplicationUser : IdentityUser
    {
        public DateTime DateOfBirth { get; set; }
        
    }
}
