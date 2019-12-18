using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
   public class Bestenliste
    {
        public int Id { get; set; }
        public int Spielnr { get; set; }
        public string Username { get; set; }
        public int Score { get; set; }
        public DateTime Datum { get; set; }
    }
}
