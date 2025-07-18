using Mini_Medical_Record_API.Application.Login;
using Mini_Medical_Record_API.Application.Mini_Medical_Record;
using Mini_Medical_Record_API.Infrastructure;
using Mini_Medical_Record_API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<ILogin, LoginRespository>();
builder.Services.AddScoped<IMini_Medical_Record, Mini_Medical_Record_Dashboard_Repository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<APIMiddleware>();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
