using System;
namespace FurnitureStore.Model.Account
{
    public class AuthenticationResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string RefreshToken { get; set; }
        public string AccessToken { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool? IsTotpEnabled { get; set; }
    }
}

