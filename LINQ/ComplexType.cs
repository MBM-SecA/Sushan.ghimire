using System.Linq;
using System;
public class ComplexType
{
    public void LearnLINQ()
    {
        // Program for countries
            var countries = Country.GetCountries();

            var asianCountries = from country in countries
                                 where country.Continent == "Asia"
                                 select country;

            // HW1: List countries in EUROPE which has population less than 100k
            
            var europeanCountries = from country in countries
                                    where country.Continent == "Europe" && country.Population < 100000
                                    select country;

            Console.WriteLine("European countries with population less than 100k are:");
            foreach (var Country in europeanCountries)
            {
                Console.WriteLine(Country.Name);
            }
            
            // HW2: List countries in ASIA which are never invaded.
            var asianCountries1 = from asianCountry in countries
                                    where asianCountry.Continent == "Asia" && asianCountry.IndependenceDay == default 
                                    select asianCountry;

            Console.WriteLine("Asian countries which are never invaded are::");
            foreach (var country in asianCountries1)
            {
                Console.WriteLine(country.Name);
            }

            // HW3: Is there any African country in your country collection
            // HW4: Print first two largest Asian countriy names
    }
}