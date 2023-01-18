using Microsoft.EntityFrameworkCore;
using ReadStudentBooks.Data;
using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;
using ReadStudentBooks.Models.Enum;
using ReadStudentBooks.Repository;

const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
       builder.Configuration.GetConnectionString("DefaultConnection")
    ));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICreditCardRepository, CreditCardRepository>();

var userRepo = builder.Services.BuildServiceProvider()
    .GetRequiredService<IUserRepository>();

if (!userRepo.UserExist("edvin"))
{
    userRepo.Register(new UserDto("edvin", "Edvin", "Lekovic", "edvin", "edvin", Role.ADMIN));
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
