using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Localized_E_commerce
{
    public class DatabaseSingleton
    {
        private static LocalizedDatabaseEntities instance;

        public static LocalizedDatabaseEntities GetInstance()
        {
            if (instance == null)
            {
                instance = new LocalizedDatabaseEntities();
            }

            return instance;
        }
    }
}