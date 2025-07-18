using Mini_Medical_Record_API.Domain.Login;

namespace Mini_Medical_Record_API.Application.Login
{
    public interface ILogin
    {
        Task<LoginResult> Login(LoginResponse loginResponse);
        Task<string> UserRegistration(RegisterResponse Regres);


    }
}
