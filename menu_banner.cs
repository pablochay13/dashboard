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
    public partial class menu_banner : MetroFramework.Forms.MetroForm
    {
        public menu_banner()
        {
            InitializeComponent();
        }

        private void menu_banner_Load(object sender, EventArgs e)
        {

        }

        private void program_Click(object sender, EventArgs e)
        {
            banners_rdb_bd formlario = new banners_rdb_bd();
            formlario.Show();
        }

        private void list_Click(object sender, EventArgs e)
        {
            banners_rdb_bd_full formlario = new banners_rdb_bd_full();
            formlario.Show();
        }
    }
}
