using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    // generisches Interface
    public interface IDataAccess<T> : IAccess
    {
        List<T> ReadAll();
        int Create(T t);
        void Delete(int id);
        void Update(T t);
        int Count();
        int MaxId();

    }
}
