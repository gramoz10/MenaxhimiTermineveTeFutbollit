using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Klienti
    {
        public int KlientiID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string NrKontaktues { get; set; }
        public bool isActive { get; set; }

        public string FullName
        {
            get { return Emri + " " + Mbiemri; }
        }
    }
}
