namespace daylyrutine
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Barratitulo = new System.Windows.Forms.Panel();
            this.botonminimizarinicio = new System.Windows.Forms.PictureBox();
            this.botonocultarinicio = new System.Windows.Forms.PictureBox();
            this.botonmaximizarinicio = new System.Windows.Forms.PictureBox();
            this.botoncerrarinicio = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonminimizarinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonocultarinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonmaximizarinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botoncerrarinicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(423, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = " Esparta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Barratitulo
            // 
            this.Barratitulo.BackColor = System.Drawing.Color.Brown;
            this.Barratitulo.Controls.Add(this.botonminimizarinicio);
            this.Barratitulo.Controls.Add(this.botonocultarinicio);
            this.Barratitulo.Controls.Add(this.botonmaximizarinicio);
            this.Barratitulo.Controls.Add(this.botoncerrarinicio);
            this.Barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barratitulo.Location = new System.Drawing.Point(0, 0);
            this.Barratitulo.Name = "Barratitulo";
            this.Barratitulo.Size = new System.Drawing.Size(1060, 35);
            this.Barratitulo.TabIndex = 3;
            // 
            // botonminimizarinicio
            // 
            this.botonminimizarinicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonminimizarinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonminimizarinicio.Image = ((System.Drawing.Image)(resources.GetObject("botonminimizarinicio.Image")));
            this.botonminimizarinicio.Location = new System.Drawing.Point(939, 3);
            this.botonminimizarinicio.Name = "botonminimizarinicio";
            this.botonminimizarinicio.Size = new System.Drawing.Size(25, 25);
            this.botonminimizarinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonminimizarinicio.TabIndex = 3;
            this.botonminimizarinicio.TabStop = false;
            this.botonminimizarinicio.Click += new System.EventHandler(this.botonminimizarinicio_Click);
            // 
            // botonocultarinicio
            // 
            this.botonocultarinicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonocultarinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonocultarinicio.Image = ((System.Drawing.Image)(resources.GetObject("botonocultarinicio.Image")));
            this.botonocultarinicio.Location = new System.Drawing.Point(970, 3);
            this.botonocultarinicio.Name = "botonocultarinicio";
            this.botonocultarinicio.Size = new System.Drawing.Size(25, 25);
            this.botonocultarinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonocultarinicio.TabIndex = 2;
            this.botonocultarinicio.TabStop = false;
            this.botonocultarinicio.Click += new System.EventHandler(this.botonocultarinicio_Click);
            // 
            // botonmaximizarinicio
            // 
            this.botonmaximizarinicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonmaximizarinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonmaximizarinicio.Image = ((System.Drawing.Image)(resources.GetObject("botonmaximizarinicio.Image")));
            this.botonmaximizarinicio.Location = new System.Drawing.Point(1001, 3);
            this.botonmaximizarinicio.Name = "botonmaximizarinicio";
            this.botonmaximizarinicio.Size = new System.Drawing.Size(25, 25);
            this.botonmaximizarinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonmaximizarinicio.TabIndex = 1;
            this.botonmaximizarinicio.TabStop = false;
            this.botonmaximizarinicio.Click += new System.EventHandler(this.botonmaximizar_Click);
            // 
            // botoncerrarinicio
            // 
            this.botoncerrarinicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botoncerrarinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoncerrarinicio.Image = ((System.Drawing.Image)(resources.GetObject("botoncerrarinicio.Image")));
            this.botoncerrarinicio.Location = new System.Drawing.Point(1032, 3);
            this.botoncerrarinicio.Name = "botoncerrarinicio";
            this.botoncerrarinicio.Size = new System.Drawing.Size(25, 25);
            this.botoncerrarinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botoncerrarinicio.TabIndex = 0;
            this.botoncerrarinicio.TabStop = false;
            this.botoncerrarinicio.Click += new System.EventHandler(this.botoncerrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Haettenschweiler", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(326, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrar Misiones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1060, 585);
            this.Controls.Add(this.Barratitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Barratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonminimizarinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonocultarinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonmaximizarinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botoncerrarinicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Barratitulo;
        private System.Windows.Forms.PictureBox botonminimizarinicio;
        private System.Windows.Forms.PictureBox botonocultarinicio;
        private System.Windows.Forms.PictureBox botonmaximizarinicio;
        private System.Windows.Forms.PictureBox botoncerrarinicio;
        private System.Windows.Forms.Button button1;
    }
}

