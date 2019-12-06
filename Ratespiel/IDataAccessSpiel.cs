using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    public interface IDataAccessSpiel
    {
        List<Spiel> ReadAll();
        int Create();
        void Delete(int id);
        void Update();
        int Count();
        int MaxID();
    }
}
