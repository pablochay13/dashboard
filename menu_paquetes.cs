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
    public partial class menu_paquetes : MetroFramework.Forms.MetroForm
    {
        public menu_paquetes()
        {
            InitializeComponent();
        }

        private void menu_paquetes_Load(object sender, EventArgs e)
        {

        }

        private void program_Click(object sender, EventArgs e)
        {
            sort_orders_paquetes_bd formlario = new sort_orders_paquetes_bd();
            formlario.Show();
        }

        private void list_Click(object sender, EventArgs e)
        {
            sort_orders_paquetes_bd_full formlario = new sort_orders_paquetes_bd_full();
            formlario.Show();
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            calendar_so_paquetes_bd formlario = new calendar_so_paquetes_bd();
            formlario.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            sort_orders_paquetes_liverp formlario = new sort_orders_paquetes_liverp();
            formlario.Show();
        }
    }
}
