using System.Collections.Generic;
using WeatherApi.Models;

namespace WeatherApi.Services
{
    public interface ICityService
    {
        /// <summary>
        /// Searches the cities.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="take">The take.</param>
        /// <returns></returns>
        IEnumerable<City> SearchCities(string query, int take = 10); 
    }
}
