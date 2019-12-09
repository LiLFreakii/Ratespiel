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
        int Create(User user);
        void Delete(int id);
        void Update(User user);
        int Count();
        int MaxID();
    }
}
