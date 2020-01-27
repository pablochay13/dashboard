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
    public partial class login : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = new MySqlConnection(variables.Sentencia);
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE usuario='" + user.Text + "'AND password='" + password.Text + "' ", con);
            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read())
            {
                MessageBox.Show("Bienvenido " + user.Text + "!", "Best Travel Media", MessageBoxButtons.OK, MessageBoxIcon.Information);
                variables.usuario = user.Text;
                variables.Privilegios = Convert.ToString(leer["privilegios"]);
                variables.Nombre = Convert.ToString(leer["name"]);
                this.Hide();

                main ventana = new main();
                ventana.Show();

                con.Close();
            }
            else
            {
                MessageBox.Show("Error!\n user y/o Contraseña invalido!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
