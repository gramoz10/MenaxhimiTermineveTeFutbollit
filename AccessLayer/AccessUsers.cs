using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace AccessLayer
{
    public class AccessUsers
    {
        public static List<User> GetAll()
        {
            List<User> users = null;

            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetAllUsers", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();

                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            users = new List<User>();

                            while (sqlr.Read())
                            {
                                User user = new User();
                                user.UserID = int.Parse(sqlr["UserID"].ToString());
                                user.Emri = sqlr["Emri"].ToString();
                                user.Mbiemri = sqlr["Mbiemri"].ToString();
                                user.Email = sqlr["Email"].ToString();
                                user.Password = sqlr["Password"].ToString();
                                user.NrKontaktues = sqlr["NrKontaktues"].ToString();
                                user.DataLindjes = Convert.ToDateTime(sqlr["DataELindjes"].ToString());
                                user.Adresa = sqlr["Adresa"].ToString();
                                user.TipiUser = new TipiUser();
                                user.TipiUser.TipiID = int.Parse(sqlr["TipiID"].ToString());
                                user.TipiUser.Pershkrimi = sqlr["Pershkrimi"].ToString();
                                user.IsActive = bool.Parse(sqlr["IsActive"].ToString());

                                users.Add(user);
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
                users = null;
                throw;
            }
            return users;
        }

        public static User GetById(int id)
        {
            User user = null;
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetUserById", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", id);
                    con.Open();

                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            user = new User();

                            while (sqlr.Read())
                            {
                                user.UserID = int.Parse(sqlr["UserID"].ToString());
                                user.Emri = sqlr["Emri"].ToString();
                                user.Mbiemri = sqlr["Mbiemri"].ToString();
                                user.Email = sqlr["Email"].ToString();
                                user.Password = sqlr["Password"].ToString();
                                user.NrKontaktues = sqlr["NrKontaktues"].ToString();
                                user.DataLindjes = Convert.ToDateTime(sqlr["DataELindjes"].ToString());
                                user.Adresa = sqlr["Adresa"].ToString();
                                user.TipiUser = new TipiUser();
                                user.TipiUser.TipiID = int.Parse(sqlr["TipiID"].ToString());
                                user.TipiUser.Pershkrimi = sqlr["Pershkrimi"].ToString();
                                user.IsActive = bool.Parse(sqlr["IsActive"].ToString());
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
            return user;
        }

        public static void Insert(User user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ShtoUser", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Emri", user.Emri);
                    cmd.Parameters.AddWithValue("@Mbiemri", user.Mbiemri);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Tipi", user.TipiUser.TipiID);
                    cmd.Parameters.AddWithValue("@NrKontaktues", user.NrKontaktues);
                    cmd.Parameters.AddWithValue("@DataELindjes", user.DataLindjes);
                    cmd.Parameters.AddWithValue("@Adresa", user.Adresa);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Edit(int id, User user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EditUser", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@UserID", id);
                    cmd.Parameters.AddWithValue("@Emri", user.Emri);
                    cmd.Parameters.AddWithValue("@Mbiemri", user.Mbiemri);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Tipi", user.TipiUser.TipiID);
                    cmd.Parameters.AddWithValue("@NrKontaktues", user.NrKontaktues);
                    cmd.Parameters.AddWithValue("@DataELindjes", user.DataLindjes);
                    cmd.Parameters.AddWithValue("@Adresa", user.Adresa);

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
                    SqlCommand cmd = new SqlCommand("sp_FshijUser", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@UserID", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static User LogIn(string email, string password)
        {
            User user = null;

            try
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_LogIn", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    con.Open();
                    using (SqlDataReader sqlr = cmd.ExecuteReader())
                    {
                        if (sqlr.HasRows)
                        {
                            while (sqlr.Read())
                            {
                                user = new User();

                                user.UserID = int.Parse(sqlr["UserID"].ToString());
                                user.Emri = sqlr["Emri"].ToString();
                                user.Mbiemri = sqlr["Mbiemri"].ToString();
                                user.Email = sqlr["Email"].ToString();
                                user.Password = sqlr["Password"].ToString();
                                user.NrKontaktues = sqlr["NrKontaktues"].ToString();
                                user.DataLindjes = Convert.ToDateTime(sqlr["DataELindjes"].ToString());
                                user.Adresa = sqlr["Adresa"].ToString();
                                user.TipiUser = new TipiUser();
                                user.TipiUser.TipiID = int.Parse(sqlr["TipiID"].ToString());
                                user.TipiUser.Pershkrimi = sqlr["Pershkrimi"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return user;
        }
    }
}
