using System;
using FurnitureStore.Model.Account;


namespace FurnitureStore.Services.Interfaces
{
    public interface IAccountService
    {
        public Task<UserResponse> Register(RegisterRequest request);
        //   public Task<AuthenticationResponse> Authenticate(string username, string password, string ipAddress);
    }
}

