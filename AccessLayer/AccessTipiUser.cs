using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace AccessLayer
{
    public class AccessTipiUser
    {
        public static List<TipiUser> GetAll()
        {
            List<TipiUser> tipet = null;

            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetAllTipiUser", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            tipet = new List<TipiUser>();

                            while (sqlr.Read())
                            {
                                TipiUser tipi = new TipiUser();
                                tipi.TipiID = int.Parse(sqlr["TipiID"].ToString());
                                tipi.Pershkrimi = sqlr["Pershkrimi"].ToString();
                                tipet.Add(tipi);
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
                tipet = null;
            }
            return tipet;
        }

        public static TipiUser GetTipiUserById(int id)
        {
            TipiUser tipi = null;
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetTipiUserById", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipiID", id);
                    con.Open();

                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            tipi = new TipiUser();

                            while (sqlr.Read())
                            {
                                tipi.TipiID = int.Parse(sqlr["TipiID"].ToString());
                                tipi.Pershkrimi = sqlr["Pershkrimi"].ToString();
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return tipi;
        }
    }
}
