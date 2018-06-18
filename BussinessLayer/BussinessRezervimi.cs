using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessLayer;
using EntityLayer;

namespace BussinessLayer
{
    public class BussinessRezervimi
    {
        public static List<Rezervimi> GetAllRezervimet()
        {
            if (AccessRezervimi.GetAll() != null)
            {
                return AccessRezervimi.GetAll();
            }
            else
                return null;
        }

        public static Rezervimi GetAllRezervimetByID(int rezervimiID)
        {
            if (AccessRezervimi.GetByID(rezervimiID) != null)
            {
                return AccessRezervimi.GetByID(rezervimiID);
            }
            else
                return null;
        }

        public static void InsertRezervim(Rezervimi rezervimi)
        {
            AccessRezervimi.Insert(rezervimi);
        }

        public static void EditRezervim(Rezervimi rezervim)
        {
            AccessRezervimi.Edit(rezervim);
        }

        public static bool CheckReservation(Rezervimi rezervimi)
        {
            return AccessRezervimi.CheckReservation(rezervimi);
        }

        public static void DeleteRezervim(int id)
        {
            AccessRezervimi.DeleteRezervim(id);
        }
    }
}
