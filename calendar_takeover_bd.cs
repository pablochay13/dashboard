using MySql.Data.MySqlClient;
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
    public partial class calendar_takeover_bd : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(variables.Sentencia);

        string fecha_evento = "";

        public calendar_takeover_bd()
        {
            InitializeComponent();

            carga_fechas();
        }

        private void calendar_takeover_bd_Load(object sender, EventArgs e)
        {

        }

        public void carga_fechas()
        {
            try
            {
                con.Close();

                calendar_full.Refresh();

                calendar_full.SelectedDates.Clear();

                con.Open();
                string sql = "SELECT * FROM take_over_bd";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fecha_evento = Convert.ToString(reader["fecha"]);

                    calendar_full.AddDate(Convert.ToDateTime(fecha_evento), Color.Yellow, 2);
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
