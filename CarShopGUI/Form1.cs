﻿using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            Car car = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
            // MessageBox.Show(car.ToString());
            myStore.CarList.Add(car);
            carInventoryBindingSource.ResetBindings(false);
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;

            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();
        }
    }
}
