using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{
    interface CrudService<T>
    {
        public IEnumerable<T> GetAll();
        public T Get(int Id);
        public T Create(T CreateDto);
        public T Update(int Id,T UpdateDto);
        public T Delete(int Id);
    }
}
