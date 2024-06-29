using System;
using System.Collections.Generic;

namespace AP.Data.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);
}
