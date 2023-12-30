using SuplyManagement.Configurations;
using SuplyManagement.Contracts;
using SuplyManagement.Repositories;
using SuplyManagement.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<CompanyService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICompanyRespository, CompanyRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

new EnvironmentConfiguration()
    .Service(builder.Services)
    .Configuration(builder.Configuration)
    .DbConnection()
    .UseCors();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
