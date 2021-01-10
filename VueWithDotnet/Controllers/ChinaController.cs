using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using VueWithDotnet.Models;

namespace VueWithDotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChinaController: ControllerBase
    {
        private readonly IOptions<China> _options;
        private readonly ILogger<WeatherForecastController> _logger;

        public ChinaController(IOptions<China> options, ILogger<WeatherForecastController> logger)
        {
            _options = options;
            _logger = logger;
        }

        [HttpGet("provinces")]
        public IEnumerable<string> GetProvinces()
        {
            return _options.Value.Provinces.Select(x => x.Name);
        }

        [HttpGet("cities")]
        public IEnumerable<string> GetCities(string province)
        {
            return _options.Value.Provinces.FirstOrDefault(x => x.Name == province).City.Select(x => x.Name);
        }


        [HttpGet("areas")]
        public IEnumerable<string> GetCities(string province, string city)
        {
            return _options.Value.Provinces.FirstOrDefault(x => x.Name == province).City.FirstOrDefault(x => x.Name == city).Area;
        }
    }
}
