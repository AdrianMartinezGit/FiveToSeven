using FiveToSeven.Services.MadLib;
using FiveToSeven.Services.OddEven;
using FiveToSeven.Services.ReverseABC;
using FiveToSeven.Services.ReverseNum;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddEvenService, OddEvenService>();
builder.Services.AddScoped<IReverseABCService, ReverseABCService>();
builder.Services.AddScoped<IReverseNumService, ReverseNumService>();

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
