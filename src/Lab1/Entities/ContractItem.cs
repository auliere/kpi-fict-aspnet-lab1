using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Entities
{
    public class ContractItem
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
    }
}
