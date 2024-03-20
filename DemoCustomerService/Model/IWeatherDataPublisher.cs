namespace DemoCustomerService.Model
{
    public interface IWeatherDataPublisher
    {
        public Task ProduceAsync(Weather weather);
    }
}
