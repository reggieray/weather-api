# weather-api

This weather-api exposes a .NET core API endpoint lookup for weather city data found [here](http://bulk.openweathermap.org/sample/) on openweathermap.org.

The json data was imported into a NoSQL db using [LiteDB](https://www.litedb.org/). It also uses LiteDB to access and search the NoSQL db.

# about

This API was created for a personal Xamarin app project. As the json file was quite big to include within an app, the data was made available via an API endpoint.