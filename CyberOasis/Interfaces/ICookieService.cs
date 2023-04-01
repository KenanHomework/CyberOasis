namespace CyberOasis.Interfaces;

public interface ICookieService
{

    /* Get Cookie(s) */
    string GetCookie(string key);


    /* Adding Cookie(s) */
    void AppendCookie(string key, string value);
    void AppendCookies(Dictionary<string, string> values);


    /* Updating Cookie(s) */
    void UpdateCookie(string key, string newValue);

    /* Delete Cookie(s) */
    void RemoveCookie(string key);
    void RemoveCookies();

}
