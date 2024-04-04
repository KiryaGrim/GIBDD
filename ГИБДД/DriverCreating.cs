using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ГИБДД;

namespace GIBDD
{
    public partial class DriverCreating : Form
    {
        public DriverCreating()
        {
            InitializeComponent();
        }

        private void ChoosePhoto_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG Files|*.jpg|PNG Files|*.png";
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
                    ChoosePhoto.Controls.Add(pictureBox1);
                }
            }
        }

        private void CreateDriver_Click(object sender, EventArgs e) // Создаем водителя
        {
            Driver driver = new Driver();
            driver.Guid = Guid.NewGuid();
            driver.FirstName = textBox2.Text;
            driver.LastName = textBox3.Text;
            driver.Patronymic = textBox4.Text;
            driver.Passport = textBox5.Text;
            driver.RegistationAddress = textBox6.Text;
            driver.ResidentialAddress = textBox7.Text;
            driver.WorkingPlace = textBox8.Text;
            driver.Position = textBox9.Text;
            driver.PhoneNuber = textBox10.Text;
            driver.Email = textBox11.Text;
            driver.Photo = pictureBox1.Image;
            driver.Comments = textBox13.Text;            

            this.Hide();
            MessageBox.Show("Данные были успешно сохранены");
        }
    }
}