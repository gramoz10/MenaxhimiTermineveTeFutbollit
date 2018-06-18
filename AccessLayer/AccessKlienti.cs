using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace AccessLayer
{
    public class AccessKlienti
    {
        public static List<Klienti> GetAll()
        {
            List<Klienti> klientat = null;

            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetAllKlientat", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            klientat = new List<Klienti>();

                            while (sqlr.Read())
                            {
                                Klienti klient = new Klienti();
                                klient.KlientiID = int.Parse(sqlr["KlientiID"].ToString());
                                klient.Emri = sqlr["Emri"].ToString();
                                klient.Mbiemri = sqlr["Mbiemri"].ToString();
                                klient.NrKontaktues = sqlr["NrKontaktues"].ToString();
                                klient.isActive = bool.Parse(sqlr["IsActive"].ToString());
                                klientat.Add(klient);
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
                klientat = null;
                throw;
            }
            return klientat;
        }

        public static Klienti GetById(int id)
        {
            Klienti klient = null;
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetKlientById", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@KlientId", id);
                    con.Open();

                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            klient = new Klienti();

                            while (sqlr.Read())
                            {
                                klient.KlientiID = int.Parse(sqlr["KlientiID"].ToString());
                                klient.Emri = sqlr["Emri"].ToString();
                                klient.Mbiemri = sqlr["Mbiemri"].ToString();
                                klient.NrKontaktues = sqlr["NrKontaktues"].ToString();
                                klient.isActive = bool.Parse(sqlr["IsActive"].ToString());
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
            return klient;
        }

        public static void Insert(Klienti klienti)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ShtoKlient", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Emri", klienti.Emri);
                    cmd.Parameters.AddWithValue("@Mbiemri", klienti.Mbiemri);
                    cmd.Parameters.AddWithValue("@NrKontaktues", klienti.NrKontaktues);
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
                    SqlCommand cmd = new SqlCommand("sp_FshijKlient", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@KlientiID", id);
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
