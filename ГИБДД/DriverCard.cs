using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void SaveDriver_Click(object sender, EventArgs e)
        {
            //Сохранение изменений карточики водителя
        }
    }
}