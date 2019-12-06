using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratespiel
{
    public class User
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public string Passwort { get; set; } 
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Mail { get; set; } 
        public int ScoreId { get; set; }
    }
}
