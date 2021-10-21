using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
                
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.Silver;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.LightGray;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.Silver;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Advertencia",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "USUARIO")
            {
                if (txtcontraseña.Text != "CONTRASEÑA")
                {
                    Modelouser user = new Modelouser();
                    var validaruser = user.Iniciouser(txtusuario.Text, txtcontraseña.Text);
                    if (validaruser == true)
                    {
                        Login principal = new Login();
                        principal.Show();
                        principal.FormClosed += Cerrarsesion;
                        this.Hide();
                    }
                    else Mensajeerror("Usuario o Contraseña incorrectas.  \n Ingresar Usuario y Contraseña Nuevamente");
                    txtcontraseña.Text = "CONTRASEÑA";
                    txtcontraseña.UseSystemPasswordChar = false;

                    txtusuario.Focus();
                }
                else Mensajeerror("Ingresar Contraseña Por Favor");
            }
            else Mensajeerror("Ingresar Usuario Por Favor");
      
        }
        private void Mensajeerror(string mensaje)
        {
            lbmerror.Text = mensaje;
            lbmerror.Visible = true;
        }
        private void Cerrarsesion(object sender, FormClosedEventArgs e)
        {
            txtcontraseña.Text = "CONTRASEÑA";
            txtcontraseña.UseSystemPasswordChar = false;
            txtusuario.Text = "USARIO";
            lbmerror.Visible = false;
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Advertencia",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
    }
}