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
            MessageBox.Show(car.ToString());
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {

        }
    }
}
