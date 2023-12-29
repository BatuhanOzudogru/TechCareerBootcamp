namespace Task4.Models.ORM
{
    public class Order : BaseModel
    {
        public int OrderNumber { get; set; }
        public int TotalPrice { get; set; }

        public List<WebUser> WebUsers { get; set; }
    }
}
