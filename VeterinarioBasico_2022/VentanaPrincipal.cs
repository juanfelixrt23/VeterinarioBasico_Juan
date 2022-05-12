using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;


namespace VeterinarioBasico_2022
{
    public partial class VentanaPrincipal : Form
    {

       
        Conexion conexion = new Conexion();
        

        public VentanaPrincipal()
        {
            InitializeComponent();
            insertaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            insertaCita.FlatAppearance.BorderSize = 0;
            insertaCita.FlatAppearance.MouseDownBackColor = Color.Transparent;
            insertaCita.FlatAppearance.MouseOverBackColor = Color.Transparent;
            insertaCita.BackColor = Color.Transparent;

            

            insertaMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            insertaMascota.FlatAppearance.BorderSize = 0;
            insertaMascota.FlatAppearance.MouseDownBackColor = Color.Transparent;
            insertaMascota.FlatAppearance.MouseOverBackColor = Color.Transparent;
            insertaMascota.BackColor = Color.Transparent;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        //Al cerrar la segunda pestaña de ventana principal se para la ejecución del programa. 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            else
            {
                Application.Exit();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaMascota(textBoxChip.Text, textBoxNombrem.Text, textBoxDueño.Text, textBoxAnimal.Text));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           conexion.buscarUsuario("");
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
                string busquedaU = textBox1.Text.ToString();
                conexion.buscarUsuario(busquedaU);
                dataGridView1.DataSource = conexion.buscarUsuario(busquedaU);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string busquedaM = textBox2.Text.ToString();
            conexion.buscarMascota(busquedaM);
            dataGridView2.DataSource = conexion.buscarMascota(busquedaM);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaCita(textBoxDia.Text, textBoxHora.Text, textBoxMotivo.Text, textBoxMascota.Text));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string busquedaC = textBox3.Text.ToString();
            conexion.buscarCita(busquedaC);
            dataGridView3.DataSource = conexion.buscarCita(busquedaC);
        }
    }
}
