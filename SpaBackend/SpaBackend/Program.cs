using Microsoft.EntityFrameworkCore;
using SpaBackend.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SpaDbContext>(o=>
    o.UseSqlServer("Server=DESKTOP-7PPCNFC\\SQLEXPRESS;Database=Spa;Trusted_Connection=True;Encrypt=False;"));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
app.UseAuthorization();

app.MapControllers();

app.Run();