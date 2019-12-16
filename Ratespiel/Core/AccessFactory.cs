using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    public class AccessFactory : IAccessFactory
    {
        static Dictionary<string, IAccess> dict = new Dictionary<string, IAccess>();
        static bool bInit = false;

        public AccessFactory()
        {
            try
            {
                IAccess iAccess = null;
                if(!bInit)
                {
                    // prüft, ob Key bereits exestiert
                    if (!dict.ContainsKey("dataaccessuser"))
                    {
                        iAccess = new DataAccessUser();
                        dict.Add("dataaccessuser", iAccess);
                    }

                    if (!dict.ContainsKey("dataaccessspiel"))
                    {
                        iAccess = new DataAccessSpiel();
                        dict.Add("dataaccessspiel", iAccess);
                    }

                    if (!dict.ContainsKey("dataaccesskategorie"))
                    {
                        iAccess = new DataAccessKategorie();
                        dict.Add("dataaccesskategorie", iAccess);
                    }

                    if (!dict.ContainsKey("dataaccessfragenantworten"))
                    {
                        iAccess = new DataAccessFragenAntworten();
                        dict.Add("dataaccessfragenantworten", iAccess);
                    }
                }

            } catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Fehler!" + ex);
            }
        }

        public IAccess GetInstance(string classname)
        {
            return dict[classname.ToLower()];
        }
    }
}
