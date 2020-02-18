using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard_medios
{
    class variables
    {
        //private static string sentencia = "server=172.20.3.45;port=3306; database=bd-media; Uid=root; pwd=Medi@@dm1n!!;";
        private static string sentencia = "server=162.241.60.127;database=ccascaru_dasboard_bd;Uid=ccascaru_root;pwd=Chay1318;";

        public static string Sentencia
        {
            get
            {
                return sentencia;
            }

            set
            {
                sentencia = value;
            }
        }

        //Datos Privilegios
        private static string privilegios = "admin", tipousuario = "";

        public static string Tipousuario
        {
            get { return variables.tipousuario; }
            set { variables.tipousuario = value; }
        }

        public static string Privilegios
        {
            get { return variables.privilegios; }
            set { variables.privilegios = value; }
        }

        //Datos Usuarios
        public static string usuario = "", pass = "", nombre = "", puesto = "", email = "", phone = "", ext = "", filename2 = "";

        public static string Filename2
        {
            get { return variables.filename2; }
            set { variables.filename2 = value; }
        }

        public static string Pass
        {
            get { return variables.pass; }
            set { variables.pass = value; }
        }

        public static string Usuario
        {
            get { return variables.usuario; }
            set { variables.usuario = value; }
        }

        public static string Nombre
        {
            get { return variables.nombre; }
            set { variables.nombre = value; }
        }

        public static string Puesto
        {
            get { return variables.puesto; }
            set { variables.puesto = value; }
        }

        public static string Email
        {
            get { return variables.email; }
            set { variables.email = value; }
        }

        public static string Phone
        {
            get { return variables.phone; }
            set { variables.phone = value; }
        }

        public static string Ext
        {
            get { return variables.ext; }
            set { variables.ext = value; }
        }

        public static string fecha_consulta = "", posicion_consulta = "", destino_consulta = "";

        public static string Fecha_consulta
        {
            get { return variables.fecha_consulta; }
            set { variables.fecha_consulta = value; }
        }

        public static string Posicion_consulta
        {
            get { return variables.posicion_consulta; }
            set { variables.posicion_consulta = value; }
        }

        public static string Destino_consulta
        {
            get { return variables.destino_consulta; }
            set { variables.destino_consulta = value; }
        }
    }
}
