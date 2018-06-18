using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace AccessLayer
{
    public class AccessFusha
    {
        public static List<Fusha> GetAll()
        {
            List<Fusha> fushat = null;

            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetAllFushat", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            fushat = new List<Fusha>();

                            while (sqlr.Read())
                            {
                                Fusha fusha = new Fusha();
                                
                                fusha.FushaID = int.Parse(sqlr["FushaID"].ToString());
                                fusha.FushaEMbuluar = bool.Parse(sqlr["FushaEMbuluar"].ToString());
                                fusha.BariArtificial = bool.Parse(sqlr["BariArtificial"].ToString());
                                fusha.Gjatesia = sqlr["Gjatesia"].ToString();
                                fusha.Gjeresia = sqlr["Gjeresia"].ToString();
                                fusha.CmimiFushes = double.Parse(sqlr["CmimiIFushes"].ToString());
                                fusha.IsActive = bool.Parse(sqlr["IsActive"].ToString());
                                fushat.Add(fusha);
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
                fushat = null;
                throw;
            }
            return fushat;
        }

        public static Fusha GetById(int id)
        {
            Fusha fusha = null;
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetFushaById", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FushaId", id);
                    con.Open();

                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            fusha = new Fusha();

                            while (sqlr.Read())
                            {
                                fusha.FushaID = int.Parse(sqlr["FushaID"].ToString());
                                fusha.FushaEMbuluar = bool.Parse(sqlr["FushaEMbuluar"].ToString());
                                fusha.BariArtificial = bool.Parse(sqlr["BariArtificial"].ToString());
                                fusha.Gjatesia = sqlr["Gjatesia"].ToString();
                                fusha.Gjeresia = sqlr["Gjeresia"].ToString();
                                fusha.CmimiFushes = double.Parse(sqlr["CmimiIFushes"].ToString());
                                fusha.IsActive = bool.Parse(sqlr["IsActive"].ToString());
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
            return fusha;
        }

        public static void Insert(Fusha fusha)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ShtoFusha", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@FushaEMbuluar", fusha.FushaEMbuluar);
                    cmd.Parameters.AddWithValue("@BariArtificial", fusha.BariArtificial);
                    cmd.Parameters.AddWithValue("@Gjatesia", fusha.Gjatesia);
                    cmd.Parameters.AddWithValue("@Gjeresia", fusha.Gjeresia);
                    cmd.Parameters.AddWithValue("@CmimiIFushes", fusha.CmimiFushes);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Edit(int id, Fusha fusha)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EditFusha", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@FushaID", id);
                    cmd.Parameters.AddWithValue("@FushaEMbuluar", fusha.FushaEMbuluar);
                    cmd.Parameters.AddWithValue("@BariArtificial", fusha.BariArtificial);
                    cmd.Parameters.AddWithValue("@Gjatesia", fusha.Gjatesia);
                    cmd.Parameters.AddWithValue("@Gjeresia", fusha.Gjeresia);
                    cmd.Parameters.AddWithValue("@CmimiIFushes", fusha.CmimiFushes);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Delete(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_FshijFushe", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@FushaID", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
