using Lab1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Services
{
    public interface ICompanyData
    {
        IEnumerable<Company> GetAll();
        Company Get(int id);
        Company Add(Company newContract);
        void Commit();
    }

    public class SqlCompanyData : ICompanyData
    {
        private Lab1DbContext _context;

        public SqlCompanyData(Lab1DbContext context)
        {
            _context = context;
        }

        public Company Add(Company newContract)
        {
            _context.Add(newContract);
            return newContract;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Company Get(int id)
        {
            return _context.Companies.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Company> GetAll()
        {
            return _context.Companies
                    .Include(c => c.Contracts)
                    .Include(c => c.Fields)
                    .Include(c => c.Farms);
        }
    }
}
