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
    public partial class Form2 : Form
    {
        Bitmap imageFile = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "image files (*.jpeg)|*.jpeg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

           




            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageFile = new Bitmap(openFileDialog1.FileName);
                if (4* imageFile.Width != 3 * imageFile.Height)
                {
                    MessageBox.Show("Выбранный файл не соответствует заданным параметрам", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                                   
              pictureBox1.Image = imageFile;
                }
            }

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}