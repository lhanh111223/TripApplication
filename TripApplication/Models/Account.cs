using System;
using System.Collections.Generic;

namespace TripApplication.Models
{
    public partial class Account
    {
        public string Username { get; set; } = null!;
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
