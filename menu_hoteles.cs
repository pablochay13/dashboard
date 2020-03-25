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
    public partial class menu_hoteles : MetroFramework.Forms.MetroForm
    {
        public menu_hoteles()
        {
            InitializeComponent();
        }

        private void menu_hoteles_Load(object sender, EventArgs e)
        {

        }

        private void program_Click(object sender, EventArgs e)
        {
            sort_orders_hoteles_liverp formlario = new sort_orders_hoteles_liverp();
            formlario.Show();
        }

        private void list_Click(object sender, EventArgs e)
        {
            sort_orders_hoteles_full formlario = new sort_orders_hoteles_full();
            formlario.Show();
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            calendar_so_hoteles formlario = new calendar_so_hoteles();
            formlario.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            sort_orders_hoteles_liverp formlario = new sort_orders_hoteles_liverp();
            formlario.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            sort_orders_hoteles_hdo formlario = new sort_orders_hoteles_hdo();
            formlario.Show();
        }
    }
}
