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
    public partial class take_over_bd_full : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(variables.Sentencia);

        public take_over_bd_full()
        {
            InitializeComponent();

            llenar();
        }

        private void take_over_bd_full_Load(object sender, EventArgs e)
        {

        }

        private void filter_Click(object sender, EventArgs e)
        {
            string sentencia = "";
            string busqueda = "";

            if (cbFechas.Checked == true)
            {
                string inicio = fechaDesde.Value.ToString("yyyy-MM-dd");
                string fin = fechaHasta.Value.ToString("yyyy-MM-dd");
                sentencia = "SELECT * FROM take_over_bd WHERE fecha BETWEEN'" + inicio + "'AND'" + fin + "'";
            }

            if (check_hotel.Checked == true)
            {
                busqueda = hotel_combo.Text;
                sentencia = "SELECT * FROM take_over_bd WHERE hotel LIKE '%" + busqueda + "%'";
            }

            if (check_account.Checked == true)
            {
                busqueda = account_text.Text;
                sentencia = "SELECT * FROM sort_orders_paquetes WHERE account LIKE '%" + busqueda + "%'";
            }

            con.Close();

            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(sentencia, con);
            DataTable dt = new DataTable();
            registros.Rows.Clear();
            registros.Refresh();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = registros.Rows.Add();
                registros.Rows[n].Cells[0].Value = item["id"].ToString();
                registros.Rows[n].Cells[1].Value = item["fecha"].ToString();
                registros.Rows[n].Cells[2].Value = item["hotel"].ToString();
                registros.Rows[n].Cells[3].Value = item["account"].ToString();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
           registros.Rows.RemoveAt(registros.CurrentRow.Index);
        }

        private void export_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        public void llenar()
        {
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM take_over_bd", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = registros.Rows.Add();
                    registros.Rows[n].Cells[0].Value = item["id"].ToString();
                    registros.Rows[n].Cells[1].Value = item["fecha"].ToString();
                    registros.Rows[n].Cells[2].Value = item["hotel"].ToString();
                    registros.Rows[n].Cells[3].Value = item["account"].ToString();
                }
                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void ExportarExcel()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = false;
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Datos";
            for (int i = 1; i < registros.Columns.Count + 1; i++)
            {
                if (i > 1 && i < registros.Columns.Count)
                {
                    worksheet.Cells[1, i] = registros.Columns[i - 1].HeaderText;
                }
            }
            for (int i = 0; i < registros.Rows.Count - 1; i++)
            {
                for (int j = 0; j < registros.Columns.Count; j++)
                {
                    if (j > 0 && j < registros.Columns.Count - 1)
                    {
                        worksheet.Cells[i + 2, j + 1] = registros.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.FileName = "Datos ordenes de inserción";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Console.WriteLine("Ruta en: " + saveFileDialog.FileName);
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }

            MessageBox.Show("Archivo generado", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
