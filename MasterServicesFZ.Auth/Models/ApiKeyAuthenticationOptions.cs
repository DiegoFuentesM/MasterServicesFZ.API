using Microsoft.AspNetCore.Authentication;

namespace MasterServicesFZ.Auth.Models
{
    public class ApiKeyAuthenticationOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScheme = "ClientKey";
        public const string HeaderName = "x-api-key";
    }
}