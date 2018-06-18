using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AccessLayer
{
    class Connection
    {
        public static string ConnectionString
        {
            get
            {
                return "Data Source=.;Initial Catalog=ProjektTI1_MenaxhimiITermineveFutbollistike;Integrated Security=True";
            }
        }
    }
}
