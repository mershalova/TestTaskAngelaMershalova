using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestTaskAngelaMershalova;
using TestTaskAngelaMershalova.Interfaces;
using TestTaskAngelaMershalova.Repositories;
using TestTaskAngelaMershalova.Repositories.Interfaces;
using TestTaskAngelaMershalova.Repositories.Services;
using TestTaskAngelaMershalova.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApplicationDbContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IRepository<,>), typeof(BaseRepository<,>));
builder.Services.AddScoped<IIncedentService, IncedentService>();
builder.Services.AddScoped<IAccountService, AccountService>();


//adding mapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new ApplicationProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

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
