using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentItAPI.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int BusinessId { get; set; }
        public int StockCount { get; set; }
        public int AmountAvailable { get; set; }
    }
}
