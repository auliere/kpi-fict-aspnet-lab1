using System.Collections.Generic;

namespace Lab1.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ownership { get; set; }
        public string Address { get; set; }
        public int Workers { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
