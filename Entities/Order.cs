using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentItAPI.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string FirstNameId { get; set; }
        public string LastNameId { get; set; }
        public int EmailId { get; set; }

        public int Amount { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
