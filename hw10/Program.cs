class City
{
    public string cityName;
    public string regionName;
    public string countryName;
    public int cityPopulation;
    public int cityIndex;
    public int cityPhoneCod;
}

class Country
{
    public string countyName;
    public string capitalName;
    public string continent;
    public int coutryPopulation;
    public int phoneCod;
    public List<CityUkr> cityName;
}

enum CityUkr 
{
    Kyiv,
    Dnipro,
    Kharkiv,
    Lviv,
    Odessa,
    Donetsk,
    Zaporozhye,
    Kamyanske,
    Lugansk,
    Bakhmut
}
class Program
{
   public static Country CreateCountry()
    {
        Country country = new Country();
        country.countyName = "Ukraine";
        country.capitalName = "Kyiv";
        country.continent = "Eurasia";
        country.coutryPopulation = 41_167_336;
        country.phoneCod = 380;
        country.cityName = new List<CityUkr>();
        foreach(CityUkr cityUkr in Enum.GetValues(typeof(CityUkr)))
        {
            country.cityName.Add(cityUkr);
        }
        return country;
        
    }
    public static City CreateCity()
    {
        City city = new City();
        city.cityName = "Dnipro";
        city.regionName = "Dnipropetrovskya";
        city.countryName = "Ukraine";
        city.cityPopulation = 984_423;
        city.cityIndex = 49000;
        city.cityPhoneCod = 380562;
        return city;
    }
    public static void PrintCity(City city)
    {
        Console.WriteLine($"Name city:{city.cityName}");
        Console.WriteLine($"Region name:{city.regionName}");
        Console.WriteLine($"Name of coutry:{city.countryName}");
        Console.WriteLine($"City population:{city.cityPopulation}");
        Console.WriteLine($"City index:{city.cityIndex}");
        Console.WriteLine($"City post cod:{city.cityPhoneCod}");
    }
    public static void PrintCoutry(Country country)
    {
        Console.WriteLine($"Name of country: {country.countyName}");
        Console.WriteLine($"Capital of {country.countyName}: {country.capitalName}");
        Console.WriteLine($"Continent: {country.continent}");
        Console.WriteLine($"Populatinon of {country.countyName}: {country.coutryPopulation}");
        Console.WriteLine($"Phone cod of {country.countyName}: {country.phoneCod}");
        Console.WriteLine($"Name of city in {country.countyName}:");
        foreach (CityUkr cityUkr in country.cityName) 
        {
            Console.WriteLine(cityUkr);
        }
    }
    static void Main(string[] args )
    {
        var city = CreateCity();
        PrintCity(city);
        Console.WriteLine();
        var country = CreateCountry();
        PrintCoutry(country);
    }
}