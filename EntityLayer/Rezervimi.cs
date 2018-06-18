using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Rezervimi
    {
        public int RezervimiID { get; set; }
        public User User { get; set; }
        public Klienti Klienti { get; set; }
        public Fusha Fusha { get; set; }
        public DateTime DataERezervimit { get; set; }
        public DateTime FillimiRezervimit { get; set; }
        public DateTime MbarimiRezervimit { get; set; }
        public double Pagesa { get; set; }
        public bool IsActive { get; set; }
    }
}
