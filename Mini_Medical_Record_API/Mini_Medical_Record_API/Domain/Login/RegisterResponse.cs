namespace Mini_Medical_Record_API.Domain.Login
{
    public interface RegisterResponse
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
    }
}
