using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample.Repository
{
    public interface IGenericRepository<T> where T:class
    {
        List<T> GetAll();
        int Insert(T t);
    }
}
