namespace Project1.Models
{
    public class ClientRequest:BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }

        public int CompanyId { get; set; }
        public int RoomId { get; set; }
    }
}
