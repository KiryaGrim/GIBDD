using GIBDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ГИБДД
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateDriver_Click(object sender, EventArgs e)
        {
            DriverCreating driverCreating = new DriverCreating();
            this.Hide();
            driverCreating.Show();
        }
    }
}
