namespace JobService.Core.DTOs;

public class LoginResponseDto
{
    public LocalUser User { get; set; }
    public string Token { get; set; }
}