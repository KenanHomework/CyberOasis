namespace CyberOasis.Models.ViewModels;

public class LoginVM
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public bool RememberMe { get; set; }
}
