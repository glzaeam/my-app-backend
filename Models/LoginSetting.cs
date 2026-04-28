namespace NexumAPI.Models;
public class LoginSetting
{
    public Guid Id { get; set; }
    public int MaxFailedAttempts { get; set; } = 5;
    public int LockoutDuration { get; set; } = 15;
    public int CaptchaAfter { get; set; } = 3;
    public bool IpWhitelistEnabled { get; set; }
    public string? AllowedIps { get; set; }
    public int SessionTimeoutMinutes { get; set; } = 480;
    public int MaxConcurrentSessions { get; set; } = 3;
}