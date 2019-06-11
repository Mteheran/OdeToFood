using System;
using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public interface IGreeter
    {
        string MessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string MessageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}
