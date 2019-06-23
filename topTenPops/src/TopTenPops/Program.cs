using System;
using System.Collections.Generic;
using System.Linq;
using TopTenPops;

namespace Pluralsight.BegCShCollections.ReadCountriesForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"H:\C#\Resources\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            //List<Country> countries = reader.ReadAllCountries();

            Dictionary<string, List<Country>> countries = reader.ReadAllCountries();
            foreach (string region in countries.Keys)
                Console.WriteLine(region);

            Console.Write("Which of the above regions do you want? ");
            string chosenRegion = Console.ReadLine();

            if (countries.ContainsKey(chosenRegion))
            {
                foreach (Country country in countries[chosenRegion].Take(10))
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            else
            {
                Console.WriteLine("That is not a valid region");
            }


            /*
            var filteredCountries = countries.Where(x => !x.Name.Contains(','));//.Take(20)
            var filteredCountries2 = from country in countries
                                     where !country.Name.Contains(',')
                                     select country;

            foreach (Country country in filteredCountries2)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }

            for (int i = 12; i <= 14; i++)
                Console.WriteLine(countries[i].Name);

            // comment this out to see all countries, without removing the ones with commas
             reader.RemoveCommaCountries(countries);

			Console.Write("Enter no. of countries to display> ");
			bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
			if (!inputIsInt || userInput <= 0)
			{
				Console.WriteLine("You must type in a +ve integer. Exiting");
				return;
			}

		    int maxToDisplay = userInput;
			for (int i = 0; i< countries.Count; i++)
			{
				if (i > 0 && (i % maxToDisplay == 0))
				{
					Console.WriteLine("Hit return to continue, anything else to quit>");
					if (Console.ReadLine() != "")
						break;
				}

				Country country = countries[i];
				Console.WriteLine($"{i + 1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}*/
        }
    }
}
