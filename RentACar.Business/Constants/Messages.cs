using RentACar.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Constants
{
    public static class Messages
    {
        public static string Added = "Added!";
        public static string Removed = "Removed!";
        public static string Updated = "Updated!";
        public static string CarHasMoreThan5ImagesError = "There should not be more than 5 images of the car";
        public static string UserNotExists = "User not exists";
        public static string PasswordError = "Wrong password";
        public static string UserExist = "User already exists";
        public static string UserRegistered = "User succesfully registered";
        public static string TokenCreated = "Access token created";
    }
}
