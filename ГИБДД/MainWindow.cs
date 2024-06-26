﻿using GIBDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ГИБДД
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 30);
            listView1.Columns.Add("Имя", 50);
            listView1.Columns.Add("Фамилия", 65);
            listView1.Columns.Add("Отчество", 60);
            listView1.Columns.Add("Паспорт", 55);
            listView1.Columns.Add("Адрес регистрации", 115);
            listView1.Columns.Add("Адрес проживания", 110);
            listView1.Columns.Add("Место работы", 90);
            listView1.Columns.Add("Должность", 70);
            listView1.Columns.Add("Телефон", 65);
            listView1.Columns.Add("Почта", 60);
            listView1.MouseClick += ListView_MouseClick;
        }

        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            // Получаем выбранную строку в ListView
            ListViewItem selectedItem = listView1.SelectedItems[0];

            // Получаем данные из выбранной строки, например, ID водителя
            if (Guid.TryParse(selectedItem.SubItems[0].Text, out Guid driverId))
            {
                // Открываем форму DriverCard с передачей необходимых данных
                DriverCard driverCardForm = new DriverCard(driverId);
                driverCardForm.Show();
            }
            else
            {
                MessageBox.Show("Ошибка при получении ID водителя.");
            }
        }

        private void CreateDriver_Click(object sender, EventArgs e) // Кнопка "Создать", которая открывает окно создания водителя
        {
            DriverCreating driverCreating = new DriverCreating();
            driverCreating.DriverCreated += DriverCreating_DriverCreated;
            driverCreating.ShowDialog();            
        }

        private void DriverCreating_DriverCreated(object sender, DriverEventArgs e)
        {
            // Добавление водителя в listViewDrivers
            listView1.Items.Add(e.DriverItem);
        }
    }
}
