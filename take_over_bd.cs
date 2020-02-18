using MySql.Data.MySqlClient;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard_medios
{
    public partial class take_over_bd : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(variables.Sentencia);

        int year1, month1, day1 = 0;

        string fecha_evento, hotel, fecha_tb, hotel_tb = "";


        public take_over_bd()
        {
            InitializeComponent();

            this.timer_banner_bdm.Culture = new CultureInfo("es-MX");

            account_text.Text = variables.nombre;
        }

        private void take_over_bd_Load(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                List<SpecialDate> SpecialDates = new List<SpecialDate>();

                con.Open();
                string sql = "SELECT fecha FROM take_over_bd";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fecha_evento = Convert.ToString(reader["fecha"]);

                    DateTime date1 = DateTime.Parse(fecha_evento);

                    year1 = date1.Year;
                    month1 = date1.Month;
                    day1 = date1.Day;

                    SpecialDate specialDate1 = new SpecialDate();
                    specialDate1.BackColor = System.Drawing.Color.LightSkyBlue;
                    specialDate1.ForeColor = System.Drawing.Color.Black;
                    specialDate1.Value = new System.DateTime(year1, month1, day1, 0, 0, 0, 0);

                    SpecialDates.Add(specialDate1);
                }

                timer_banner_bdm.SpecialDates = SpecialDates;

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }


        private void timer_banner_bdm_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textFecha.Text = timer_banner_bdm.SelectedDate.Value.ToString("yyyy-MM-dd");

                //registroFechasMedia.Rows.Add(textFecha.Text, hotel_combo.Text);

                con.Close();

                con.Open();

                string sql = "SELECT * FROM take_over_bd where fecha = '" + timer_banner_bdm.SelectedDate.Value.ToString("yyyy-MM-dd") + "'";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fecha_evento = Convert.ToString(reader["fecha"]);
                    fecha_tb = fecha_evento;

                    hotel = Convert.ToString(reader["hotel"]);
                    hotel_tb = hotel;

                    DateTime date1 = DateTime.Parse(fecha_evento);

                    year1 = date1.Year;
                    month1 = date1.Month;
                    day1 = date1.Day;
                }

                if (fecha_tb == fecha_evento && hotel_tb == hotel)
                {
                    string ocupado_sort = Convert.ToString(fecha_evento) + "\n" + Convert.ToString(hotel);

                    MetroFramework.MetroMessageBox.Show(this, ocupado_sort, "Fecha ocupada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    fecha_tb = "";
                    hotel_tb = "";
                }
                else
                {
                    registroFechasMedia.Rows.Add(textFecha.Text, hotel_combo.Text, account_text.Text);
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            registroFechasMedia.Rows.RemoveAt(registroFechasMedia.CurrentRow.Index);
        }

        private void programing_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand agregar = new MySqlCommand("INSERT INTO take_over_bd (`fecha` , `hotel`, `account`) VALUES (?fecha , ?hotel, ?account)", con);

                con.Close();
                con.Open();

                foreach (DataGridViewRow row in registroFechasMedia.Rows)
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.Add("?fecha", MySqlDbType.String).Value = Convert.ToString(row.Cells["fecha_so"].Value);
                    agregar.Parameters.Add("?hotel", MySqlDbType.String).Value = Convert.ToString(row.Cells["hotel_so"].Value);
                    agregar.Parameters.Add("?account", MySqlDbType.String).Value = Convert.ToString(row.Cells["account_so"].Value);

                    agregar.ExecuteNonQuery();
                }

                MetroFramework.MetroMessageBox.Show(this, "Datos registrados correctamente", "Best Travel Media", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Table start.
                string html = "<h2>Solicitud de fechas:</h2>";

                html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt'>";

                //Adding HeaderRow.
                html += "<tr>";
                foreach (DataGridViewColumn column in registroFechasMedia.Columns)
                {
                    html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>";
                }
                html += "</tr>";

                //Adding DataRow.
                foreach (DataGridViewRow row in registroFechasMedia.Rows)
                {
                    html += "<tr>";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        html += "<td style='width:200px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>";
                    }
                    html += "</tr>";
                }

                //Table end.
                html += "</table>";


                //Sending the DataGridView's HTML in Email.
                using (MailMessage mm = new MailMessage("pablochay.bd@gmail.com", "lizeth.chi@bestday.com"))
                {
                    MailAddress copy = new MailAddress("pamador@bestday.com");
                    mm.CC.Add(copy);
                    mm.Subject = "Solicitud alta Sort Order" + " " + "-" + " " + variables.nombre;
                    mm.Body = html;
                    mm.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential(mm.From.Address, "Chay1318");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);

                    MetroFramework.MetroMessageBox.Show(this, "Correo Enviado Correctamente", "Best Travel Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                registroFechasMedia.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                con.Close();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            registroFechasMedia.Rows.Add(textFecha.Text, hotel_combo.Text, account_text.Text);
        }

        //public void comboClientes()
        //{
        //    try
        //    {
        //        //string path = "server=172.20.3.45; database=bd-media; Uid=root; pwd=Medi@@dm1n!!;Allow Zero Datetime=False;Convert Zero Datetime=True";
        //        string path = "server=162.241.60.127;database=ccascaru_bdm;Uid=ccascaru_root;pwd=Chay1318;";

        //        MySqlConnection conecta = new MySqlConnection(path);
        //        conecta.Close();

        //        string selectQuery = "select id_clientes, nombre_comercial from clientes";
        //        conecta.Open();
        //        MySqlCommand command = new MySqlCommand(selectQuery, conecta);

        //        MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
        //        DataTable dt = new DataTable();
        //        mysqldt.Fill(dt);

        //        hotel_combo.ValueMember = "id_clientes";
        //        hotel_combo.DisplayMember = "nombre_comercial";
        //        hotel_combo.DataSource = dt;

        //        conecta.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
