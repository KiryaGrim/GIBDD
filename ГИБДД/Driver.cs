using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ГИБДД
{
    public class Driver
    {
        public Driver(string firstname, string lastname, string patronymic, string passport, 
            string registrationAddres, string residentialAddress, string workingPlace, string position, 
            string phoneNumber, string email, Image photo, string comments)
        {
            FirstName = firstname;
            LastName = lastname;
            Patronymic = patronymic;
            Passport = passport;
            RegistrationAddress = registrationAddres;
            ResidentialAddress = residentialAddress;
            WorkingPlace = workingPlace;
            Position = position;
            PhoneNuber = phoneNumber;
            Email = email;
            Photo = photo;
        }
        public Guid Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Passport { get; set; }
        public string RegistrationAddress { get; set; }
        public string ResidentialAddress { get; set; }
        public string WorkingPlace { get; set; }
        public string Position { get; set; }
        public string PhoneNuber { get; set; }
        public string Email { get; set; }
        public Image Photo { get; set; }
        public string Comments { get; set; }
    }
}
