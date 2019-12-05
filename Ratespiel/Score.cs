using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    public class Score
    {
        public int Id { get; set; }
        public int Points { get; set; }
        public int SpielId { get; set; }
        public DateTime Datum { get; set; }
    }
}
