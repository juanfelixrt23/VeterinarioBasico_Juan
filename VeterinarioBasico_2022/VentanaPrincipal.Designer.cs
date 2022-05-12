
namespace VeterinarioBasico_2022
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxDueño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.insertaMascota = new System.Windows.Forms.Button();
            this.textBoxAnimal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNombrem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxChip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.textBoxMascota = new System.Windows.Forms.TextBox();
            this.textBoxDia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Dia = new System.Windows.Forms.Label();
            this.insertaCita = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.veterinarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinarioDataSet = new VeterinarioBasico_2022.veterinarioDataSet();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1424, 794);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::VeterinarioBasico_2022.Properties.Resources.background_fondo_veterinaria_el_toro_pet_shop_colombia;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.textBoxDueño);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.insertaMascota);
            this.tabPage1.Controls.Add(this.textBoxAnimal);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxNombrem);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBoxChip);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1416, 748);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar Datos";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxDueño
            // 
            this.textBoxDueño.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDueño.Location = new System.Drawing.Point(553, 311);
            this.textBoxDueño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDueño.Name = "textBoxDueño";
            this.textBoxDueño.Size = new System.Drawing.Size(350, 28);
            this.textBoxDueño.TabIndex = 21;
            this.textBoxDueño.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(465, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Dueño";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // insertaMascota
            // 
            this.insertaMascota.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insertaMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertaMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertaMascota.Image = ((System.Drawing.Image)(resources.GetObject("insertaMascota.Image")));
            this.insertaMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertaMascota.Location = new System.Drawing.Point(553, 461);
            this.insertaMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertaMascota.Name = "insertaMascota";
            this.insertaMascota.Size = new System.Drawing.Size(315, 87);
            this.insertaMascota.TabIndex = 17;
            this.insertaMascota.Text = "Inserta Mascota";
            this.insertaMascota.UseVisualStyleBackColor = false;
            this.insertaMascota.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAnimal
            // 
            this.textBoxAnimal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAnimal.Location = new System.Drawing.Point(553, 348);
            this.textBoxAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAnimal.Name = "textBoxAnimal";
            this.textBoxAnimal.Size = new System.Drawing.Size(350, 28);
            this.textBoxAnimal.TabIndex = 16;
            this.textBoxAnimal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Animal";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxNombrem
            // 
            this.textBoxNombrem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNombrem.Location = new System.Drawing.Point(553, 279);
            this.textBoxNombrem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombrem.Name = "textBoxNombrem";
            this.textBoxNombrem.Size = new System.Drawing.Size(350, 28);
            this.textBoxNombrem.TabIndex = 14;
            this.textBoxNombrem.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(467, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxChip
            // 
            this.textBoxChip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxChip.Location = new System.Drawing.Point(553, 239);
            this.textBoxChip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxChip.Name = "textBoxChip";
            this.textBoxChip.Size = new System.Drawing.Size(350, 28);
            this.textBoxChip.TabIndex = 12;
            this.textBoxChip.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(467, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Chip";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::VeterinarioBasico_2022.Properties.Resources.titulo_nido_Mesa_de_trabajo_1_scaled;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.ImageIndex = 4;
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1416, 748);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscador";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 58);
            this.label3.TabIndex = 11;
            this.label3.Text = "Buscador de Citas:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 58);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscador de Mascotas:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscador de Usuarios:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(834, 552);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(359, 559);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(433, 22);
            this.textBox3.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(347, 613);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(608, 99);
            this.dataGridView3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 311);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(433, 22);
            this.textBox2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(363, 357);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(608, 97);
            this.dataGridView2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(843, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 94);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(709, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::VeterinarioBasico_2022.Properties.Resources._727f506f9aabd7bb12e0a443d3536317;
            this.tabPage3.Controls.Add(this.textBoxHora);
            this.tabPage3.Controls.Add(this.textBoxMotivo);
            this.tabPage3.Controls.Add(this.textBoxMascota);
            this.tabPage3.Controls.Add(this.textBoxDia);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.Dia);
            this.tabPage3.Controls.Add(this.insertaCita);
            this.tabPage3.ForeColor = System.Drawing.Color.DarkRed;
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1416, 748);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Citas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxHora
            // 
            this.textBoxHora.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxHora.Location = new System.Drawing.Point(972, 314);
            this.textBoxHora.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(183, 22);
            this.textBoxHora.TabIndex = 8;
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxMotivo.Location = new System.Drawing.Point(441, 395);
            this.textBoxMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(183, 22);
            this.textBoxMotivo.TabIndex = 7;
            // 
            // textBoxMascota
            // 
            this.textBoxMascota.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxMascota.Location = new System.Drawing.Point(972, 396);
            this.textBoxMascota.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMascota.Name = "textBoxMascota";
            this.textBoxMascota.Size = new System.Drawing.Size(183, 22);
            this.textBoxMascota.TabIndex = 6;
            // 
            // textBoxDia
            // 
            this.textBoxDia.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDia.Location = new System.Drawing.Point(441, 314);
            this.textBoxDia.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDia.Name = "textBoxDia";
            this.textBoxDia.Size = new System.Drawing.Size(183, 22);
            this.textBoxDia.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(825, 302);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 36);
            this.label12.TabIndex = 4;
            this.label12.Text = "Hora";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(302, 383);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 36);
            this.label11.TabIndex = 3;
            this.label11.Text = "Motivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(801, 387);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 36);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mascota";
            // 
            // Dia
            // 
            this.Dia.AutoSize = true;
            this.Dia.BackColor = System.Drawing.Color.Transparent;
            this.Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia.ForeColor = System.Drawing.Color.DarkRed;
            this.Dia.Location = new System.Drawing.Point(324, 302);
            this.Dia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(62, 36);
            this.Dia.TabIndex = 1;
            this.Dia.Text = "Dia";
            // 
            // insertaCita
            // 
            this.insertaCita.BackColor = System.Drawing.Color.Transparent;
            this.insertaCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertaCita.Image = ((System.Drawing.Image)(resources.GetObject("insertaCita.Image")));
            this.insertaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertaCita.Location = new System.Drawing.Point(579, 542);
            this.insertaCita.Margin = new System.Windows.Forms.Padding(4);
            this.insertaCita.Name = "insertaCita";
            this.insertaCita.Size = new System.Drawing.Size(289, 121);
            this.insertaCita.TabIndex = 0;
            this.insertaCita.Text = "Añadir Cita";
            this.insertaCita.UseVisualStyleBackColor = false;
            this.insertaCita.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_computer.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_elephant.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_foul.ico");
            this.imageList1.Images.SetKeyName(3, "icons8_steve_jobs.ico");
            this.imageList1.Images.SetKeyName(4, "icons8_search.ico");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // veterinarioDataSetBindingSource
            // 
            this.veterinarioDataSetBindingSource.DataSource = this.veterinarioDataSet;
            this.veterinarioDataSetBindingSource.Position = 0;
            // 
            // veterinarioDataSet
            // 
            this.veterinarioDataSet.DataSetName = "veterinarioDataSet";
            this.veterinarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 794);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource veterinarioDataSetBindingSource;
        private veterinarioDataSet veterinarioDataSet;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox textBoxDueño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insertaMascota;
        private System.Windows.Forms.TextBox textBoxAnimal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNombrem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxChip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Dia;
        private System.Windows.Forms.Button insertaCita;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.TextBox textBoxMascota;
        private System.Windows.Forms.TextBox textBoxDia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

