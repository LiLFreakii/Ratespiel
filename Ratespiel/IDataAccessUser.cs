using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    public interface IDataAccessUser
    {
        List<User> ReadALL();
        int Create();
        void Delete(int id);
        void Update();
        int Count();
        int MaxID();
    }
}
