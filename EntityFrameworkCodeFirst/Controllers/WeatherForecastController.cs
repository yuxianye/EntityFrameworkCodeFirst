using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkCodeFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly EntityFrameworkCodeFirst.Repository.MyDbContext _myDbContext;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, Repository.MyDbContext myDbContext)
        {
            _logger = logger;
            _myDbContext = myDbContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var count1 = _myDbContext.Products.Count();
            _myDbContext.Products.Add(new Entity.Product { ProductName = "yuxinaye", ProductNum = 20 });
            _myDbContext.SaveChanges();
            var count2 = _myDbContext.Products.Count();
            _logger.LogError("产品数量" + (count2 - count1));
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
