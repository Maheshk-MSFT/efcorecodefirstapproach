using System.Collections.Generic;

namespace efcorecodefirstapproach.Models
{
    public class Customer
    {
#nullable enable 
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string? Adress { get; set; }
        public string? Phone { get; set; }
#nullable disable
        public ICollection<Order> Orders { get; set; }
    }
}
