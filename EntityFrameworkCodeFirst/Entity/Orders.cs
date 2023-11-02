using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCodeFirst.Entity
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
    
        public int OrderNumber { get; set; }    
        public DateTime orderDate { get; set; }
        public int CustomerId { get; set; }
        public Customers customers { get; set; }
    }
}
