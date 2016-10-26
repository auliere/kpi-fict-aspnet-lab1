using Lab1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Services
{
    public interface IShopData
    {
        IEnumerable<Shop> GetAll();
        Shop Get(int id);
        Shop Add(Shop newShop);
        void Commit();
    }

    public class SqlShopData : IShopData
    {
        private Lab1DbContext _context;

        public SqlShopData(Lab1DbContext context)
        {
            _context = context;
        }

        public Shop Add(Shop newShop)
        {
            _context.Add(newShop);
            return newShop;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Shop Get(int id)
        {
            return _context.Shops
                    .Include(s => s.Contracts)
                    .FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Shop> GetAll()
        {
            return _context.Shops
                    .Include(s => s.Contracts);
        }
    }

    public class InMemoryShopData : IShopData
    {
        private static List<Shop> _shops;

        public InMemoryShopData()
        {
            _shops = new List<Shop>()
            {
                new Shop { Id = 1, Name = "Silpo", Address = "Road 1" },
                new Shop { Id = 2, Name = "Forra", Address = "Road 2" },
                new Shop { Id = 3, Name = "Fozzy", Address = "Road 3" },
            };
        }

        public Shop Add(Shop newShop)
        {
            _shops.Add(newShop);
            return newShop;
        }

        public void Commit()
        {
            // no op
        }

        public Shop Get(int id)
        {
            return _shops.FirstOrDefault(s => id == s.Id);
        }

        public IEnumerable<Shop> GetAll()
        {
            return _shops;
        }
    }
}
