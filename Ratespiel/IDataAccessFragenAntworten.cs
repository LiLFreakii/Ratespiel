using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    public interface IDataAccessFragenAntworten
    {
        List<FragenAntworten> ReadALL();
        int Create();
        void Delete(int id);
        void Update();
        int Count();
        int MaxID();
    }
}
