using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Localized_E_commerce.Factory
{
    public class UserFactory
    {
        public static User register(String name, String username, String email, String password)
        {
            User newUser = new User();
            
            newUser.name = name;
            newUser.username = username;
            newUser.email = email; 
            newUser.password = password;

            return newUser;
        }

        public static User changeProfile(String name, DateTime dob, String gender)
        {
            User user = new User();
            user.name = name;
            user.dob = dob;
            user.gender = gender;

            return user;
        }
    }
}