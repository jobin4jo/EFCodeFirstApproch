using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCodeFirst.Entity
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; } 
        public string Firstname { get; set; }   
        public string Lastname { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; } 
    }
}
