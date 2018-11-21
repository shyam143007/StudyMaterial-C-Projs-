using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Repository : IRepository
    {
        public T GetRepository<T>() where T:new ()
        {
            return new T();
        }
    }
}
