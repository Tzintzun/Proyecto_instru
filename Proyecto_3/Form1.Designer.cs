
namespace Proyecto_3
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
            this.lienzo = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.botonBuscarPuertos = new System.Windows.Forms.Button();
            this.botonConectar = new System.Windows.Forms.Button();
            this.botonDesconectar = new System.Windows.Forms.Button();
            this.mensajes = new System.Windows.Forms.Label();
            this.imagenMotor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lienzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lienzo
            // 
            this.lienzo.Image = ((System.Drawing.Image)(resources.GetObject("lienzo.Image")));
            this.lienzo.Location = new System.Drawing.Point(364, 13);
            this.lienzo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lienzo.Name = "lienzo";
            this.lienzo.Size = new System.Drawing.Size(502, 514);
            this.lienzo.TabIndex = 0;
            this.lienzo.TabStop = false;
            this.lienzo.Click += new System.EventHandler(this.lienzo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // botonBuscarPuertos
            // 
            this.botonBuscarPuertos.BackColor = System.Drawing.Color.SkyBlue;
            this.botonBuscarPuertos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonBuscarPuertos.Location = new System.Drawing.Point(23, 86);
            this.botonBuscarPuertos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonBuscarPuertos.Name = "botonBuscarPuertos";
            this.botonBuscarPuertos.Size = new System.Drawing.Size(156, 55);
            this.botonBuscarPuertos.TabIndex = 2;
            this.botonBuscarPuertos.Text = "Buscar";
            this.botonBuscarPuertos.UseVisualStyleBackColor = false;
            this.botonBuscarPuertos.Click += new System.EventHandler(this.botonBuscarPuertos_Click);
            // 
            // botonConectar
            // 
            this.botonConectar.BackColor = System.Drawing.Color.SkyBlue;
            this.botonConectar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonConectar.Location = new System.Drawing.Point(17, 212);
            this.botonConectar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(162, 55);
            this.botonConectar.TabIndex = 3;
            this.botonConectar.Text = "Conectar";
            this.botonConectar.UseVisualStyleBackColor = false;
            this.botonConectar.Click += new System.EventHandler(this.botonConectar_Click);
            // 
            // botonDesconectar
            // 
            this.botonDesconectar.BackColor = System.Drawing.Color.SkyBlue;
            this.botonDesconectar.Enabled = false;
            this.botonDesconectar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonDesconectar.Location = new System.Drawing.Point(17, 289);
            this.botonDesconectar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonDesconectar.Name = "botonDesconectar";
            this.botonDesconectar.Size = new System.Drawing.Size(162, 55);
            this.botonDesconectar.TabIndex = 4;
            this.botonDesconectar.Text = "Desconectar";
            this.botonDesconectar.UseVisualStyleBackColor = false;
            this.botonDesconectar.Click += new System.EventHandler(this.botonDesconectar_Click);
            // 
            // mensajes
            // 
            this.mensajes.AutoSize = true;
            this.mensajes.Location = new System.Drawing.Point(511, 27);
            this.mensajes.Name = "mensajes";
            this.mensajes.Size = new System.Drawing.Size(0, 20);
            this.mensajes.TabIndex = 5;
            this.mensajes.Click += new System.EventHandler(this.label1_Click);
            // 
            // imagenMotor
            // 
            this.imagenMotor.Image = ((System.Drawing.Image)(resources.GetObject("imagenMotor.Image")));
            this.imagenMotor.Location = new System.Drawing.Point(221, 390);
            this.imagenMotor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imagenMotor.Name = "imagenMotor";
            this.imagenMotor.Size = new System.Drawing.Size(218, 137);
            this.imagenMotor.TabIndex = 6;
            this.imagenMotor.TabStop = false;
            this.imagenMotor.Click += new System.EventHandler(this.imagenMotor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(454, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 17);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imagenMotor);
            this.Controls.Add(this.mensajes);
            this.Controls.Add(this.botonDesconectar);
            this.Controls.Add(this.botonConectar);
            this.Controls.Add(this.botonBuscarPuertos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lienzo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Sensores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lienzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lienzo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button botonBuscarPuertos;
        private System.Windows.Forms.Button botonConectar;
        private System.Windows.Forms.Button botonDesconectar;
        private System.Windows.Forms.Label mensajes;
        private System.Windows.Forms.PictureBox imagenMotor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

