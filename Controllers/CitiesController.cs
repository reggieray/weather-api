using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WeatherApi.Models;
using WeatherApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherApi.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        /// <summary>
        /// The city service
        /// </summary>
        private readonly ICityService _cityService;
        /// <summary>
        /// Initializes a new instance of the <see cref="CitiesController"/> class.
        /// </summary>
        /// <param name="cityService">The city service.</param>
        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }
        /// <summary>
        /// Gets the specified q.
        /// </summary>
        /// <param name="q">The q.</param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<City> Get([FromQuery(Name = "q")] string q)
        {
            return _cityService.SearchCities(q);
        }
    }
}
