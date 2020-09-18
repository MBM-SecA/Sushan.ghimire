using System;
using System.Collections.Generic;

namespace LearnCollections
{
    public class Collections
    {
        void LearnLists()
        {
            List<byte> ages = new List<byte> { 2, 3 };

            ages.Add(1);
            ages.Add(10);
            ages.Add(100);
            ages.Add(255);


            List<Country> countries = new List<Country>();

            Country country1 = new Country();

            countries.Add(country1);
        }

        public void LearnDictionary()
        {
            Dictionary<string, string> countryCapitals = new Dictionary<string, string>
            {
                ["Nepal"] = "Kathmandu",
                ["India"] = "Delhi",
                ["US"] = "Washington"
            };

            // Data can also me initialized as:
            // Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
            // countryCapitals.Add("Nepal", "Kathmandu");
            // countryCapitals.Add("India", "Delhi");
            // countryCapitals.Add("US", "Washington");

            // Printing the contents of dictionary
            foreach (var country in countryCapitals)
            {
                Console.WriteLine($"Country: {country.Key} Capital City: {country.Value}");
            }
        }
    }

    public class Country
    {
        public string Name { get; set; }

    }
}