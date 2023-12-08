namespace Corzo_01_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvListaPostulantes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clstbVarones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctxtNumPostulantes = new System.Windows.Forms.TextBox();
            this.cVaronesOrdenado = new System.Windows.Forms.ListBox();
            this.cbtnRegistrar = new System.Windows.Forms.Button();
            this.cbtnLimpiar = new System.Windows.Forms.Button();
            this.cbtnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbtnOrdenarMas = new System.Windows.Forms.Button();
            this.cbtnProcesarMas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbtnOrdenarFem = new System.Windows.Forms.Button();
            this.cbtnProcesarFem = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cMujeresOrdenado = new System.Windows.Forms.ListBox();
            this.clstbMujeres = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbtnBuscarFem = new System.Windows.Forms.Button();
            this.cbtnBuscarMas = new System.Windows.Forms.Button();
            this.ctxtFemBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctxtMasBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbtnReporteAdi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPostulantes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPostulantes
            // 
            this.dgvListaPostulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPostulantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvListaPostulantes.Location = new System.Drawing.Point(33, 184);
            this.dgvListaPostulantes.Name = "dgvListaPostulantes";
            this.dgvListaPostulantes.RowTemplate.Height = 25;
            this.dgvListaPostulantes.Size = new System.Drawing.Size(614, 201);
            this.dgvListaPostulantes.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Talla";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Peso";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Edad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Género";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // clstbVarones
            // 
            this.clstbVarones.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clstbVarones.FormattingEnabled = true;
            this.clstbVarones.ItemHeight = 15;
            this.clstbVarones.Location = new System.Drawing.Point(21, 25);
            this.clstbVarones.Name = "clstbVarones";
            this.clstbVarones.Size = new System.Drawing.Size(182, 199);
            this.clstbVarones.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pruebas de Selección de Básquetbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(124, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de Postulantes:";
            // 
            // ctxtNumPostulantes
            // 
            this.ctxtNumPostulantes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctxtNumPostulantes.ForeColor = System.Drawing.Color.Black;
            this.ctxtNumPostulantes.Location = new System.Drawing.Point(353, 121);
            this.ctxtNumPostulantes.Name = "ctxtNumPostulantes";
            this.ctxtNumPostulantes.Size = new System.Drawing.Size(160, 26);
            this.ctxtNumPostulantes.TabIndex = 4;
            // 
            // cVaronesOrdenado
            // 
            this.cVaronesOrdenado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cVaronesOrdenado.FormattingEnabled = true;
            this.cVaronesOrdenado.ItemHeight = 15;
            this.cVaronesOrdenado.Location = new System.Drawing.Point(298, 25);
            this.cVaronesOrdenado.Name = "cVaronesOrdenado";
            this.cVaronesOrdenado.Size = new System.Drawing.Size(182, 199);
            this.cVaronesOrdenado.TabIndex = 5;
            // 
            // cbtnRegistrar
            // 
            this.cbtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbtnRegistrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.cbtnRegistrar.Location = new System.Drawing.Point(411, 149);
            this.cbtnRegistrar.Name = "cbtnRegistrar";
            this.cbtnRegistrar.Size = new System.Drawing.Size(122, 29);
            this.cbtnRegistrar.TabIndex = 6;
            this.cbtnRegistrar.Text = "Registrar";
            this.cbtnRegistrar.UseVisualStyleBackColor = false;
            this.cbtnRegistrar.Click += new System.EventHandler(this.cbtnRegistrar_Click);
            // 
            // cbtnLimpiar
            // 
            this.cbtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbtnLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.cbtnLimpiar.Location = new System.Drawing.Point(72, 415);
            this.cbtnLimpiar.Name = "cbtnLimpiar";
            this.cbtnLimpiar.Size = new System.Drawing.Size(151, 35);
            this.cbtnLimpiar.TabIndex = 8;
            this.cbtnLimpiar.Text = "Limpiar";
            this.cbtnLimpiar.UseVisualStyleBackColor = false;
            this.cbtnLimpiar.Click += new System.EventHandler(this.cbtnLimpiar_Click);
            // 
            // cbtnSalir
            // 
            this.cbtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbtnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnSalir.ForeColor = System.Drawing.Color.Black;
            this.cbtnSalir.Location = new System.Drawing.Point(436, 415);
            this.cbtnSalir.Name = "cbtnSalir";
            this.cbtnSalir.Size = new System.Drawing.Size(151, 35);
            this.cbtnSalir.TabIndex = 9;
            this.cbtnSalir.Text = "Salir";
            this.cbtnSalir.UseVisualStyleBackColor = false;
            this.cbtnSalir.Click += new System.EventHandler(this.cbtnSalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(687, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 370);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbtnOrdenarMas);
            this.tabPage1.Controls.Add(this.cbtnProcesarMas);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cVaronesOrdenado);
            this.tabPage1.Controls.Add(this.clstbVarones);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(525, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Masculino";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbtnOrdenarMas
            // 
            this.cbtnOrdenarMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbtnOrdenarMas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnOrdenarMas.ForeColor = System.Drawing.Color.Black;
            this.cbtnOrdenarMas.Location = new System.Drawing.Point(309, 248);
            this.cbtnOrdenarMas.Name = "cbtnOrdenarMas";
            this.cbtnOrdenarMas.Size = new System.Drawing.Size(162, 53);
            this.cbtnOrdenarMas.TabIndex = 9;
            this.cbtnOrdenarMas.Text = "Ordenar Alfabeticamente";
            this.cbtnOrdenarMas.UseVisualStyleBackColor = false;
            this.cbtnOrdenarMas.Click += new System.EventHandler(this.cbtnOrdenarMas_Click);
            // 
            // cbtnProcesarMas
            // 
            this.cbtnProcesarMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbtnProcesarMas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnProcesarMas.ForeColor = System.Drawing.Color.Black;
            this.cbtnProcesarMas.Location = new System.Drawing.Point(37, 248);
            this.cbtnProcesarMas.Name = "cbtnProcesarMas";
            this.cbtnProcesarMas.Size = new System.Drawing.Size(162, 53);
            this.cbtnProcesarMas.TabIndex = 8;
            this.cbtnProcesarMas.Text = "Procesar Seleccionados";
            this.cbtnProcesarMas.UseVisualStyleBackColor = false;
            this.cbtnProcesarMas.Click += new System.EventHandler(this.cbtnProcesarMas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 39);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(209, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ordenando";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbtnOrdenarFem);
            this.tabPage2.Controls.Add(this.cbtnProcesarFem);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cMujeresOrdenado);
            this.tabPage2.Controls.Add(this.clstbMujeres);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Femenino";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbtnOrdenarFem
            // 
            this.cbtnOrdenarFem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbtnOrdenarFem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnOrdenarFem.ForeColor = System.Drawing.Color.Black;
            this.cbtnOrdenarFem.Location = new System.Drawing.Point(314, 248);
            this.cbtnOrdenarFem.Name = "cbtnOrdenarFem";
            this.cbtnOrdenarFem.Size = new System.Drawing.Size(162, 53);
            this.cbtnOrdenarFem.TabIndex = 15;
            this.cbtnOrdenarFem.Text = "Ordenar Alfabeticamente";
            this.cbtnOrdenarFem.UseVisualStyleBackColor = false;
            this.cbtnOrdenarFem.Click += new System.EventHandler(this.cbtnOrdenarFem_Click);
            // 
            // cbtnProcesarFem
            // 
            this.cbtnProcesarFem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbtnProcesarFem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnProcesarFem.ForeColor = System.Drawing.Color.Black;
            this.cbtnProcesarFem.Location = new System.Drawing.Point(42, 248);
            this.cbtnProcesarFem.Name = "cbtnProcesarFem";
            this.cbtnProcesarFem.Size = new System.Drawing.Size(162, 53);
            this.cbtnProcesarFem.TabIndex = 14;
            this.cbtnProcesarFem.Text = "Procesar Seleccionados";
            this.cbtnProcesarFem.UseVisualStyleBackColor = false;
            this.cbtnProcesarFem.Click += new System.EventHandler(this.cbtnProcesarFem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(214, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 39);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(214, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ordenando";
            // 
            // cMujeresOrdenado
            // 
            this.cMujeresOrdenado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cMujeresOrdenado.FormattingEnabled = true;
            this.cMujeresOrdenado.ItemHeight = 15;
            this.cMujeresOrdenado.Location = new System.Drawing.Point(303, 25);
            this.cMujeresOrdenado.Name = "cMujeresOrdenado";
            this.cMujeresOrdenado.Size = new System.Drawing.Size(182, 199);
            this.cMujeresOrdenado.TabIndex = 11;
            // 
            // clstbMujeres
            // 
            this.clstbMujeres.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clstbMujeres.FormattingEnabled = true;
            this.clstbMujeres.ItemHeight = 15;
            this.clstbMujeres.Location = new System.Drawing.Point(26, 25);
            this.clstbMujeres.Name = "clstbMujeres";
            this.clstbMujeres.Size = new System.Drawing.Size(182, 199);
            this.clstbMujeres.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbtnBuscarFem);
            this.tabPage3.Controls.Add(this.cbtnBuscarMas);
            this.tabPage3.Controls.Add(this.ctxtFemBuscar);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.ctxtMasBuscar);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(525, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Búsqueda Binaria - Masculino y Femenino";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbtnBuscarFem
            // 
            this.cbtnBuscarFem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbtnBuscarFem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnBuscarFem.ForeColor = System.Drawing.Color.Black;
            this.cbtnBuscarFem.Location = new System.Drawing.Point(194, 227);
            this.cbtnBuscarFem.Name = "cbtnBuscarFem";
            this.cbtnBuscarFem.Size = new System.Drawing.Size(187, 36);
            this.cbtnBuscarFem.TabIndex = 5;
            this.cbtnBuscarFem.Text = "Buscar-Femenino";
            this.cbtnBuscarFem.UseVisualStyleBackColor = false;
            this.cbtnBuscarFem.Click += new System.EventHandler(this.cbtnBuscarFem_Click);
            // 
            // cbtnBuscarMas
            // 
            this.cbtnBuscarMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbtnBuscarMas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnBuscarMas.ForeColor = System.Drawing.Color.Black;
            this.cbtnBuscarMas.Location = new System.Drawing.Point(194, 103);
            this.cbtnBuscarMas.Name = "cbtnBuscarMas";
            this.cbtnBuscarMas.Size = new System.Drawing.Size(187, 36);
            this.cbtnBuscarMas.TabIndex = 4;
            this.cbtnBuscarMas.Text = "Buscar-Masculino";
            this.cbtnBuscarMas.UseVisualStyleBackColor = false;
            this.cbtnBuscarMas.Click += new System.EventHandler(this.cbtnBuscarMas_Click);
            // 
            // ctxtFemBuscar
            // 
            this.ctxtFemBuscar.Location = new System.Drawing.Point(194, 181);
            this.ctxtFemBuscar.Name = "ctxtFemBuscar";
            this.ctxtFemBuscar.Size = new System.Drawing.Size(179, 22);
            this.ctxtFemBuscar.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Femenino- Buscar : ";
            // 
            // ctxtMasBuscar
            // 
            this.ctxtMasBuscar.Location = new System.Drawing.Point(194, 51);
            this.ctxtMasBuscar.Name = "ctxtMasBuscar";
            this.ctxtMasBuscar.Size = new System.Drawing.Size(179, 22);
            this.ctxtMasBuscar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Masculino- Buscar : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbtnReporteAdi
            // 
            this.cbtnReporteAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnReporteAdi.Location = new System.Drawing.Point(33, 501);
            this.cbtnReporteAdi.Name = "cbtnReporteAdi";
            this.cbtnReporteAdi.Size = new System.Drawing.Size(202, 40);
            this.cbtnReporteAdi.TabIndex = 11;
            this.cbtnReporteAdi.Text = "Reporte Adicional";
            this.cbtnReporteAdi.UseVisualStyleBackColor = true;
            this.cbtnReporteAdi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1270, 579);
            this.Controls.Add(this.cbtnReporteAdi);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbtnSalir);
            this.Controls.Add(this.cbtnLimpiar);
            this.Controls.Add(this.cbtnRegistrar);
            this.Controls.Add(this.ctxtNumPostulantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaPostulantes);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPostulantes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvListaPostulantes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ListBox clstbVarones;
        private Label label1;
        private Label label2;
        private TextBox ctxtNumPostulantes;
        private ListBox cVaronesOrdenado;
        private Button cbtnRegistrar;
        private Button cbtnLimpiar;
        private Button cbtnSalir;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button cbtnOrdenarMas;
        private Button cbtnProcesarMas;
        private PictureBox pictureBox1;
        private Label label3;
        private TabPage tabPage2;
        private Button cbtnOrdenarFem;
        private Button cbtnProcesarFem;
        private PictureBox pictureBox2;
        private Label label4;
        private ListBox cMujeresOrdenado;
        private ListBox clstbMujeres;
        private TabPage tabPage3;
        private Button cbtnBuscarFem;
        private Button cbtnBuscarMas;
        private TextBox ctxtFemBuscar;
        private Label label6;
        private TextBox ctxtMasBuscar;
        private Label label5;
        private ErrorProvider errorProvider1;
        private Button cbtnReporteAdi;
    }
}