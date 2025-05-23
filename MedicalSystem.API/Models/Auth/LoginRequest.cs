﻿namespace MedicalSystem.API.Models.Auth;

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }

    // Optional for registration
    public string? Role { get; set; }
}
