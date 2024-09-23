using System;

namespace StudentDetails.Models
{
    public class Client
    {
        public int Id { get; set; } // Add Id property

        public string? Username { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
    }
}
