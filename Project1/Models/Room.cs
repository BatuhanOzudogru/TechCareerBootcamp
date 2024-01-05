using System.Text.Json.Serialization;

namespace Project1.Models
{
    public class Room:BaseModel
    {
        public string Name { get; set; }

        //manyToMany client
        [JsonIgnore]
        public List<Client> Clients { get; set; } = new List<Client>();
    }
}
