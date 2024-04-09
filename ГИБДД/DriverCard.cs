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
using static System.Net.Mime.MediaTypeNames;

namespace GIBDD
{
    public partial class DriverCard : Form
    {
        public DriverCard()
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

            ChoosePhoto.Controls.Add(pictureBox1);

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
                    this.pictureBox1.Size = bitmap.Size;
                    pictureBox1.Image = bitmap;

                }
            }
        }

        private void SaveDriver_Click(object sender, EventArgs e) // Созданение изменений карты водителя
        {
            this.Hide();
            MessageBox.Show("Данные были успешно сохранены");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}