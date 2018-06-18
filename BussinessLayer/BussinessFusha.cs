using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessLayer;
using EntityLayer;

namespace BussinessLayer
{
    public class BussinessFusha
    {
        public static List<Fusha> GetAllFushat()
        {
            if (AccessFusha.GetAll() != null)
            {
                return AccessFusha.GetAll();
            }
            return null;
        }

        public static Fusha GetFushaById(int id)
        {
            return AccessFusha.GetById(id);
        }

        public static void InsertFusha(Fusha fusha)
        {
            AccessFusha.Insert(fusha);
        }

        public static void EditFusha(int id, Fusha fusha)
        {
            AccessFusha.Edit(id, fusha);
        }

        public static void DeleteFusha(int id)
        {
            AccessFusha.Delete(id);
        }
    }
}
