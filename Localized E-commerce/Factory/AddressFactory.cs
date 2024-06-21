using Localized_E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Localized_E_commerce.Factory
{
    public class AddressFactory
    {
        public static Address ChangeAddress(String newAddress)
        {
            Address address = new Address()
            {
                Address1 = newAddress
            };

            return address;
        }

        public static Address AddAddress(int userId, String Address, String Type, String AddressName, String PhoneNumber)
        {
            Address address = new Address()
            {
                userId = userId,
                Address1 = Address,
                Type = Type,
                AddressName = AddressName,
                PhoneNumber = PhoneNumber
            };

            return address;
        }
    }
}