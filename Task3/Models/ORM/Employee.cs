using System.ComponentModel.DataAnnotations;

namespace Task3.Models.ORM
{
    public class Employee : BaseModel
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }   
        public string Address { get; set; }
        public string City { get; set; }
       
       

       
    }
}
