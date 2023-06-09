using Ordering.API.Extensions;
using Ordering.API.Extenstions;
using Ordering.Infrastructure.SqlServer.Persistence;
using Polly;

var builder = WebApplication.CreateBuilder(args);
 
// Add services to the container. 
ConfigurationManager configurationManager = builder.Configuration;

builder.Services.AddControllers();
builder.Services.Injections(configurationManager);
builder.Services.AddRabbitMQServices(configurationManager);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//IHost host = builder.Build();
//host.MigrateDatabase<OrderContext>((context, services) =>
//{
//    var logger = services.GetService<ILogger<OrderContextSeed>>();
//    OrderContextSeed
//        .SeedAsync(context, logger)
//        .Wait();
//});
//host.Run();


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
