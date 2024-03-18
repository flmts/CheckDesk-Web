using CheckDesk_Web.Data;

namespace CheckDesk_Web.Services;


public class UserService
{
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync("http://localhost:5000/users");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
}

