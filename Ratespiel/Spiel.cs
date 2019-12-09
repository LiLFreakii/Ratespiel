using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    public class Spiel
    {
        public int Id { get; set; }
        public int SpielNr { get; set; } 
        public int UserId { get; set; }
        public int FuAId { get; set; }
        public int Score { get; set; } 
        public DateTime Datum { get; set; }
    }
}
