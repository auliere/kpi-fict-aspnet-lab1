using System.Collections.Generic;

namespace Lab1.Entities
{    
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
