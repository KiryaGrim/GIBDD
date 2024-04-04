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
        public Driver() { }
        public Guid Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Passport { get; set; }
        public string RegistationAddress { get; set; }
        public string ResidentialAddress { get; set; }
        public string WorkingPlace { get; set; }
        public string Position { get; set; }
        public string PhoneNuber { get; set; }
        public string Email { get; set; }
        public Image Photo { get; set; }
        public string Comments { get; set; }
    }
}
