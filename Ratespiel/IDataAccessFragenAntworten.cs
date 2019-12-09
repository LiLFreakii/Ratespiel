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
        int Create(FragenAntworten fragenAntworten);
        void Delete(int id);
        void Update(FragenAntworten fragenAntworten);
        int Count();
        int MaxID();
    }
}
