﻿using System.ComponentModel.DataAnnotations;

namespace Task4.Models.ORM
{
    public class WebUser:BaseModel
    {
        public string EMail { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }

       
        public List<Order> Orders { get; set; }
 
    }
}
