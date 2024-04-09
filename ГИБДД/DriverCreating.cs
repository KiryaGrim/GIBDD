using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ГИБДД;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GIBDD
{
    public partial class DriverCreating : Form
    {
        public event EventHandler<DriverEventArgs> DriverCreated;

        public DriverCreating()
        {
            InitializeComponent();
        }

        private void ChoosePhoto_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Выберите фотографию водителя";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Проверяем, соответствует ли выбранный файл заданным условиям
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                if (4 * bitmap.Width != 3 * bitmap.Height)
                {
                    MessageBox.Show("Выбранный файл не соответствует заданным параметрам", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Если все условия выполнены, прикрепляем изображение к кнопке
                    pictureBox1.Image = bitmap;
                   
                }
            }
        }

        public void CreateDriver_Click(object sender, EventArgs e) // Создаем водителя
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
                    textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox10.Text == "" || 
                    textBox11.Text == "" || pictureBox1.Image == null)
                    throw new Exception("Не все поля заполнены");

                string guid = Guid.NewGuid().ToString();
                string firstname = textBox2.Text.Trim();
                string lastname = textBox3.Text.Trim();
                string patronymic = textBox4.Text.Trim();
                string passport = textBox5.Text.Trim();
                string registrationAddress = textBox6.Text.Trim();
                string residentialAddress = textBox7.Text.Trim();
                string workingPlace = textBox8.Text.Trim();
                string position = textBox9.Text.Trim();
                string phoneNumber = textBox10.Text.Trim();
                string email = textBox11.Text.Trim();
                string comments = textBox13.Text.Trim();

                ListViewItem item = new ListViewItem(new string[] { guid, firstname, lastname, patronymic, passport, 
                    registrationAddress, residentialAddress, workingPlace, position, phoneNumber, email});

                DriverCreated?.Invoke(this, new DriverEventArgs(item));

                ClearFields();
                MessageBox.Show("Данные были успешно сохранены");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox13.Text = "";
            pictureBox1.Image = null;
        }
    }
}