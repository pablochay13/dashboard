using System;
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
    public partial class main : MetroFramework.Forms.MetroForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void sort_order_Click(object sender, EventArgs e)
        {
            menu_hoteles formlario = new menu_hoteles();
            formlario.Show();
        }

        private void so_paquetes_Click(object sender, EventArgs e)
        {
            menu_paquetes formlario = new menu_paquetes();
            formlario.Show();
        }

        private void timer_baner_Click(object sender, EventArgs e)
        {
            menu_timer formlario = new menu_timer();
            formlario.Show();
        }

        private void banner_rdb_Click(object sender, EventArgs e)
        {
            menu_banner formlario = new menu_banner();
            formlario.Show();
        }

        private void take_over_Click(object sender, EventArgs e)
        {
            menu_take formlario = new menu_take();
            formlario.Show();
        }

        private void info_notes_Click(object sender, EventArgs e)
        {
            info_notes formlario = new info_notes();
            formlario.Show();
        }
    }
}
