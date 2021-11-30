
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
            this.lienzo = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.botonBuscarPuertos = new System.Windows.Forms.Button();
            this.botonConectar = new System.Windows.Forms.Button();
            this.botonDesconectar = new System.Windows.Forms.Button();
            this.mensajes = new System.Windows.Forms.Label();
            this.imagenMotor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lienzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // lienzo
            // 
            this.lienzo.Location = new System.Drawing.Point(12, 68);
            this.lienzo.Name = "lienzo";
            this.lienzo.Size = new System.Drawing.Size(776, 370);
            this.lienzo.TabIndex = 0;
            this.lienzo.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // botonBuscarPuertos
            // 
            this.botonBuscarPuertos.Location = new System.Drawing.Point(150, 13);
            this.botonBuscarPuertos.Name = "botonBuscarPuertos";
            this.botonBuscarPuertos.Size = new System.Drawing.Size(75, 23);
            this.botonBuscarPuertos.TabIndex = 2;
            this.botonBuscarPuertos.Text = "Buscar";
            this.botonBuscarPuertos.UseVisualStyleBackColor = true;
            this.botonBuscarPuertos.Click += new System.EventHandler(this.botonBuscarPuertos_Click);
            // 
            // botonConectar
            // 
            this.botonConectar.Location = new System.Drawing.Point(232, 13);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(75, 23);
            this.botonConectar.TabIndex = 3;
            this.botonConectar.Text = "Conectar";
            this.botonConectar.UseVisualStyleBackColor = true;
            this.botonConectar.Click += new System.EventHandler(this.botonConectar_Click);
            // 
            // botonDesconectar
            // 
            this.botonDesconectar.Enabled = false;
            this.botonDesconectar.Location = new System.Drawing.Point(314, 13);
            this.botonDesconectar.Name = "botonDesconectar";
            this.botonDesconectar.Size = new System.Drawing.Size(83, 23);
            this.botonDesconectar.TabIndex = 4;
            this.botonDesconectar.Text = "Desconectar";
            this.botonDesconectar.UseVisualStyleBackColor = true;
            this.botonDesconectar.Click += new System.EventHandler(this.botonDesconectar_Click);
            // 
            // mensajes
            // 
            this.mensajes.AutoSize = true;
            this.mensajes.Location = new System.Drawing.Point(447, 20);
            this.mensajes.Name = "mensajes";
            this.mensajes.Size = new System.Drawing.Size(0, 15);
            this.mensajes.TabIndex = 5;
            this.mensajes.Click += new System.EventHandler(this.label1_Click);
            // 
            // imagenMotor
            // 
            this.imagenMotor.Location = new System.Drawing.Point(100, 268);
            this.imagenMotor.Name = "imagenMotor";
            this.imagenMotor.Size = new System.Drawing.Size(150, 130);
            this.imagenMotor.TabIndex = 6;
            this.imagenMotor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagenMotor);
            this.Controls.Add(this.mensajes);
            this.Controls.Add(this.botonDesconectar);
            this.Controls.Add(this.botonConectar);
            this.Controls.Add(this.botonBuscarPuertos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lienzo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lienzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenMotor)).EndInit();
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
    }
}

