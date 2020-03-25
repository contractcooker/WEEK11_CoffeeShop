using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class RegistrationForm
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string confirmPassword;
        private string favoriteBlend;
        private bool receiveEmails;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Dob { get => dob; set => dob = value; }
        public string FavoriteBlend { get => favoriteBlend; set => favoriteBlend = value; }
        public bool ReceiveEmails { get => receiveEmails; set => receiveEmails = value; }
    }
}
