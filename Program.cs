using MiniChallengeFiveToSeven___Endpoints.Services.MadLib;
using MiniChallengeFiveToSeven___Endpoints.Services.OddOrEven;
using MiniChallengeFiveToSeven___Endpoints.Services.ReverseInt;
using MiniChallengeFiveToSeven___Endpoints.Services.ReverseString;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseStringService, ReverseStringService>();
builder.Services.AddScoped<IReverseIntService, ReverseIntService>();

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
