using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessLayer;
using EntityLayer;

namespace BussinessLayer
{
    public class BussinessKlienti
    {
        public static List<Klienti> GetAllKlientat()
        {
            return AccessKlienti.GetAll();
        }

        public static Klienti GetKlientById(int id)
        {
            return AccessKlienti.GetById(id);
        }

        public static void InsertKlient(Klienti klienti)
        {
            AccessKlienti.Insert(klienti);
        }

        public static void DeleteKlient(int id)
        {
            AccessKlienti.Delete(id);
        }
    }
}
