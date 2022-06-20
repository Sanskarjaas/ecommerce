using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Services
{
    public interface ICrudService<T>
    {
        public T Get(int Id);

        public IEnumerable<T> GetAll();

        public T Create();

        public T Update();

        public T Delete();
    }
}
