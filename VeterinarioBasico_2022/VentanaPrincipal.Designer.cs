
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.veterinarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinarioDataSet = new VeterinarioBasico_2022.veterinarioDataSet();
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
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertaUsuario = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
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
            // tabPage1
            // 
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
            this.tabPage1.Controls.Add(this.textBoxApellido);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.insertaUsuario);
            this.tabPage1.Controls.Add(this.textBoxPass);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxDNI);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1416, 748);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxDueño
            // 
            this.textBoxDueño.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDueño.Location = new System.Drawing.Point(798, 287);
            this.textBoxDueño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDueño.Name = "textBoxDueño";
            this.textBoxDueño.Size = new System.Drawing.Size(350, 22);
            this.textBoxDueño.TabIndex = 21;
            this.textBoxDueño.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(726, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
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
            this.insertaMascota.Location = new System.Drawing.Point(814, 439);
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
            this.textBoxAnimal.Location = new System.Drawing.Point(798, 324);
            this.textBoxAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAnimal.Name = "textBoxAnimal";
            this.textBoxAnimal.Size = new System.Drawing.Size(350, 22);
            this.textBoxAnimal.TabIndex = 16;
            this.textBoxAnimal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(726, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Animal";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxNombrem
            // 
            this.textBoxNombrem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNombrem.Location = new System.Drawing.Point(798, 255);
            this.textBoxNombrem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombrem.Name = "textBoxNombrem";
            this.textBoxNombrem.Size = new System.Drawing.Size(350, 22);
            this.textBoxNombrem.TabIndex = 14;
            this.textBoxNombrem.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(728, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxChip
            // 
            this.textBoxChip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxChip.Location = new System.Drawing.Point(798, 215);
            this.textBoxChip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxChip.Name = "textBoxChip";
            this.textBoxChip.Size = new System.Drawing.Size(350, 22);
            this.textBoxChip.TabIndex = 12;
            this.textBoxChip.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(728, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Chip";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxApellido.Location = new System.Drawing.Point(134, 272);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(319, 22);
            this.textBoxApellido.TabIndex = 10;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEmail.Location = new System.Drawing.Point(134, 347);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(319, 22);
            this.textBoxEmail.TabIndex = 8;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // insertaUsuario
            // 
            this.insertaUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.insertaUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insertaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertaUsuario.Image = ((System.Drawing.Image)(resources.GetObject("insertaUsuario.Image")));
            this.insertaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertaUsuario.Location = new System.Drawing.Point(146, 439);
            this.insertaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertaUsuario.Name = "insertaUsuario";
            this.insertaUsuario.Size = new System.Drawing.Size(297, 87);
            this.insertaUsuario.TabIndex = 6;
            this.insertaUsuario.Text = "Inserta Usuario";
            this.insertaUsuario.UseVisualStyleBackColor = false;
            this.insertaUsuario.Click += new System.EventHandler(this.insertaUsuario_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPass.Location = new System.Drawing.Point(134, 309);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(319, 22);
            this.textBoxPass.TabIndex = 5;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNombre.Location = new System.Drawing.Point(134, 240);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(319, 22);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDNI.Location = new System.Drawing.Point(134, 201);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(319, 22);
            this.textBoxDNI.TabIndex = 1;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::VeterinarioBasico_2022.Properties.Resources.titulo_nido_Mesa_de_trabajo_1_scaled;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 385);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(433, 22);
            this.textBox2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 437);
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
            this.button2.Location = new System.Drawing.Point(496, 380);
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
            this.dataGridView1.Location = new System.Drawing.Point(24, 156);
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
            this.button1.Location = new System.Drawing.Point(496, 114);
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
            this.textBox1.Location = new System.Drawing.Point(24, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::VeterinarioBasico_2022.Properties.Resources.Panorama_Albacora_recibidor_01_B;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.textBoxHora);
            this.tabPage3.Controls.Add(this.textBoxMotivo);
            this.tabPage3.Controls.Add(this.textBoxMascota);
            this.tabPage3.Controls.Add(this.textBoxDia);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.Dia);
            this.tabPage3.Controls.Add(this.insertaCita);
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
            this.textBoxHora.Location = new System.Drawing.Point(925, 302);
            this.textBoxHora.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(183, 22);
            this.textBoxHora.TabIndex = 8;
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxMotivo.Location = new System.Drawing.Point(394, 383);
            this.textBoxMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(183, 22);
            this.textBoxMotivo.TabIndex = 7;
            // 
            // textBoxMascota
            // 
            this.textBoxMascota.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxMascota.Location = new System.Drawing.Point(925, 384);
            this.textBoxMascota.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMascota.Name = "textBoxMascota";
            this.textBoxMascota.Size = new System.Drawing.Size(183, 22);
            this.textBoxMascota.TabIndex = 6;
            // 
            // textBoxDia
            // 
            this.textBoxDia.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDia.Location = new System.Drawing.Point(394, 302);
            this.textBoxDia.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDia.Name = "textBoxDia";
            this.textBoxDia.Size = new System.Drawing.Size(183, 22);
            this.textBoxDia.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(825, 302);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Hora";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(302, 383);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Motivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(801, 387);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mascota";
            // 
            // Dia
            // 
            this.Dia.AutoSize = true;
            this.Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia.Location = new System.Drawing.Point(324, 302);
            this.Dia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(38, 20);
            this.Dia.TabIndex = 1;
            this.Dia.Text = "Dia";
            // 
            // insertaCita
            // 
            this.insertaCita.BackColor = System.Drawing.SystemColors.Info;
            this.insertaCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertaCita.Image = ((System.Drawing.Image)(resources.GetObject("insertaCita.Image")));
            this.insertaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertaCita.Location = new System.Drawing.Point(553, 538);
            this.insertaCita.Margin = new System.Windows.Forms.Padding(4);
            this.insertaCita.Name = "insertaCita";
            this.insertaCita.Size = new System.Drawing.Size(289, 121);
            this.insertaCita.TabIndex = 0;
            this.insertaCita.Text = "Añadir Cita";
            this.insertaCita.UseVisualStyleBackColor = false;
            this.insertaCita.Click += new System.EventHandler(this.button3_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertaUsuario;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
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
    }
}

