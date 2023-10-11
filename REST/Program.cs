using Microsoft.EntityFrameworkCore;
using REST.Data;
using REST.Interface;
using REST.Repastorys;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepastory, UserRepastory>();
builder.Services.AddScoped<ICourseRepastorycs, CourseRepastory>();
builder.Services.AddDbContext<AppDbContext>(optins =>
{
    optins.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
