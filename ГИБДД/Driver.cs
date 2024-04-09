using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ГИБДД
{
    public class Driver
    {
        public Guid GUID { get; set; }
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
        public string Comments { get; set; }

        public string GetDriverInfo()
        {
            return $"{GUID} {FirstName} {LastName} {Patronymic} {Passport} {RegistrationAddress} {ResidentialAddress} {WorkingPlace} {Position} {PhoneNuber} {Email} {Comments}";
        }
    }

    public class DriverEventArgs : EventArgs
    {
        public ListViewItem DriverItem { get; }

        public DriverEventArgs(ListViewItem item)
        {
            DriverItem = item;
        }
    }

}
