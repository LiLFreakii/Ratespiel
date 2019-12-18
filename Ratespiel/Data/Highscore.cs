using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    public class Highscore
    {
        public int Id { get; set; }
        public int Spielnr { get; set; }
        public int Score { get; set; }
        public int UserId { get; set; }
        public DateTime Datum { get; set; }
    }
}
