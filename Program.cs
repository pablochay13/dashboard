using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard_medios
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new calendar_so_hoteles());

            try
            {
                MySqlConnection con = new MySqlConnection(variables.Sentencia);
                con.Close();
                con.Open();
                string sql = "SELECT usuario, privilegios FROM usuarios WHERE privilegios = 'admin' ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variables.Tipousuario = Convert.ToString(reader["usuario"]);
                    variables.Privilegios = Convert.ToString(reader["privilegios"]);
                    variables.Privilegios = Convert.ToString(reader["privilegios"]);
                    if (variables.Privilegios == "admin")
                    {
                        Application.Run(new login());
                    }
                }
                else if (variables.Privilegios != "admin" || variables.Privilegios != "user")
                {
                    Application.Restart();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
