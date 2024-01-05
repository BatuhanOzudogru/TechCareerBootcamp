using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Project1.Models
{
    public class Client:BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address {  get; set; }
        public string EMail { get; set; }

        public int? CompanyId { get; set; }

        //manyToOne company
        
        public Company Company { get; set; }




        //manyToMany room
        public int? RoomId { get; set; }
        public List<Room> Rooms { get; set;}
        
    }
}
