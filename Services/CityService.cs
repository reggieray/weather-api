using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using WeatherApi.Models;
using WeatherApi.Helpers;

namespace WeatherApi.Services
{
    public class CityService : ICityService
    {
        /// <summary>
        /// Searches the cities.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="take">The take.</param>
        /// <returns></returns>
        public IEnumerable<City> SearchCities(string query, int take = 10)
        {
            using (var db = new LiteDatabase(@"CityData.db"))
            {
                var citiesCollections = db.GetCollection<City>("cities");
                var cities = citiesCollections.Find(x => StringExtensions.Contains(x.name, query, StringComparison.OrdinalIgnoreCase));
                return cities.Take(take);
            }
        }
    }
}
