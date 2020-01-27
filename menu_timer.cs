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
    public partial class menu_timer : MetroFramework.Forms.MetroForm
    {
        public menu_timer()
        {
            InitializeComponent();
        }

        private void menu_timer_Load(object sender, EventArgs e)
        {

        }

        private void program_Click(object sender, EventArgs e)
        {
            timer_banner_bd formlario = new timer_banner_bd();
            formlario.Show();
        }

        private void list_Click(object sender, EventArgs e)
        {
            timer_banner_bd_full formlario = new timer_banner_bd_full();
            formlario.Show();
        }
    }
}
