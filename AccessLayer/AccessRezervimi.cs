using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace AccessLayer
{
    public class AccessRezervimi
    {
        public static List<Rezervimi> GetAll()
        {
            List<Rezervimi> rezervimet = null;

            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetAllRezervimet", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            rezervimet = new List<Rezervimi>();

                            while (sqlr.Read())
                            {
                                Rezervimi rezervim = new Rezervimi();
                                rezervim.RezervimiID = int.Parse(sqlr["RezervimiID"].ToString());
                                rezervim.User = new User();
                                rezervim.User.UserID = int.Parse(sqlr["UserID"].ToString());
                                rezervim.User.Emri = sqlr["User_Emri"].ToString();
                                rezervim.User.Mbiemri = sqlr["User_Mbiemri"].ToString();
                                rezervim.User.Email = sqlr["Email"].ToString();
                                rezervim.User.Password = sqlr["Password"].ToString();
                                rezervim.User.NrKontaktues = sqlr["User_NrKontaktues"].ToString();
                                rezervim.User.DataLindjes = Convert.ToDateTime(sqlr["DataELindjes"].ToString());
                                rezervim.User.Adresa = sqlr["Adresa"].ToString();
                                rezervim.User.TipiUser = new TipiUser();
                                rezervim.User.TipiUser.TipiID = int.Parse(sqlr["TipiID"].ToString());
                                rezervim.User.TipiUser.Pershkrimi = sqlr["Pershkrimi"].ToString();
                                rezervim.Fusha = new Fusha();
                                rezervim.Fusha.FushaID = int.Parse(sqlr["FushaID"].ToString());
                                rezervim.Fusha.FushaEMbuluar = (sqlr["FushaEMbuluar"].ToString() == "1" ? true : false);
                                rezervim.Fusha.BariArtificial = (sqlr["BariArtificial"].ToString() == "1" ? true : false);
                                rezervim.Fusha.Gjatesia = sqlr["Gjatesia"].ToString();
                                rezervim.Fusha.Gjeresia = sqlr["Gjeresia"].ToString();
                                rezervim.Fusha.CmimiFushes = double.Parse(sqlr["CmimiIFushes"].ToString());
                                rezervim.Klienti = new Klienti();
                                rezervim.Klienti.KlientiID = int.Parse(sqlr["KlientiID"].ToString());
                                rezervim.Klienti.Emri = sqlr["Klient_Emri"].ToString();
                                rezervim.Klienti.Mbiemri = sqlr["Klient_Mbiemri"].ToString();
                                rezervim.Klienti.NrKontaktues = sqlr["Klient_NrKontaktues"].ToString();
                                rezervim.DataERezervimit = Convert.ToDateTime(sqlr["DataERezervimit"].ToString());
                                rezervim.FillimiRezervimit = Convert.ToDateTime(sqlr["FillimiRezervimit"].ToString());
                                rezervim.MbarimiRezervimit = Convert.ToDateTime(sqlr["MbarimiRezervimit"].ToString());
                                rezervim.Pagesa = double.Parse(sqlr["Pagesa"].ToString());
                                rezervim.IsActive = bool.Parse(sqlr["IsActive"].ToString());

                                rezervimet.Add(rezervim);
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
                rezervimet = null;
                throw;
            }
            return rezervimet;
        }

        public static Rezervimi GetByID(int rezervimiID)
        {
            Rezervimi rezervim = null;

            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetAllRezervimetByID", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RezervimiID", rezervimiID);
                    con.Open();

                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            rezervim = new Rezervimi();

                            while (sqlr.Read())
                            {
                                rezervim.RezervimiID = int.Parse(sqlr["RezervimiID"].ToString());
                                rezervim.User = new User();
                                rezervim.User.UserID = int.Parse(sqlr["UserID"].ToString());
                                rezervim.User.Emri = sqlr["User_Emri"].ToString();
                                rezervim.User.Mbiemri = sqlr["User_Mbiemri"].ToString();
                                rezervim.User.Email = sqlr["Email"].ToString();
                                rezervim.User.Password = sqlr["Password"].ToString();
                                rezervim.User.NrKontaktues = sqlr["User_NrKontaktues"].ToString();
                                rezervim.User.DataLindjes = Convert.ToDateTime(sqlr["DataELindjes"].ToString());
                                rezervim.User.Adresa = sqlr["Adresa"].ToString();
                                rezervim.User.TipiUser = new TipiUser();
                                rezervim.User.TipiUser.TipiID = int.Parse(sqlr["TipiID"].ToString());
                                rezervim.User.TipiUser.Pershkrimi = sqlr["Pershkrimi"].ToString();
                                rezervim.Fusha = new Fusha();
                                rezervim.Fusha.FushaID = int.Parse(sqlr["FushaID"].ToString());
                                rezervim.Fusha.FushaEMbuluar = (sqlr["FushaEMbuluar"].ToString() == "1" ? true : false);
                                rezervim.Fusha.BariArtificial = (sqlr["BariArtificial"].ToString() == "1" ? true : false);
                                rezervim.Fusha.Gjatesia = sqlr["Gjatesia"].ToString();
                                rezervim.Fusha.Gjeresia = sqlr["Gjeresia"].ToString();
                                rezervim.Fusha.CmimiFushes = double.Parse(sqlr["CmimiIFushes"].ToString());
                                rezervim.Klienti = new Klienti();
                                rezervim.Klienti.KlientiID = int.Parse(sqlr["KlientiID"].ToString());
                                rezervim.Klienti.Emri = sqlr["Klient_Emri"].ToString();
                                rezervim.Klienti.Mbiemri = sqlr["Klient_Mbiemri"].ToString();
                                rezervim.Klienti.NrKontaktues = sqlr["Klient_NrKontaktues"].ToString();
                                rezervim.DataERezervimit = Convert.ToDateTime(sqlr["DataERezervimit"].ToString());
                                rezervim.FillimiRezervimit = Convert.ToDateTime(sqlr["FillimiRezervimit"].ToString());
                                rezervim.MbarimiRezervimit = Convert.ToDateTime(sqlr["MbarimiRezervimit"].ToString());
                                rezervim.Pagesa = double.Parse(sqlr["Pagesa"].ToString());
                                rezervim.IsActive = bool.Parse(sqlr["IsActive"].ToString());
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
            return rezervim;
        }

        public static void Insert(Rezervimi rezervim)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ShtoRezervim", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@UserID", rezervim.User.UserID);
                    cmd.Parameters.AddWithValue("@FushaID", rezervim.Fusha.FushaID);
                    cmd.Parameters.AddWithValue("@KlientiID", rezervim.Klienti.KlientiID);
                    cmd.Parameters.AddWithValue("@DataRezervimit", rezervim.DataERezervimit);
                    cmd.Parameters.AddWithValue("@FillimiRezervimit", rezervim.FillimiRezervimit);
                    cmd.Parameters.AddWithValue("@MbarimiRezervimit", rezervim.MbarimiRezervimit);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Edit(Rezervimi rezervim)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ShtyejRezervimin", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@RezervimiID", rezervim.RezervimiID);
                    cmd.Parameters.AddWithValue("@MbarimiRezervimit", rezervim.MbarimiRezervimit);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool CheckReservation(Rezervimi rezervimi)
        {
            bool message = false;
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("ufn_KontrolloDatat",con);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "select dbo.[ufn_KontrolloDatat](@FillimiRezervimit,@MbarimiRezervimit,@FushaID)";
                    cmd.Parameters.AddWithValue("@FillimiRezervimit",rezervimi.FillimiRezervimit);
                    cmd.Parameters.AddWithValue("@MbarimiRezervimit",rezervimi.MbarimiRezervimit);
                    cmd.Parameters.AddWithValue("@FushaID",rezervimi.Fusha.FushaID);

                    con.Open();
                    message = (bool)cmd.ExecuteScalar();
                    con.Close();
                }
                return message;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeleteRezervim(int rezervimiID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_FshijRezervim", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@RezervimiID", rezervimiID);
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
