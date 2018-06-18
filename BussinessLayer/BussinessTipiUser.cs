using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessLayer;
using EntityLayer;

namespace BussinessLayer
{
    public class BussinessTipiUser
    {
        public static List<TipiUser> GetAllTipiUser()
        {
            return AccessTipiUser.GetAll();
        }

        public static TipiUser GetTipiUserById(int id)
        {
            return AccessTipiUser.GetTipiUserById(id);
        }
    }
}
