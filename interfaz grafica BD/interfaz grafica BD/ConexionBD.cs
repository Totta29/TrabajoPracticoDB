using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace interfaz_grafica_BD
{
    public partial class ConexionBD : Form
    {
        public ConexionBD()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string servidor = txtservidor.Text;
            string basededatos = txtbasededatos.Text;
            string puerto = txtpuerto.Text;
            string usuario = txtusuario.Text;
            string contraseña = txtcontra.Text;
            string datos = "";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + contraseña + "; database=" + basededatos + ";";

            MySqlConnection connectionBD = new MySqlConnection(cadenaConexion);

            try
            {
                connectionBD.Open();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show(datos);
            Login mainMenu = new Login();
            mainMenu.Show();
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtservidor_Enter(object sender, EventArgs e)
        {
            if (txtservidor.Text == "SERVIDOR")
            {
                txtservidor.Text = "";
                txtservidor.ForeColor = Color.LightGray;
            }
        }

        private void txtservidor_Leave(object sender, EventArgs e)
        {
            if (txtservidor.Text == "")
            {
                txtservidor.Text = "SERVIDOR";
                txtservidor.ForeColor = Color.DimGray;
            }
        }

        private void txtbasededatos_Enter(object sender, EventArgs e)
        {
            if (txtbasededatos.Text == "BASE DE DATOS")
            {
                txtbasededatos.Text = "";
                txtbasededatos.ForeColor = Color.LightGray;
            }
        }

        private void txtbasededatos_Leave(object sender, EventArgs e)
        {
            if (txtbasededatos.Text == "")
            {
                txtbasededatos.Text = "BASE DE DATOS";
                txtbasededatos.ForeColor = Color.DimGray;
            }
        }

        private void txtpuerto_Enter(object sender, EventArgs e)
        {
            if (txtpuerto.Text == "PUERTO")
            {
                txtpuerto.Text = "";
                txtpuerto.ForeColor = Color.LightGray;
            }
        }

        private void txtpuerto_Leave(object sender, EventArgs e)
        {
            if (txtpuerto.Text == "")
            {
                txtpuerto.Text = "PUERTO";
                txtpuerto.ForeColor = Color.DimGray;
            }
        }

        private void txtusuario_Enter(object sender, EventArgs e)
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
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtcontra_Enter(object sender, EventArgs e)
        {
            if (txtcontra.Text == "CONTRASEÑA")
            {
                txtcontra.Text = "";
                txtcontra.ForeColor = Color.LightGray;
                txtcontra.UseSystemPasswordChar = true;
            }
        }

        private void txtcontra_Leave(object sender, EventArgs e)
        {
            if (txtcontra.Text == "")
            {
                txtcontra.Text = "CONTRASEÑA";
                txtcontra.ForeColor = Color.DimGray;
                txtcontra.UseSystemPasswordChar = false;
            }
        }
    }
}
