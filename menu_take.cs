﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard_medios
{
    public partial class menu_take : MetroFramework.Forms.MetroForm
    {
        public menu_take()
        {
            InitializeComponent();
        }

        private void take_over_Load(object sender, EventArgs e)
        {

        }

        private void program_Click(object sender, EventArgs e)
        {
            take_over_bd formlario = new take_over_bd();
            formlario.Show();
        }

        private void list_Click(object sender, EventArgs e)
        {
            take_over_bd_full formlario = new take_over_bd_full();
            formlario.Show();
        }
    }
}
