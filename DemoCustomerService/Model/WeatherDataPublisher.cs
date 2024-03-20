using Confluent.Kafka;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DemoCustomerService.Model
{
    public class WeatherDataPublisher : IWeatherDataPublisher
    {
        private readonly IProducer<Null, string> _producer;

        public WeatherDataPublisher(IProducer<Null,string> producer)
        {
            this._producer = producer;

        }

        public async Task ProduceAsync(Weather weather)
        {
            await this._producer.ProduceAsync("weather-topic", new Message<Null, string>
            {
                Value = JsonConvert.SerializeObject(weather)
            }); ;
        }
    }

    public record Weather(string State, int Temperature);
}
