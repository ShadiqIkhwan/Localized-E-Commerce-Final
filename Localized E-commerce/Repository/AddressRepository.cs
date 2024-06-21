using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Localized_E_commerce.Repository
{
    public class AddressRepository
    {
        public static LocalizedDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<Address> GetAllAddress(int userId)
        {
            return db.Addresses.Where(x => x.userId == userId).ToList();
        }

        public static void ChangeTypeAllToNotPrimary(int userId, int addressId) { 
            List<Address> addresses= db.Addresses.Where(x => x.userId == userId).ToList();

            addresses.ForEach(x => 
                x.Type = "Not"
            );

            db.SaveChanges();

            Address oldData = db.Addresses.Find(addressId);
            oldData.Type = "Primary";
            db.SaveChanges();

        }

        public static void ChangeAddress(int addressId, Address address)
        {
            Address oldData = db.Addresses.Find(addressId);
            oldData.Address1 = address.Address1;
            db.SaveChanges();
        }

        public static void AddAddress(Address address) { 
            db.Addresses.Add(address);
            db.SaveChanges();
        }
    }
}