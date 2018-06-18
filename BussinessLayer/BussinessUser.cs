using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessLayer;
using EntityLayer;

namespace BussinessLayer
{
    public class BussinessUser
    {
        public static List<User> GetAllUsers()
        {
            return AccessUsers.GetAll();
        }

        public static User GetUserById(int id)
        {
            return AccessUsers.GetById(id);
        }

        public static void InsertUser(User user)
        {
            AccessUsers.Insert(user);
        }

        public static void EditUser(int id, User user)
        {
            AccessUsers.Edit(id, user);
        }

        public static void Delete(int id)
        {
            AccessUsers.Delete(id);
        }

        public static User LogInUser(string email, string password)
        {
            return AccessUsers.LogIn(email, password);
        }
    }
}
