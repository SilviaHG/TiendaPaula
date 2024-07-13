using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaPaula.Gestiones;

namespace TiendaPaula.Formularios
{
    public partial class RecuperarContrasennia : MaterialForm
    {
        Gestion_Usuarios gestUsuarios = new Gestion_Usuarios();

        public RecuperarContrasennia()
        {
            InitializeComponent();
        }

        private async void btnRecuperarContra_Click(object sender, EventArgs e)
        {
            int usuario = Convert.ToInt32(txtRecuperarContrasennia.Text);
            if (await gestUsuarios.ExisteUsuario(usuario) == true){
                string correoUser = await gestUsuarios.CorreoUsuario(usuario); //buscamos el correo del empleado
                string contraUser = await gestUsuarios.ContrasenniaUsuario(usuario); //buscamos la contraseña
                string empleado = await gestUsuarios.MostrarUsuarioIngresadoNombre(usuario); // buscamos el nombre del empleado

                await EnviarCorreo(contraUser, correoUser, empleado);
            }
            else
            {
                MessageBox.Show("El usuario ingresado no existe, por favor verifique su usuario e intente nuevamente.");
            }

        }

        private async Task EnviarCorreo(string contrasennia, string correo, string empleado)
        {
            //contraseña es tienda1*
            string miContrasennia = "wainiddtcvmjhvtf"; // esta es la contraseña de aplicacion que creamos desde el gmail
            string mensaje = string.Empty;
            //estreuctura del correo electronico
            string destinario = correo;
            string remitente = "notificacionestiendapaula@gmail.com";
            string asunto = "Recuperación de contraseña, Tienda Paula";
            string cuerpoMensaje = $"Estimado/a {empleado},\r\n\r\n" +
            $"Hemos recibido una solicitud de recuperación de contraseña de su cuenta en Tienda Paula.\r\n\r\n" +
            $"Su contraseña es: {contrasennia}\r\n\r\n" +
            $"Si no solicitó esta información, por favor ignore este correo electrónico o contáctenos " +
            $"inmediatamente al correo {remitente} para asistencia adicional.\r\n\r\n" +
            $"Atentamente,\r\n\r\nEquipo de Soporte de Tienda Paula.";

            MailMessage ms = new MailMessage(remitente, destinario, asunto, cuerpoMensaje);
            
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); 
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("notificacionestiendapaula@gmail.com", miContrasennia);

            lblMensaje.ForeColor = Color.Green;
            lblMensaje.Text = "Esta tarea puede tardar unos minutos, por favor espere...";

            try
            {
                await Task.Run(() =>
                {
                    //enviamos el msj
                    smtp.Send(ms);
                    //liberamos todos lo que estabamos utilizando
                    ms.Dispose();

                    lblMensaje.ForeColor = Color.Green;
                    MessageBox.Show("Correo enviado correctamente, revise su bandeja de entrada");
                   
                });
              }
            catch(Exception ex) 
            {
                MessageBox.Show("Ocurrio un error al tratar de enviar el correo electrónico");

                Console.WriteLine("Error al enviar el correo electronico: "+ ex.Message);
            }
        }
    }
}
