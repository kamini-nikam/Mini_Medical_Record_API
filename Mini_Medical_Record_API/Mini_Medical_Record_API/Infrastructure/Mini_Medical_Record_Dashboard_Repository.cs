using Microsoft.Extensions.Configuration;
using Mini_Medical_Record_API.Application.Mini_Medical_Record;

namespace Mini_Medical_Record_API.Infrastructure
{
    public class Mini_Medical_Record_Dashboard_Repository : IMini_Medical_Record
    {
        private readonly string _connectionString;

        public Mini_Medical_Record_Dashboard_Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }


    }
}
