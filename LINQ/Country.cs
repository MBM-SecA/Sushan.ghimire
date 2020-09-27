using System;
using System.Collections.Generic;
public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }
    public double Area { get; set; }
    public long Population { get; set; }
    public DateTime IndependenceDay { get; set; }


    public Country(string n, string c, double a, long p, DateTime i = default)
    {
        Name = n;
        Continent = c;
        Area = a;
        Population = p;
        IndependenceDay = i;
    }

    public static List<Country> GetCountries()
    {
        Country c1 = new Country("Nepal", "Asia", 56546.55, 399465);
        Country c2 = new Country("India", "Asia", 497897654.55, 9879465, DateTime.Parse("1920/12/4"));
        Country c3 = new Country("Russia", "Europe", 456546323.55, 36579465, DateTime.Parse("1944/12/4"));
        Country c4 = new Country("USA", "North America", 98776546.55, 39465);
        Country c5 = new Country("Canada", "North America", 7756546.55, 99465);
        Country c6 = new Country("China", "Asia", 36556546.55, 39875);
        Country c7 = new Country("Indonesia", "Asia", 46546.55, 399465, DateTime.Parse("1949/12/4"));
        Country c8 = new Country("Belgium", "Europe", 2956546.55, 87965, DateTime.Parse("1948/12/4"));
        Country c9 = new Country("Finland", "Europe", 45655446.55, 8379465);
        Country c10 = new Country("Germany", "Europe", 5656546.55, 79465,DateTime.Parse("1934/12/4"));
        Country c11 = new Country("Greece", "Europe", 65688546.55, 8765);
        Country c12 = new Country("Argentina", "South America", 5646546.55, 4569465);
        Country c13 = new Country("Peru", "South America", 4897897897.55, 29465, DateTime.Parse("1944/12/4"));
        Country c14 = new Country("Uruguay", "South America", 226546.55, 4579465);
        Country c15 = new Country("Ecuador", "South America", 5646546.55, 1579465);
        Country c16 = new Country("Algeria", "Africa", 4556546.55, 3654465);
        Country c17 = new Country("Cameroon", "Africa", 6546546.55, 4579465);
        Country c18 = new Country("Burundi", "Africa", 9796546.55, 879465);
        Country c19 = new Country("Comoros", "Africa", 98796546.55, 79465);
        Country c20 = new Country("Benin", "Africa", 45646.55, 23465);



        var countries = new List<Country> { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20 };

        return countries;
    }
}