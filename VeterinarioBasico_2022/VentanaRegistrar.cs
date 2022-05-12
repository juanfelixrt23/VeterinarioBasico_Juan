using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarioBasico_2022
{
    public partial class VentanaRegistrar : Form
    {
        Conexion conexion = new Conexion();
        public VentanaRegistrar()
        {
            InitializeComponent();

            insertaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            insertaUsuario.FlatAppearance.BorderSize = 0;
            insertaUsuario.FlatAppearance.MouseDownBackColor = Color.Transparent;
            insertaUsuario.FlatAppearance.MouseOverBackColor = Color.Transparent;
            insertaUsuario.BackColor = Color.Transparent;
        }

        private void registrarte_Load(object sender, EventArgs e)
        {

        }
       

        private void insertaUsuario_Click_1(object sender, EventArgs e)
        {
            String textoPassword = textBoxPass.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());
            MessageBox.Show(conexion.insertaUsuario(textBoxDNI.Text, textBoxNombre.Text, textBoxApellido.Text, myHash, textBoxEmail.Text));
            this.Hide();
        }
    }
}
