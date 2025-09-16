using System;

namespace CSharpBasics_T081
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strUserChoice;
            do
            {
                Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
                Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "Delhi" };
                Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C." };
                Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "Utah" };
                Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };
    
                // List<Country> listCountries = new List<Country>();
                List<string, Country> listCountries = new List<string, Country>();
                listCountries.Add( country1.Code , country1 );
                listCountries.Add( country2.Code , country2 );
                listCountries.Add( country3.Code , country3 );
                listCountries.Add( country4.Code , country4 );
                listCountries.Add( country5.Code , country5 );

                Console.WriteLine("Please enter country code:");
                string strCountryCode = Console.ReadLine().ToUpper();

                // Looping through all elements which is not good practice. So, Use dictionary.
                // Country selectedCountry = listCountries.Find(c => c.Code == strCountryCode);
                Country selectedCountry =  listCountries.ContainsKey(strCountryCode) ? listCountries[strCountryCode] : null;
                if (selectedCountry != null)
                {
                    Console.WriteLine($"Country: {selectedCountry.Name}, Capital: {selectedCountry.Capital}");
                }
                else
                {
                    Console.WriteLine("Country code not found.");
                }
                
                do
                {
                    Console.WriteLine("Do you want to continue Y-N ?");
                    strUserChoice = Console.ReadLine().ToUpper();
                } while (strUserChoice != "N" && strUserChoice != "Y");
            }while (strUserChoice == "Y");
        }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
    }
}
