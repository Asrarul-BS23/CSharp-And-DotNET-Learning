using System;
using System.Collections.Generic;
using System.Linq;

record City(string Name, long Population);
record Country(string Name, double Area, long Population, List<City> Cities);

class Program
{
    private static readonly Country[] countries = new Country[] {
        new Country ("Vatican City", 0.44, 526, new List<City> { new City("Vatican City", 826) }),
        new Country ("Monaco", 2.02, 38_000, new List<City> { new City("Monte Carlo", 38_000) }),
        new Country ("Nauru", 21, 10_900, new List<City> { new City("Yaren", 1_100) }),
        new Country ("Tuvalu", 26, 11_600, new List<City> { new City("Funafuti", 6_200) }),
        new Country ("San Marino", 61, 33_900, new List<City> { new City("San Marino", 4_500) }),
        new Country ("Liechtenstein", 160, 38_000, new List<City> { new City("Vaduz", 5_200) }),
        new Country ("Marshall Islands", 181, 58_000, new List<City> { new City("Majuro", 28_000) }),
        new Country ("Saint Kitts & Nevis", 261, 53_000, new List<City> { new City("Basseterre", 13_000) })
    };

    static void Main()
    {
        int[] scores = new int[] { 97, 92, 81, 60 };

        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;

        foreach (var i in scoreQuery)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        //=============== Descending Order Query =============
        IEnumerable<int> highScoresQuery =
            from score in scores
            where score > 80
            orderby score descending
            select score;

        foreach (var i in highScoresQuery)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine(highScoresQuery.Count());

        //=============== Ascending Order Query =============
        IEnumerable<int> lowScoresQuery =
            from score in scores
            where score > 80
            orderby score ascending
            select score;

        foreach (var i in lowScoresQuery)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // ============ Without IEnumerable ===================
        int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6 };

        var numQuery = from num in numbers
                       where (num % 2) == 0
                       select num;

        foreach (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
        }
        Console.WriteLine();
        var numQueryList = numQuery.ToList();
        for (int i = 0; i < numQueryList.Count(); i++)
        {
            Console.Write(numQueryList[i] + " ");
        }
        Console.WriteLine();

        //========= With User defined DataType ========

        var largeCitiesList = (
            from country in countries
            from city in country.Cities
            where city.Population > 10000
            select city
        );

        foreach (var city in largeCitiesList)
        {
            Console.WriteLine(city);
        }
    }
}
