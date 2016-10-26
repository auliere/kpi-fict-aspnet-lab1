using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Entities
{
    public class Contract
    {
        [Display(Name = "Number")]
        public int Id { get; set; }
        public DateTime EndDate { get; set; }
        public int ShopID { get; set; }
        public int CompanyID { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<ContractItem> ContractItems { get; set; }
    }
}
