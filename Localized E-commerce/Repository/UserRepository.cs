using Localized_E_commerce.Factory;
using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Localized_E_commerce.Repository
{
    public class UserRepository
    {
        public static LocalizedDatabaseEntities db = DatabaseSingleton.GetInstance();
        public static String register(String name, String username, String email, String password)
        {
            User newUser = UserFactory.register(name, username, email, password);
            db.Users.Add(newUser);
            db.SaveChanges();

            return "Berhasil mendaftar";

        }

        public static User login(String username, String password) {
            User loginUser = (from x in db.Users where (x.email == username || x.username == username) && x.password == password select x).FirstOrDefault();

            return loginUser;
        }

        public static void UpdateProfile(int id, User user)
        {
            User oldUser = db.Users.Find(id);
            oldUser.name = user.name;
            oldUser.dob = user.dob;
            oldUser.gender = user.gender;

            db.SaveChanges();
        }
    }
}