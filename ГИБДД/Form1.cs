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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var oldSettings = SettingsManager.GetSettings();
            oldSettings.IsRemember = checkBox1.Checked;
            SettingsManager.SaveSettings(oldSettings);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; //Проверка введенных данных
            string password = txtPassword.Text;
            if (username == "inspector" && password == "inspector")
            {
                MessageBox.Show("Добро пожаловать, " + username + "!");
            }
            else
            {
                MessageBox.Show("Неверные данные, попробуйте ещё раз.");
            }
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = SettingsManager.GetSettings().IsRemember;
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
