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
                   
                }
            }
        }

        private void CreateDriver_Click(object sender, EventArgs e) // Создаем водителя
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
                    textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" ||
                    textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox13.Text == "")
                    throw new Exception("Не все поля заполнены");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          

            this.Hide();
            MessageBox.Show("Данные были успешно сохранены");
        }
    }
}