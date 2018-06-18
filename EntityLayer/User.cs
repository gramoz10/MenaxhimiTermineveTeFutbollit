using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User
    {
        public int UserID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public TipiUser TipiUser { get; set; }
        public string NrKontaktues { get; set; }
        public DateTime DataLindjes { get; set; }
        public string Adresa { get; set; }
        public bool IsActive { get; set; }

        public string FullName
        {
            get { return Emri + " " + Mbiemri; }
        }
    }
}
