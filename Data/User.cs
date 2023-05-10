using System;

namespace AdmiPanel_HealthApp.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsEmailConfirmed { get; set; }
    }
}
