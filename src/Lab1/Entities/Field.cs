using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Entities
{
    public class Field
    {
        public int Id { get; set; }
        public string Culture { get; set; }
        public double Area { get; set; }

        public int CompanyId { get; set; }
    }
}
