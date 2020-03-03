using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Models
{
   public class Order
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; private set; }
        public int CustomerId { get; set; }
        public string Id { get; private set; }
        public OrderStatuses Status { get; set; }

        public Order(string name, string description, DateTime created, int customerId, string id)
        {
            Name = name;
            Description = description;
            Created = created;
            CustomerId = customerId;
            Id = id;
            Status = OrderStatuses.Created;
        }

       
    }

   public enum OrderStatuses
   {
     Created = 2,
     Processing = 4,
     Completed = 8,
     Cancelled = 16,
     Close = 32

   }
}
