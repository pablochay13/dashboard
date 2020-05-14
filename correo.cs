using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace dashboard_medios
{
    class correo
    {
        /*
         * Cliente SMTP
         * Gmail:  smtp.gmail.com  puerto:587
         * Hotmail: smtp.liva.com  puerto:25
         */
        SmtpClient server = new SmtpClient("mail.dashboard.ccascarudocun.com", 587);

        public correo()
        {
            server.Credentials = new System.Net.NetworkCredential("dash@dashboard.ccascarudocun.com", "Chay1318");
            server.EnableSsl = true;
        }

        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }
    }
}
