using Microsoft.AspNetCore.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace JWTAuthDemo
{
    public class JwtAuthenticationManager
    {

        private readonly string key;

        private readonly IDictionary<string, string> users = new Dictionary<string, string>()
        { {"test","password"},{"test1","pwd"}};

        public JwtAuthenticationManager(string key)
        {
            this.key = key;
        }

        public string Authenticate(string username,string password)
        {
            if(!users.Any(u=> u.Key == username && u.Value == password))
            { return null; }

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();    

            var tokenKey = Encoding.ASCII.GetBytes(key);



            return null;
        }
    }
}
