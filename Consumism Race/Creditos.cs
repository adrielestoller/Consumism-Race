﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumism_Race
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void Btn_casinha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Creditos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();
        }
    }
}
