using Confluent.Kafka;
using DemoCustomerService.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

var config = new ProducerConfig 
{ 
    BootstrapServers = "localhost:9092" 
};

builder.Services.AddSingleton<IProducer<Null, String>>(x => new ProducerBuilder<Null,String>(config).Build());
builder.Services.AddSingleton<IWeatherDataPublisher, WeatherDataPublisher>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
