﻿using System.Security.Policy;

namespace AP.Data.DTO
{
    public class CreateUserDto
    {
        public string Username { get; set; } = null!;
        
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
