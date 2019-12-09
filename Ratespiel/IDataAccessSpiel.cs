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
        int Create(Spiel spiel);
        void Delete(int id);
        void Update(Spiel spiel);
        int Count();
        int MaxID();
    }
}
