using Microsoft.EntityFrameworkCore;
using Mission10_Mattern.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BowlingDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BowlingConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000") // Ensure lowercase `localhost`
                .AllowAnyMethod()  // Allow GET, POST, PUT, DELETE, etc.
                .AllowAnyHeader(); // Allow custom headers
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// app.UseCors(x => x.WithOrigins("https://localhost:3000"));

app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();