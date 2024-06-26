using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Client.Identity;
using Shared.Dtos.Account;
using Shared.Interfaces;

namespace Client.Services
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient _httpClient;
        private readonly CustomAuthenticationStateProvider _authenticationStateProvider;

        public AccountService(HttpClient httpClient, CustomAuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> Login(LoginDto loginDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/account/login", loginDto);
            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            var userLogInInfo = await response.Content.ReadFromJsonAsync<UserLogInInfo>();
            await _authenticationStateProvider.MarkUserAsAuthenticated(userLogInInfo.Token);
            return true;
        }

        public async Task Logout()
        {
            await _authenticationStateProvider.MarkUserAsLoggedOut();
        }

        public async Task<bool> Register(RegisterDto registerDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/account/register", registerDto);
            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            var newUser = await response.Content.ReadFromJsonAsync<NewUserDto>();
            await _authenticationStateProvider.MarkUserAsAuthenticated(newUser.Token);
            return true;
        }
    }
}