using CyberOasis.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CyberOasis.Services
{
    public class CookieService : ICookieService
    {
        public void AppendCookie(string key, string value)
        {

        }

        public void AppendCookies(Dictionary<string, string> values)
        {
            throw new NotImplementedException();
        }

        public string GetCookie(string key)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetCookies()
        {
            throw new NotImplementedException();
        }

        public void RemoveCookie(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveCookies()
        {
            throw new NotImplementedException();
        }

        public void UpdateCookie(string key, string newValue)
        {
            throw new NotImplementedException();
        }
    }
}
