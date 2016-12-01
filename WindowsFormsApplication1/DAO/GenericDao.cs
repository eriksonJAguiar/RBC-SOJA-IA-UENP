using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SojaApp.DAO
{
    interface GenericDao<T>
    {
        bool create(T t);
        bool delete(T t);
        T search(T t);
        List<T> getAll();
    }
}
