using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private string dob;
        private string favoriteBlend;
        private bool receiveEmails;

        [DisplayName("First Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("E-mail")]
        [EmailAddress]
        [Required]
        public string Email { get => email; set => email = value; }

        [DisplayName("Password")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string Password { get => password; set => password = value; }

        [DisplayName("Birthdate (MMDDYYYY)")]
        [Required]
        [MaxLength(8)]
        [MinLength(8)]
        public string Dob { get => dob; set => dob = value; }

        [DisplayName("Favorite Bean")]
        [Required]
        public string FavoriteBlend { get => favoriteBlend; set => favoriteBlend = value; }
        
        [DisplayName("Receive Emails?")]      
        public bool ReceiveEmails { get => receiveEmails; set => receiveEmails = value; }
    }
}
