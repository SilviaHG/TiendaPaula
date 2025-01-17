﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaPaula.Gestiones;

namespace TiendaPaula.Formularios
{
    public partial class Login : MaterialForm
    {
        //variable estaticas para acceder al nombre y posicion con el cual se loguea
        //el usuario
        public static string NombrePosicion;
        public static string NombreUsuario;
        Gestion_Usuarios bdUsuario = new Gestion_Usuarios();
       Gestion_Usuarios user = new Gestion_Usuarios();
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Color.FromArgb(242, 148, 32),
            Color.FromArgb(45, 48, 71),
            Color.FromArgb(255, 224, 92),//tiene queser parecido al primero
            Color.FromArgb(45, 48, 71),
            TextShade.WHITE);
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {

            await bdUsuario.AbrirConexion(bdUsuario.establecerConexion());

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {


                MessageBox.Show("Usuario y/o contraseña tienen campos vacios",
                "Error de acceso",

                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {


                if (await bdUsuario.Verificar_Usuario_Contra(Convert.ToInt32(txtUsuario.Text), txtPassword.Text) == true)
                {

                    if (CheckboxRemember.Checked)
                    {
                        bdUsuario.RecordarUsuario(new Clases.Class_Recordar_Usuario(txtUsuario.Text, txtPassword.Text));

                        NombrePosicion = await user.MostrarUsuarioIngresadoPosicion(Convert.ToInt32(txtUsuario.Text));
                        NombreUsuario = await user.MostrarUsuarioIngresadoNombre(Convert.ToInt32(txtUsuario.Text));
                       
                        Principal Abrir = new Principal();
                        Abrir.Show();
                        this.Hide();
                    }
                    else
                    {
                        NombrePosicion = await user.MostrarUsuarioIngresadoPosicion(Convert.ToInt32(txtUsuario.Text));
                        NombreUsuario = await user.MostrarUsuarioIngresadoNombre(Convert.ToInt32(txtUsuario.Text));
                       
                        bdUsuario.OlvidarUsuario();
                        Principal Abrir = new Principal();
                        Abrir.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña no existen, intenta de nuevo");
                }
            }
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = await bdUsuario.UsuarioRecordado();
            txtPassword.Text = await bdUsuario.ContrasenniaRecordada();
            await bdUsuario.cerrarConexion(bdUsuario.establecerConexion());
            if (txtUsuario.Text == "")
            {
                CheckboxRemember.Checked = false;
                
            }
            else
            {
                CheckboxRemember.Checked = true;
            }
        }
        private async void CheckboxRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxRemember.Checked)
            {
                txtUsuario.Text = await bdUsuario.UsuarioRecordado();
                txtPassword.Text = await bdUsuario.ContrasenniaRecordada();
                await bdUsuario.cerrarConexion(bdUsuario.establecerConexion());
            }
            else
            {
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            RecuperarContrasennia rc = new RecuperarContrasennia();
            rc.ShowDialog();
        }
    }
}
