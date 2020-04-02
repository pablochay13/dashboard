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

        private void calendar_Click(object sender, EventArgs e)
        {
            calendar_rdb_bd formlario = new calendar_rdb_bd();
            formlario.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            banners_rdb_liverp formlario = new banners_rdb_liverp();
            formlario.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            banners_rdb_coppel formlario = new banners_rdb_coppel();
            formlario.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            banners_rdb_united formlario = new banners_rdb_united();
            formlario.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            banners_rdb_tar formlario = new banners_rdb_tar();
            formlario.Show();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            banners_rdb_bancomer formlario = new banners_rdb_bancomer();
            formlario.Show();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            banners_rdb_viva formlario = new banners_rdb_viva();
            formlario.Show();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            banners_rdb_long formlario = new banners_rdb_long();
            formlario.Show();
        }
    }
}
