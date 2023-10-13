using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<WeddingGiftDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DbConnectionString"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Configuration.GetValue<bool>("UseDeveloperExceptionPage"))
    app.UseDeveloperExceptionPage();                                 
else
    app.UseExceptionHandler("/error");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("/error/test", () => { throw new Exception("test"); });

app.MapControllers();

app.Run();

public partial class Program { }
