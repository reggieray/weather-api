﻿using System;

namespace WeatherApi.Helpers
{
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="toCheck">To check.</param>
        /// <param name="comp">The comp.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified to check]; otherwise, <c>false</c>.
        /// </returns>
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }
}
