using Lab1.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.Services
{
    public interface IContractItemData
    {
        IEnumerable<ContractItem> GetAll();
        ContractItem Get(int id);
        ContractItem Add(ContractItem newContractItem);
        void Commit();
    }

    public class SqlContractItemData : IContractItemData
    {
        private Lab1DbContext _context;

        public SqlContractItemData(Lab1DbContext context)
        {
            _context = context;
        }

        public ContractItem Add(ContractItem newShop)
        {
            _context.Add(newShop);
            return newShop;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public ContractItem Get(int id)
        {
            return _context.ContractItems.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<ContractItem> GetAll()
        {
            return _context.ContractItems;
        }
    }

    public class InMemoryContractItemData : IContractItemData
    {
        private static List<ContractItem> _contractItems;

        public InMemoryContractItemData()
        {
            _contractItems = new List<ContractItem>()
            {
                new ContractItem { Id = 1, Name = "Fruits", Price = 10d, Amount = 1 },
                new ContractItem { Id = 2, Name = "Tomatoes", Price = 5d, Amount = 10},
                new ContractItem { Id = 3, Name = "Broccoli", Price = 5.5d, Amount = 4 }
            };
        }

        public ContractItem Add(ContractItem newContractItem)
        {
            _contractItems.Add(newContractItem);
            return newContractItem;
        }

        public void Commit()
        {
            // no op
        }

        public ContractItem Get(int id)
        {
            return _contractItems.FirstOrDefault(s => id == s.Id);            
        }

        public IEnumerable<ContractItem> GetAll()
        {
            return _contractItems;
        }
    }
}
