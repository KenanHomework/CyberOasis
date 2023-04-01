using CyberOasis.Models.DataModels;
using CyberOasis.Models.ViewModels;

namespace CyberOasis.Interfaces;

public interface ILoginService
{
    User? SignUp(LoginVM loginVM);
    User? SignIn(LoginVM loginVM);
    void SignOut(LoginVM loginVM);


    bool UserAuthenticated();


    void CreateLoginCookie(User user, HttpContext httpContext);
    void DeleteLoginCookie(HttpContext httpContext);
}
