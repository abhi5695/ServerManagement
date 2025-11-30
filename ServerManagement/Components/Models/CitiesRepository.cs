namespace ServerManagement.Components.Models
{
    public class CitiesRepository
    {
        private static List<string> cities = new List<string>()
        {
            "Chennai",
            "Bangalore",
            "Mumbai",
            "Delhi",
            "Kochi"
        };
        public static List<string> GetCities() => cities;
    }
}
