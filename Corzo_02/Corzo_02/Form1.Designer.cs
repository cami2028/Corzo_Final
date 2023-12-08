namespace Corzo_02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Figura = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctxtResultado1 = new System.Windows.Forms.TextBox();
            this.cbtnFigura1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbtnFigura2 = new System.Windows.Forms.Button();
            this.ctxtResultado2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtnSalir = new System.Windows.Forms.Button();
            this.Figura.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Figura
            // 
            this.Figura.Controls.Add(this.tabPage1);
            this.Figura.Controls.Add(this.tabPage2);
            this.Figura.Location = new System.Drawing.Point(70, 105);
            this.Figura.Margin = new System.Windows.Forms.Padding(2);
            this.Figura.Name = "Figura";
            this.Figura.SelectedIndex = 0;
            this.Figura.Size = new System.Drawing.Size(765, 346);
            this.Figura.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.ctxtResultado1);
            this.tabPage1.Controls.Add(this.cbtnFigura1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(757, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Figura N° 1";
            // 
            // ctxtResultado1
            // 
            this.ctxtResultado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ctxtResultado1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctxtResultado1.Location = new System.Drawing.Point(106, 10);
            this.ctxtResultado1.Margin = new System.Windows.Forms.Padding(2);
            this.ctxtResultado1.Multiline = true;
            this.ctxtResultado1.Name = "ctxtResultado1";
            this.ctxtResultado1.Size = new System.Drawing.Size(640, 310);
            this.ctxtResultado1.TabIndex = 4;
            // 
            // cbtnFigura1
            // 
            this.cbtnFigura1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbtnFigura1.Location = new System.Drawing.Point(11, 115);
            this.cbtnFigura1.Margin = new System.Windows.Forms.Padding(2);
            this.cbtnFigura1.Name = "cbtnFigura1";
            this.cbtnFigura1.Size = new System.Drawing.Size(91, 38);
            this.cbtnFigura1.TabIndex = 2;
            this.cbtnFigura1.Text = "Figura 1";
            this.cbtnFigura1.UseVisualStyleBackColor = false;
            this.cbtnFigura1.Click += new System.EventHandler(this.btnImagen1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.cbtnFigura2);
            this.tabPage2.Controls.Add(this.ctxtResultado2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(757, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Figura N° 2";
            // 
            // cbtnFigura2
            // 
            this.cbtnFigura2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbtnFigura2.Location = new System.Drawing.Point(4, 113);
            this.cbtnFigura2.Margin = new System.Windows.Forms.Padding(2);
            this.cbtnFigura2.Name = "cbtnFigura2";
            this.cbtnFigura2.Size = new System.Drawing.Size(97, 34);
            this.cbtnFigura2.TabIndex = 8;
            this.cbtnFigura2.Text = "Figura 2";
            this.cbtnFigura2.UseVisualStyleBackColor = false;
            this.cbtnFigura2.Click += new System.EventHandler(this.btnImagen2_Click);
            // 
            // ctxtResultado2
            // 
            this.ctxtResultado2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ctxtResultado2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctxtResultado2.Location = new System.Drawing.Point(105, 10);
            this.ctxtResultado2.Margin = new System.Windows.Forms.Padding(2);
            this.ctxtResultado2.Multiline = true;
            this.ctxtResultado2.Name = "ctxtResultado2";
            this.ctxtResultado2.Size = new System.Drawing.Size(634, 308);
            this.ctxtResultado2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "GRÁFICOS LÓGICOS ";
            // 
            // cbtnSalir
            // 
            this.cbtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbtnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtnSalir.Location = new System.Drawing.Point(754, 453);
            this.cbtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.cbtnSalir.Name = "cbtnSalir";
            this.cbtnSalir.Size = new System.Drawing.Size(108, 43);
            this.cbtnSalir.TabIndex = 5;
            this.cbtnSalir.Text = "Salir";
            this.cbtnSalir.UseVisualStyleBackColor = false;
            this.cbtnSalir.Click += new System.EventHandler(this.cbtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(906, 499);
            this.Controls.Add(this.cbtnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Figura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Figura.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl Figura;
        private TabPage tabPage1;
        private TextBox ctxtResultado1;
        private Button cbtnFigura1;
        private TabPage tabPage2;
        private Button cbtnFigura2;
        private TextBox ctxtResultado2;
        private Label label1;
        private Button cbtnSalir;
    }
}