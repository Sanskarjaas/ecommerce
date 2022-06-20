using ecommerce_app.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Repositories
{
    public class AdminRepository
    {
        private readonly DbContext _context;
        public AdminRepository(DbContext context)
        {
            _context = context;
        }

        public Admin Get(int Id)
        {
           return _context.Set<Admin>().Find(Id);
        }

        public IEnumerable<Admin> GetAll()
        {
            return _context.Set<Admin>().ToList();
        }
    }
}
