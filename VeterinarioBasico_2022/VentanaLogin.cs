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
            registrarte2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            registrarte2.FlatAppearance.BorderSize = 0;
            registrarte2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            registrarte2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            registrarte2.BackColor = Color.Transparent;
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

        private void registrarte_Click(object sender, EventArgs e)
        {
            VentanaRegistrar r = new VentanaRegistrar();
            r.Show();
        }
    }
}
