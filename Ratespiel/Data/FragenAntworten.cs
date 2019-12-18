using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    public class FragenAntworten
    {
        public int Id { get; set; }
        public string Frage { get; set; }
        public string Antwort1 { get; set; }
        public string Antwort2 { get; set; }
        public string Antwort3 { get; set; }
        public string Antwort4 { get; set; }
        public int RichtigeAntwort { get; set; }
        public int Schwierigkeit { get; set; }
        public int KategorieId { get; set; }
    }
}
