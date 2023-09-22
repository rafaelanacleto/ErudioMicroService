using GeekShopping.Product.API.Model;
using GeekShopping.Product.API.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["MySQlConnection:MySQlConnectionString"];
var serverVersion = new MySqlServerVersion(new Version(8, 0, 34));

builder.Services.AddDbContext<MySQLContext>(op => op.UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.
    AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
