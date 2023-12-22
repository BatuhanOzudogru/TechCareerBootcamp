using Microsoft.AspNetCore.Mvc;

namespace TechCareerBootcamp.Controllers
{
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public string[] Get()
        {
            string[] countries = new string[]{
            "Turkey",
            "Germany",
            "France",
            "Japan",
            "Brazil",
            "Canada",
            "Australia",
            "India",
            "Mexico",
            "South Africa",
            "Italy",
            "Spain",
            "Russia",
            "China",
            "United States",
            "United Kingdom",
            "Argentina",
            "Sweden",
            "Norway",
            "South Korea"
             };

            return countries;
        }

        [HttpGet("{id}")]
        public string Get2(int id)
        {
            string[] countries = new string[]{
            "Turkey",
            "Germany",
            "France",
            "Japan",
            "Brazil",
            "Canada",
            "Australia",
            "India",
            "Mexico",
            "South Africa",
            "Italy",
            "Spain",
            "Russia",
            "China",
            "United States",
            "United Kingdom",
            "Argentina",
            "Sweden",
            "Norway",
            "South Korea"
             };
            string result = "";

            if (id < 0 || id >= countries.Length)
            {
                return "Invalid ID";
            }
            else
            {      
                for (int i = 0; i < id; i++)
                {
                   

                    
                    
                        result += countries[i] + "\n";
                    
                }

            }

            return result;



        }
    }
}
