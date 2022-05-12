using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace VeterinarioBasico_2022
{
    public partial class VentanaLogin : Form
    {
        Conexion conexion = new Conexion();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    this.Hide();
        //    VentanaPrincipal v = new VentanaPrincipal();
        //    v.Show();
        if (conexion.loginVeterinario(textBoxDNI.Text, textBoxPass.Text))
        {
        this.Hide();
        VentanaPrincipal v = new VentanaPrincipal();
        v.Show();

        }
        else
        {
            MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS"); 
        }



    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
