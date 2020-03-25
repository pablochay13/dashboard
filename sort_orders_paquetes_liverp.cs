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
    public partial class sort_orders_paquetes_liverp : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(variables.Sentencia);

        int year1, month1, day1 = 0;

        string fecha_evento, posicion, hotel, fecha_consulta, posicion_consulta = "";

        string fecha_final, dia_seleccionado, mes_seleccionado, anio_seleccionado = "";

        public sort_orders_paquetes_liverp()
        {
            InitializeComponent();

            this.calendar_sort_bd.Culture = new CultureInfo("es-MX");

            destinos_combo();

            comboMeses.SelectedIndex = 0;
            comboAnio.SelectedIndex = 0;
            destino_combo.SelectedIndex = 0;
            posicion_combo.SelectedIndex = 0;

            account_text.Text = variables.nombre;
        }

        private void sort_orders_paquetes_bd_Load(object sender, EventArgs e)
        {
            carga_fechas();

            this.calendar_sort_bd.ShowNavigationButton = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (uno.Checked == true)
            {
                dia_seleccionado = "01";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (dos.Checked == true)
            {
                dia_seleccionado = "02";
                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (tres.Checked == true)
            {
                dia_seleccionado = "03";
                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (cuatro.Checked == true)
            {
                dia_seleccionado = "04";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (cinco.Checked == true)
            {
                dia_seleccionado = "05";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (seis.Checked == true)
            {
                dia_seleccionado = "06";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (siete.Checked == true)
            {
                dia_seleccionado = "07";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (ocho.Checked == true)
            {
                dia_seleccionado = "08";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (nueve.Checked == true)
            {
                dia_seleccionado = "09";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (diez.Checked == true)
            {
                dia_seleccionado = "10";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (once.Checked == true)
            {
                dia_seleccionado = "11";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;



                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (doce.Checked == true)
            {
                dia_seleccionado = "12";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (trece.Checked == true)
            {
                dia_seleccionado = "13";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (catorce.Checked == true)
            {
                dia_seleccionado = "14";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (quince.Checked == true)
            {
                dia_seleccionado = "15";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;



                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (dieciseis.Checked == true)
            {
                dia_seleccionado = "16";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (diecisiete.Checked == true)
            {
                dia_seleccionado = "17";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (dieciocho.Checked == true)
            {
                dia_seleccionado = "18";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (diecinueve.Checked == true)
            {
                dia_seleccionado = "19";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (veinte.Checked == true)
            {
                dia_seleccionado = "20";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (veitiuno.Checked == true)
            {
                dia_seleccionado = "21";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;



                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (veintidos.Checked == true)
            {
                dia_seleccionado = "22";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (veititres.Checked == true)
            {
                dia_seleccionado = "23";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (veiticuatro.Checked == true)
            {
                dia_seleccionado = "24";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (veiticinco.Checked == true)
            {
                dia_seleccionado = "25";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);

            }

            if (veitiseis.Checked == true)
            {
                dia_seleccionado = "26";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (veitisiete.Checked == true)
            {
                dia_seleccionado = "27";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (veitiocho.Checked == true)
            {
                dia_seleccionado = "28";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (veitinueve.Checked == true)
            {
                dia_seleccionado = "29";
                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (treinta.Checked == true)
            {
                dia_seleccionado = "30";
                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }

            if (treintauno.Checked == true)
            {
                dia_seleccionado = "31";
                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                registroFechasMedia.Rows.Add(fecha_final, posicion_combo.Text, destino_combo.Text, hotel_combo.Text, account_text.Text);
            }
        }

        private void programing_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand agregar = new MySqlCommand("INSERT INTO sort_orders_paquetes_liverp (`fecha_inicio` , `posicion` , `destino` , `hotel` , `account`) VALUES (?fecha_inicio , ?posicion , ?destino , ?hotel , ?account)", con);

                con.Close();
                con.Open();


                foreach (DataGridViewRow row in registroFechasMedia.Rows)
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.Add("?fecha_inicio", MySqlDbType.String).Value = Convert.ToString(row.Cells["fecha_so"].Value);
                    agregar.Parameters.Add("?posicion", MySqlDbType.String).Value = Convert.ToString(row.Cells["posicion_so"].Value);
                    agregar.Parameters.Add("?destino", MySqlDbType.String).Value = Convert.ToString(row.Cells["destino_so"].Value);
                    agregar.Parameters.Add("?hotel", MySqlDbType.String).Value = Convert.ToString(row.Cells["hotel_so"].Value);
                    agregar.Parameters.Add("?account", MySqlDbType.String).Value = Convert.ToString(row.Cells["account_so"].Value);

                    agregar.ExecuteNonQuery();
                }

                MetroFramework.MetroMessageBox.Show(this, "Datos registrados correctamente", "Best Travel Media", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carga_fechas();

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
                using (MailMessage mm = new MailMessage("pablochay.bd@gmail.com", "maria.paxtian@bestday.com"))
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

                uno.Checked = false;
                dos.Checked = false;
                tres.Checked = false;
                cuatro.Checked = false;
                cinco.Checked = false;
                seis.Checked = false;
                siete.Checked = false;
                ocho.Checked = false;
                nueve.Checked = false;
                diez.Checked = false;
                once.Checked = false;
                doce.Checked = false;
                trece.Checked = false;
                catorce.Checked = false;
                quince.Checked = false;
                dieciseis.Checked = false;
                diecisiete.Checked = false;
                dieciocho.Checked = false;
                diecinueve.Checked = false;
                veinte.Checked = false;
                veitiuno.Checked = false;
                veintidos.Checked = false;
                veititres.Checked = false;
                veiticuatro.Checked = false;
                veiticinco.Checked = false;
                veitiseis.Checked = false;
                veitisiete.Checked = false;
                veitiocho.Checked = false;
                veitinueve.Checked = false;
                treinta.Checked = false;
                treintauno.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                con.Close();
            }
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            registroFechasMedia.Rows.RemoveAt(registroFechasMedia.CurrentRow.Index);
        }

        private void posicion_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            carga_fechas();
        }

        private void comboMeses_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboMeses.SelectedIndex == 3 || comboMeses.SelectedIndex == 5 || comboMeses.SelectedIndex == 8 || comboMeses.SelectedIndex == 10 || comboMeses.SelectedIndex == 1 && comboAnio.SelectedIndex == 1)
            {
                treintauno.Visible = false;
            }
            else
            {
                treintauno.Visible = true;
            }

            uno.Checked = false;
            dos.Checked = false;
            tres.Checked = false;
            cuatro.Checked = false;
            cinco.Checked = false;
            seis.Checked = false;
            siete.Checked = false;
            ocho.Checked = false;
            nueve.Checked = false;
            diez.Checked = false;
            once.Checked = false;
            doce.Checked = false;
            trece.Checked = false;
            catorce.Checked = false;
            quince.Checked = false;
            dieciseis.Checked = false;
            diecisiete.Checked = false;
            dieciocho.Checked = false;
            diecinueve.Checked = false;
            veinte.Checked = false;
            veitiuno.Checked = false;
            veintidos.Checked = false;
            veititres.Checked = false;
            veiticuatro.Checked = false;
            veiticinco.Checked = false;
            veitiseis.Checked = false;
            veitisiete.Checked = false;
            veitiocho.Checked = false;
            veitinueve.Checked = false;
            treinta.Checked = false;
            treintauno.Checked = false;
        }

        private void calendar_sort_bd_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                con.Open();

                string sql = "SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + calendar_sort_bd.SelectedDate.Value.ToString("yyyy-MM-dd") + "'";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fecha_evento = Convert.ToString(reader["fecha_inicio"]);
                    posicion = Convert.ToString(reader["posicion"]);
                    hotel = Convert.ToString(reader["hotel"]);

                    DateTime date1 = DateTime.Parse(fecha_evento);

                    year1 = date1.Year;
                    month1 = date1.Month;
                    day1 = date1.Day;

                    string ocupado_sort = Convert.ToString(fecha_evento) + "\n" + Convert.ToString(posicion) + "\n" + Convert.ToString(hotel);

                    MetroFramework.MetroMessageBox.Show(this, ocupado_sort, "Fecha ocupada en las siguientes posiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void uno_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.uno.Checked == true)
            {
                dia_seleccionado = "01";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                con.Close();
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                MySqlDataReader leer = cmd.ExecuteReader();

                if (leer.Read())
                {
                    string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                    variables.fecha_consulta = fecha_consulta_1;

                    string consulta_posicion = Convert.ToString(leer["posicion"]);
                    variables.posicion_consulta = consulta_posicion;

                    string consulta_destino = Convert.ToString(leer["destino"]);
                    variables.destino_consulta = consulta_destino;

                    if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                    {
                        MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        uno.Checked = false;
                    }
                }

                con.Close();
            }
        }

        private void dos_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.dos.Checked == true)
            {
                dia_seleccionado = "02";

                month();
                year();

                fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                con.Close();
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                MySqlDataReader leer = cmd.ExecuteReader();

                if (leer.Read())
                {
                    string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                    variables.fecha_consulta = fecha_consulta_1;

                    string consulta_posicion = Convert.ToString(leer["posicion"]);
                    variables.posicion_consulta = consulta_posicion;

                    string consulta_destino = Convert.ToString(leer["destino"]);
                    variables.destino_consulta = consulta_destino;

                    if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                    {
                        MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        dos.Checked = false;
                    }
                }

                con.Close();
            }
        }

        private void tres_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.tres.Checked == true)
                {
                    dia_seleccionado = "03";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;

                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            tres.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cuatro_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cuatro.Checked == true)
                {
                    dia_seleccionado = "04";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            cuatro.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cinco_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cinco.Checked == true)
                {
                    dia_seleccionado = "05";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            cinco.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seis_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.seis.Checked == true)
                {
                    dia_seleccionado = "06";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            seis.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void siete_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.siete.Checked == true)
                {
                    dia_seleccionado = "07";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            siete.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ocho_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.ocho.Checked == true)
                {
                    dia_seleccionado = "08";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            ocho.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nueve_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.nueve.Checked == true)
                {
                    dia_seleccionado = "09";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            nueve.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void diez_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.diez.Checked == true)
                {
                    dia_seleccionado = "10";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            diez.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void once_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.once.Checked == true)
                {
                    dia_seleccionado = "11";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            once.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void doce_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.doce.Checked == true)
                {
                    dia_seleccionado = "12";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            doce.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trece_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.trece.Checked == true)
                {
                    dia_seleccionado = "13";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            trece.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void catorce_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.catorce.Checked == true)
                {
                    dia_seleccionado = "14";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            catorce.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quince_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.quince.Checked == true)
                {
                    dia_seleccionado = "15";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            quince.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dieciseis_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dieciseis.Checked == true)
                {
                    dia_seleccionado = "16";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            dieciseis.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void diecisiete_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.diecisiete.Checked == true)
                {
                    dia_seleccionado = "17";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            diecisiete.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dieciocho_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dieciocho.Checked == true)
                {
                    dia_seleccionado = "18";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            dieciocho.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void diecinueve_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.diecinueve.Checked == true)
                {
                    dia_seleccionado = "19";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            diecinueve.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veinte_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.veinte.Checked == true)
                {
                    dia_seleccionado = "20";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            veinte.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veitiuno_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.veitiuno.Checked == true)
                {
                    dia_seleccionado = "21";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            veitiuno.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veintidos_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.veintidos.Checked == true)
                {
                    dia_seleccionado = "22";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            veintidos.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veititres_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.veititres.Checked == true)
                {
                    dia_seleccionado = "23";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            veititres.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veiticuatro_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.veiticuatro.Checked == true)
                {
                    dia_seleccionado = "24";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            veiticuatro.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veiticinco_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.veiticinco.Checked == true)
                {
                    dia_seleccionado = "25";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            veiticinco.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veitiseis_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.veitiseis.Checked == true)
                {
                    dia_seleccionado = "26";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            veitiseis.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veitisiete_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.veitisiete.Checked == true)
                {
                    dia_seleccionado = "27";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            veitisiete.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veitiocho_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.veitiocho.Checked == true)
                {
                    dia_seleccionado = "28";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            veitiocho.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void veitinueve_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.veitinueve.Checked == true)
                {
                    dia_seleccionado = "29";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            veitinueve.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void destino_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                calendar_sort_bd.Refresh();

                List<SpecialDate> SpecialDates = new List<SpecialDate>();

                con.Open();
                string sql = "SELECT * FROM sort_orders_paquetes_liverp WHERE posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fecha_evento = Convert.ToString(reader["fecha_inicio"]);

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

                calendar_sort_bd.SpecialDates = SpecialDates;

                con.Close();
            }
            catch
            {

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            uno.Checked = true;
            dos.Checked = true;
            tres.Checked = true;
            cuatro.Checked = true;
            cinco.Checked = true;
            seis.Checked = true;
            siete.Checked = true;
            ocho.Checked = true;
            nueve.Checked = true;
            diez.Checked = true;
            once.Checked = true;
            doce.Checked = true;
            trece.Checked = true;
            catorce.Checked = true;
            quince.Checked = true;
            dieciseis.Checked = true;
            diecisiete.Checked = true;
            dieciocho.Checked = true;
            diecinueve.Checked = true;
            veinte.Checked = true;
            veitiuno.Checked = true;
            veintidos.Checked = true;
            veititres.Checked = true;
            veiticuatro.Checked = true;
            veiticinco.Checked = true;
            veitiseis.Checked = true;
            veitisiete.Checked = true;
            veitiocho.Checked = true;
            veitinueve.Checked = true;
            treinta.Checked = true;

            if (comboMeses.SelectedIndex == 3 || comboMeses.SelectedIndex == 5 || comboMeses.SelectedIndex == 8 || comboMeses.SelectedIndex == 10 || comboMeses.SelectedIndex == 1 && comboAnio.SelectedIndex == 1)
            {
                treintauno.Checked = false;
            }
            else
            {
                treintauno.Checked = true;
            }
        }

        private void no_select_Click(object sender, EventArgs e)
        {
            uno.Checked = false;
            dos.Checked = false;
            tres.Checked = false;
            cuatro.Checked = false;
            cinco.Checked = false;
            seis.Checked = false;
            siete.Checked = false;
            ocho.Checked = false;
            nueve.Checked = false;
            diez.Checked = false;
            once.Checked = false;
            doce.Checked = false;
            trece.Checked = false;
            catorce.Checked = false;
            quince.Checked = false;
            dieciseis.Checked = false;
            diecisiete.Checked = false;
            dieciocho.Checked = false;
            diecinueve.Checked = false;
            veinte.Checked = false;
            veitiuno.Checked = false;
            veintidos.Checked = false;
            veititres.Checked = false;
            veiticuatro.Checked = false;
            veiticinco.Checked = false;
            veitiseis.Checked = false;
            veitisiete.Checked = false;
            veitiocho.Checked = false;
            veitinueve.Checked = false;
            treinta.Checked = false;
            treintauno.Checked = false;
        }

        private void treinta_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.treinta.Checked == true)
                {
                    dia_seleccionado = "30";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            treinta.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treintauno_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.treintauno.Checked == true)
                {
                    dia_seleccionado = "31";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sort_orders_paquetes_liverp WHERE fecha_inicio='" + fecha_final + "'AND posicion='" + posicion_combo.Text + "'AND destino='" + destino_combo.Text + "' ", con);
                    MySqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(leer["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(leer["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(leer["destino"]);
                        variables.destino_consulta = consulta_destino;



                        if (variables.fecha_consulta == fecha_consulta_1 && variables.posicion_consulta == consulta_posicion && variables.destino_consulta == consulta_destino)
                        {
                            MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            treintauno.Checked = false;
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public void selected_days()
        {
            int cant_dias = 0;

            if (uno.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (dos.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (tres.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (cuatro.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (cinco.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (seis.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (siete.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (ocho.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (nueve.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (diez.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (once.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (doce.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (trece.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (catorce.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (quince.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (dieciseis.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (diecisiete.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (dieciocho.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (diecinueve.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (veinte.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (veitiuno.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (veintidos.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (veititres.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (veiticuatro.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (veiticinco.Checked == true)
            {
                cant_dias = cant_dias + 1;

            }

            if (veitiseis.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (veitisiete.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (veitiocho.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (veitinueve.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (treinta.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }

            if (treintauno.Checked == true)
            {
                cant_dias = cant_dias + 1;
            }
        }

        public void days()
        {
            if (uno.Checked == true)
            {
                dia_seleccionado = "01";
            }

            if (dos.Checked == true)
            {
                dia_seleccionado = "02";
            }

            if (tres.Checked == true)
            {
                dia_seleccionado = "03";
            }

            if (cuatro.Checked == true)
            {
                dia_seleccionado = "04";
            }

            if (cinco.Checked == true)
            {
                dia_seleccionado = "05";
            }

            if (seis.Checked == true)
            {
                dia_seleccionado = "06";
            }

            if (siete.Checked == true)
            {
                dia_seleccionado = "07";
            }

            if (ocho.Checked == true)
            {
                dia_seleccionado = "08";
            }

            if (nueve.Checked == true)
            {
                dia_seleccionado = "09";
            }

            if (diez.Checked == true)
            {
                dia_seleccionado = "10";
            }

            if (once.Checked == true)
            {
                dia_seleccionado = "11";
            }

            if (doce.Checked == true)
            {
                dia_seleccionado = "12";
            }

            if (trece.Checked == true)
            {
                dia_seleccionado = "13";
            }

            if (catorce.Checked == true)
            {
                dia_seleccionado = "14";
            }

            if (quince.Checked == true)
            {
                dia_seleccionado = "15";
            }

            if (dieciseis.Checked == true)
            {
                dia_seleccionado = "16";
            }

            if (diecisiete.Checked == true)
            {
                dia_seleccionado = "17";
            }

            if (dieciocho.Checked == true)
            {
                dia_seleccionado = "18";
            }

            if (diecinueve.Checked == true)
            {
                dia_seleccionado = "19";
            }

            if (veinte.Checked == true)
            {
                dia_seleccionado = "20";
            }

            if (veitiuno.Checked == true)
            {
                dia_seleccionado = "21";
            }

            if (veintidos.Checked == true)
            {
                dia_seleccionado = "22";
            }

            if (veititres.Checked == true)
            {
                dia_seleccionado = "23";
            }

            if (veiticuatro.Checked == true)
            {
                dia_seleccionado = "24";
            }

            if (veiticinco.Checked == true)
            {
                dia_seleccionado = "25";

            }

            if (veitiseis.Checked == true)
            {
                dia_seleccionado = "26";
            }

            if (veitisiete.Checked == true)
            {
                dia_seleccionado = "27";
            }

            if (veitiocho.Checked == true)
            {
                dia_seleccionado = "28";
            }

            if (veitinueve.Checked == true)
            {
                dia_seleccionado = "29";
            }

            if (treinta.Checked == true)
            {
                dia_seleccionado = "30";
            }

            if (treintauno.Checked == true)
            {
                dia_seleccionado = "31";
            }
        }

        public void month()
        {
            if (comboMeses.SelectedIndex == 0)
            {
                mes_seleccionado = "01";
            }

            if (comboMeses.SelectedIndex == 1)
            {
                mes_seleccionado = "02";
            }

            if (comboMeses.SelectedIndex == 2)
            {
                mes_seleccionado = "03";
            }

            if (comboMeses.SelectedIndex == 3)
            {
                mes_seleccionado = "04";
            }

            if (comboMeses.SelectedIndex == 4)
            {
                mes_seleccionado = "05";
            }

            if (comboMeses.SelectedIndex == 5)
            {
                mes_seleccionado = "06";
            }

            if (comboMeses.SelectedIndex == 6)
            {
                mes_seleccionado = "07";
            }

            if (comboMeses.SelectedIndex == 7)
            {
                mes_seleccionado = "08";
            }

            if (comboMeses.SelectedIndex == 8)
            {
                mes_seleccionado = "09";
            }

            if (comboMeses.SelectedIndex == 9)
            {
                mes_seleccionado = "10";
            }

            if (comboMeses.SelectedIndex == 10)
            {
                mes_seleccionado = "11";
            }

            if (comboMeses.SelectedIndex == 11)
            {
                mes_seleccionado = "12";
            }
        }

        public void year()
        {
            if (comboAnio.SelectedIndex == 0)
            {
                anio_seleccionado = "2019";
            }

            if (comboAnio.SelectedIndex == 1)
            {
                anio_seleccionado = "2020";
            }

            if (comboAnio.SelectedIndex == 2)
            {
                anio_seleccionado = "2021";
            }

            if (comboAnio.SelectedIndex == 3)
            {
                anio_seleccionado = "2022";
            }

            if (comboAnio.SelectedIndex == 4)
            {
                anio_seleccionado = "2023";
            }

            if (comboAnio.SelectedIndex == 5)
            {
                anio_seleccionado = "2024";
            }

            if (comboAnio.SelectedIndex == 6)
            {
                anio_seleccionado = "2025";
            }

            if (comboAnio.SelectedIndex == 7)
            {
                anio_seleccionado = "2026";
            }

            if (comboAnio.SelectedIndex == 8)
            {
                anio_seleccionado = "2027";
            }

            if (comboAnio.SelectedIndex == 9)
            {
                anio_seleccionado = "2028";
            }

            if (comboAnio.SelectedIndex == 10)
            {
                anio_seleccionado = "2029";
            }

            if (comboAnio.SelectedIndex == 11)
            {
                anio_seleccionado = "2030";
            }
        }

        public void verificar_dispo()
        {
            try
            {
                con.Close();

                con.Open();

                if (uno.Checked == true)
                {
                    dia_seleccionado = "01";

                    month();
                    year();

                    fecha_final = anio_seleccionado + "-" + mes_seleccionado + "-" + dia_seleccionado;

                    string sql = "SELECT fecha, posicion, destino FROM sort_orders_paquetes_liverp where fecha_inicio = '" + fecha_final + "' and posicion = '" + posicion_combo.Text + "' and destino = '" + destino_combo.Text + "'";
                    MySqlCommand conslta = new MySqlCommand(sql, con);
                    MySqlDataReader reader = conslta.ExecuteReader();
                    if (reader.Read())
                    {
                        string fecha_consulta_1 = Convert.ToString(reader["fecha_inicio"]);
                        variables.fecha_consulta = fecha_consulta_1;

                        string consulta_posicion = Convert.ToString(reader["posicion"]);
                        variables.posicion_consulta = consulta_posicion;

                        string consulta_destino = Convert.ToString(reader["destino"]);
                        variables.destino_consulta = consulta_destino;

                        MessageBox.Show(Convert.ToString(fecha_consulta), "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();

                    if (variables.fecha_consulta == fecha_final && variables.posicion_consulta == posicion_combo.Text && variables.destino_consulta == destino_combo.Text)
                    {
                        MessageBox.Show("Fecha y posición ocupada en el destino seleccionado!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {

                    }
                }
            }

            catch
            {

            }
        }

        public void carga_fechas()
        {
            try
            {
                if (posicion_combo.SelectedIndex == 0)
                {
                    string posicion_selected = "Primera";
                    con.Close();

                    calendar_sort_bd.Refresh();

                    List<SpecialDate> SpecialDates = new List<SpecialDate>();

                    con.Open();
                    string sql = "SELECT * FROM sort_orders_paquetes_liverp WHERE posicion='" + posicion_selected + "'AND destino='" + destino_combo.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fecha_evento = Convert.ToString(reader["fecha_inicio"]);

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

                    calendar_sort_bd.SpecialDates = SpecialDates;

                    con.Close();
                }

                else if (posicion_combo.SelectedIndex == 1)
                {
                    string posicion_selected = "Segunda";
                    con.Close();

                    calendar_sort_bd.Refresh();

                    List<SpecialDate> SpecialDates = new List<SpecialDate>();

                    con.Open();
                    string sql = "SELECT * FROM sort_orders_paquetes_liverp WHERE posicion='" + posicion_selected + "'AND destino='" + destino_combo.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fecha_evento = Convert.ToString(reader["fecha_inicio"]);

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

                    calendar_sort_bd.SpecialDates = SpecialDates;

                    con.Close();
                }

                else if (posicion_combo.SelectedIndex == 2)
                {
                    string posicion_selected = "Tercera";
                    con.Close();

                    calendar_sort_bd.Refresh();

                    List<SpecialDate> SpecialDates = new List<SpecialDate>();

                    con.Open();
                    string sql = "SELECT * FROM sort_orders_paquetes_liverp WHERE posicion='" + posicion_selected + "'AND destino='" + destino_combo.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        fecha_evento = Convert.ToString(reader["fecha_inicio"]);

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

                    calendar_sort_bd.SpecialDates = SpecialDates;

                    con.Close();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
