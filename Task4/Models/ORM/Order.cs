namespace Task4.Models.ORM
{
    public class Order : BaseModel
    {
        public int OrderNumber { get; set; }
        public int TotalPrice { get; set; }

        public int WebUserId { get; set; }
        public List<WebUser> WebUser { get; set; }
    }
}
