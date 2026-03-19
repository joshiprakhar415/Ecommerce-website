using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public class LoginRequest
    {
        [JsonPropertyName("username")]
        public string? UserName { get; set; }
        
        [JsonPropertyName("password")]
        public string? Password { get; set; }
    }

    public class RegisterRequest
    {
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        [JsonPropertyName("username")]
        public string? UserName { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }
    }

    public class ForgotPasswordRequest
    {
        [JsonPropertyName("email")]
        public string? Email { get; set; }
    }

    public class ResetPasswordRequest
    {
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("otp")]
        public string? Otp { get; set; }

        [JsonPropertyName("newPassword")]
        public string? NewPassword { get; set; }
    }
}