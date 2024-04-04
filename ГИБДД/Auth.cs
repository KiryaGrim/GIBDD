using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using ГИБДД;

namespace GIBDD
{
    public partial class Auth : Form
    {
        int count = 3;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Auth()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;

            timer.Interval = 30000;
            timer.Tick += Timer_Tick;
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "inspector" && password == "inspector")
            {
                MainWindow mainWindow = new MainWindow();
                this.Hide();
                mainWindow.Show();
            }
            else
            {
                count--;
                if (count > 0)
                    MessageBox.Show($"Неверные данные, попробуйте ещё раз. Осталось {count} попыток");
                else
                {
                    MessageBox.Show("Превышено количество попыток входа" + Environment.NewLine + "Попробуйте войти через 30 секунд");
                    timer.Start();
                    LogIn.Enabled = false;
                }                  
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            LogIn.Enabled = true;
            count = 3;
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
