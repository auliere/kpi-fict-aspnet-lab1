using Lab1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Services
{
    public interface IContractData
    {
        IEnumerable<Contract> GetAll();
        Contract Get(int id);
        Contract Add(Contract newContract);
        void Commit();
    }

    public class SqlContractData : IContractData
    {
        private Lab1DbContext _context;

        public SqlContractData(Lab1DbContext context)
        {
            _context = context;
        }

        public Contract Add(Contract newContract)
        {
            _context.Add(newContract);
            return newContract;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Contract Get(int id)
        {
            return _context.Contracts.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Contract> GetAll()
        {
            return _context.Contracts
                    .Include(c => c.Shop)
                    .Include(c => c.ContractItems)
                    .Include(c => c.Company);
        }
    }
}
