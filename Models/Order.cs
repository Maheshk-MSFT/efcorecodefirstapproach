using System;
using System.Collections.Generic;

namespace efcorecodefirstapproach.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFullfilled { get; set; }
        public int CustomerId{ get; set; }
        public Customer Customer { get; set; }

        public string Email { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }

}
