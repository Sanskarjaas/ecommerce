using ecommerce_app.Models;
using ecommerce_app.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{
    public class AdminServiceImpl: AdminService
    {
        private readonly AdminRepository _adminRepository;

        public AdminServiceImpl(AdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        IEnumerable<Admin> CrudService<Admin>.GetAll()
        {
            throw new NotImplementedException();
        }

        Admin CrudService<Admin>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        Admin CrudService<Admin>.Create(Admin CreateDto)
        {
            throw new NotImplementedException();
        }

        Admin CrudService<Admin>.Update(int Id, Admin UpdateDto)
        {
            throw new NotImplementedException();
        }

        Admin CrudService<Admin>.Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
