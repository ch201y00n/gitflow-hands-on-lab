using System;
using System.Collections.Generic;

namespace GitflowHandsOnLab
{
    public class Test
    {
        /// <summary>
        /// Collection of cities for testing weather functionality
        /// </summary>
        public static readonly List<string> Cities = new List<string>
        {
            "Seoul",
            "Busan",
            "Incheon",
            "Daegu",
            "Daejeon",
            "Gwangju",
            "Ulsan",
            "Suwon",
            "Goyang",
            "Seongnam",
            "Bucheon",
            "Ansan",
            "Cheongju",
            "Jeonju",
            "Anyang",
            "Cheonan",
            "Pohang",
            "Changwon",
            "Gimhae",
            "Jeju"
        };

        /// <summary>
        /// Enumerates through all cities and prints them to console
        /// </summary>
        public static void EnumerateCities()
        {
            Console.WriteLine("Available cities for weather testing:");
            Console.WriteLine("====================================");
            
            for (int i = 0; i < Cities.Count; i++)
            {
                Console.WriteLine($"{i + 1:D2}. {Cities[i]}");
            }
            
            Console.WriteLine($"\nTotal cities: {Cities.Count}");
        }

        /// <summary>
        /// Gets a random city from the collection
        /// </summary>
        /// <returns>Random city name</returns>
        public static string GetRandomCity()
        {
            Random random = new Random();
            int index = random.Next(Cities.Count);
            return Cities[index];
        }

        /// <summary>
        /// Validates if a city exists in the collection
        /// </summary>
        /// <param name="cityName">City name to validate</param>
        /// <returns>True if city exists, false otherwise</returns>
        public static bool IsValidCity(string cityName)
        {
            return Cities.Contains(cityName, StringComparer.OrdinalIgnoreCase);
        }
    }
}