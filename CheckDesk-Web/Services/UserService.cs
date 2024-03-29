﻿using CheckDesk_Web.Data;
using Newtonsoft.Json;


namespace CheckDesk_Web.Services { 

    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync("http://localhost:5000/api/users");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<User>>(content);
        }
    }
}
