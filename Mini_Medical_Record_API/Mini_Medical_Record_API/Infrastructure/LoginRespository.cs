using Mini_Medical_Record_API.Application.Login;
using Mini_Medical_Record_API.Domain.Login;

namespace Mini_Medical_Record_API.Infrastructure
{
    public class LoginRespository : ILogin
    {
        private readonly IConfiguration _configuration;

        public LoginRespository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<LoginResult> LoginAsync(LoginResponse loginResponse)
        {
            if (loginResponse.Username == "admin" && loginResponse.Password == "password")
            {
              

                return await Task.FromResult(new LoginResult
                {
                    Success = true,
                    Message = "Login successful"
                });
            }

            return await Task.FromResult(new LoginResult
            {
                Success = false,
                Message = "Login failed"
            });
        }
    }
}
