using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CloudDemoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        // default optional param
        //https://localhost:44317/api/weatherforecast?includeId=true
        //https://localhost:44317/api/weatherforecast?incldeId=true&need=true
        public IActionResult getweather(bool includeId = false)
        {
            var t = includeId;
            var rng = new Random();

            if (false)
            {
                //return BadRequest(" bad happen");
            }
            else
                return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                 .ToArray());
        }

        //[HttpGet]
        //[Route("{Test}")]
        //public IActionResult Test(string Test)
        //{
        //    var rng = new Random();
        //    return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray());
        //}

        [HttpGet]
        [Route("{TestInt:int}")]
        public IActionResult Te(int TestInt)
        {
            var rng = new Random();
            return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray());
        }


        //https://localhost:44317/api/weatherforecast/search?dayBase=10/10/2020
        [HttpGet]
        [Route("{Search}")]
        public IActionResult SearchBydate(DateTime dayBase, bool need = false)
        {
            var rng = new Random();
            return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray());
        }
        public ActionResult Post(Enquiry enuiry)
        {
            var s = enuiry;
            return Ok();
        }

        //https://localhost:44317/api/weatherforecast/New/CITIES
        [HttpGet]
        [Route("{New}/{CITIES}")]
        public JsonResult GetCities()
        {
            return new JsonResult( CityDataStore.Current._cities
        );
        }


        //https://localhost:44317/api/weatherforecast/New/CITIES/1
        [HttpGet]
        [Route("{New}/{CITIES}/{id}")]
        public ActionResult GetCities(int id)
        {
            var res = CityDataStore.Current._cities.FirstOrDefault(l => l.Id == id);
            if (res==null)
                {
                return NotFound();
            }

            return Ok(res);
        }

    }
}
