using System;
using System.ComponentModel.DataAnnotations;

namespace MedicalSystem.Application.DTOs
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public string Role { get; set; }
        public string UserId { get; set; }
    }
}
