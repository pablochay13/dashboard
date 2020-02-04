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
    public partial class calendar_rdb_bd : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(variables.Sentencia);

        string fecha_evento = "";

        public calendar_rdb_bd()
        {
            InitializeComponent();

            destinos_combo();
            carga_fechas();

            destino_combo.SelectedIndex = 1;
            posicion_combo.SelectedIndex = 0;
        }

        private void calendar_rdb_bd_Load(object sender, EventArgs e)
        {

        }

        public void carga_fechas()
        {
            try
            {
                if (posicion_combo.SelectedIndex == 0)
                {
                    string posicion_selected = "Primera";
                    con.Close();

                    calendar_full.Refresh();

                    calendar_full.SelectedDates.Clear();

                    con.Open();
                    string sql = "SELECT * FROM banners_rdb_bd WHERE posicion='" + posicion_selected + "'AND destino='" + destino_combo.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fecha_evento = Convert.ToString(reader["fecha_inicio"]);

                        calendar_full.AddDate(Convert.ToDateTime(fecha_evento), Color.Yellow, 2);
                    }

                    con.Close();
                }

                else if (posicion_combo.SelectedIndex == 1)
                {
                    string posicion_selected = "Segunda";
                    con.Close();

                    con.Close();

                    calendar_full.Refresh();

                    calendar_full.SelectedDates.Clear();

                    con.Open();
                    string sql = "SELECT * FROM banners_rdb_bd WHERE posicion='" + posicion_selected + "'AND destino='" + destino_combo.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fecha_evento = Convert.ToString(reader["fecha_inicio"]);

                        calendar_full.AddDate(Convert.ToDateTime(fecha_evento), Color.Yellow, 2);
                    }

                    con.Close();
                }

                else if (posicion_combo.SelectedIndex == 2)
                {
                    string posicion_selected = "Tercera";

                    con.Close();

                    calendar_full.Refresh();

                    calendar_full.SelectedDates.Clear();

                    con.Open();
                    string sql = "SELECT * FROM banners_rdb_bd WHERE posicion='" + posicion_selected + "'AND destino='" + destino_combo.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fecha_evento = Convert.ToString(reader["fecha_inicio"]);

                        calendar_full.AddDate(Convert.ToDateTime(fecha_evento), Color.Yellow, 2);
                    }

                    con.Close();
                }

                else if (posicion_combo.SelectedIndex == 3)
                {
                    string posicion_selected = "Cuarta";

                    con.Close();

                    calendar_full.Refresh();

                    calendar_full.SelectedDates.Clear();

                    con.Open();
                    string sql = "SELECT * FROM banners_rdb_bd WHERE posicion='" + posicion_selected + "'AND destino='" + destino_combo.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fecha_evento = Convert.ToString(reader["fecha_inicio"]);

                        calendar_full.AddDate(Convert.ToDateTime(fecha_evento), Color.Yellow, 2);
                    }

                    con.Close();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void destinos_combo()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, destino from destinos";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                destino_combo.ValueMember = "id";
                destino_combo.DisplayMember = "destino";
                destino_combo.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void destino_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();

            calendar_full.Refresh();

            calendar_full.SelectedDates.Clear();

            con.Open();
            string sql = "SELECT * FROM banners_rdb_bd WHERE posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                fecha_evento = Convert.ToString(reader["fecha_inicio"]);

                calendar_full.AddDate(Convert.ToDateTime(fecha_evento), Color.Yellow, 2);
            }

            con.Close();
        }

        private void posicion_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            carga_fechas();
        }
    }
}
