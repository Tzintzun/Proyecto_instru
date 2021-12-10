
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
            this.mensajesDistancia = new System.Windows.Forms.Label();
            this.img_motor = new System.Windows.Forms.PictureBox();
            this.img_water = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mensajeTemperatura = new System.Windows.Forms.Label();
            this.mensajeLuz = new System.Windows.Forms.Label();
            this.mensajes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lienzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_motor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_water)).BeginInit();
            this.SuspendLayout();
            // 
            // lienzo
            // 
            this.lienzo.Image = ((System.Drawing.Image)(resources.GetObject("lienzo.Image")));
            this.lienzo.Location = new System.Drawing.Point(458, 26);
            this.lienzo.Name = "lienzo";
            this.lienzo.Size = new System.Drawing.Size(439, 386);
            this.lienzo.TabIndex = 0;
            this.lienzo.TabStop = false;
            this.lienzo.Click += new System.EventHandler(this.lienzo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // botonBuscarPuertos
            // 
            this.botonBuscarPuertos.BackColor = System.Drawing.Color.SkyBlue;
            this.botonBuscarPuertos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonBuscarPuertos.Location = new System.Drawing.Point(20, 64);
            this.botonBuscarPuertos.Name = "botonBuscarPuertos";
            this.botonBuscarPuertos.Size = new System.Drawing.Size(136, 41);
            this.botonBuscarPuertos.TabIndex = 2;
            this.botonBuscarPuertos.Text = "Buscar";
            this.botonBuscarPuertos.UseVisualStyleBackColor = false;
            this.botonBuscarPuertos.Click += new System.EventHandler(this.botonBuscarPuertos_Click);
            // 
            // botonConectar
            // 
            this.botonConectar.BackColor = System.Drawing.Color.SkyBlue;
            this.botonConectar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonConectar.Location = new System.Drawing.Point(15, 159);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(142, 41);
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
            this.botonDesconectar.Location = new System.Drawing.Point(15, 217);
            this.botonDesconectar.Name = "botonDesconectar";
            this.botonDesconectar.Size = new System.Drawing.Size(142, 41);
            this.botonDesconectar.TabIndex = 4;
            this.botonDesconectar.Text = "Desconectar";
            this.botonDesconectar.UseVisualStyleBackColor = false;
            this.botonDesconectar.Click += new System.EventHandler(this.botonDesconectar_Click);
            // 
            // mensajesDistancia
            // 
            this.mensajesDistancia.AutoSize = true;
            this.mensajesDistancia.Location = new System.Drawing.Point(199, 55);
            this.mensajesDistancia.Name = "mensajesDistancia";
            this.mensajesDistancia.Size = new System.Drawing.Size(101, 15);
            this.mensajesDistancia.TabIndex = 5;
            this.mensajesDistancia.Text = "Distancia medida:";
            this.mensajesDistancia.Click += new System.EventHandler(this.label1_Click);
            // 
            // img_motor
            // 
            this.img_motor.Image = ((System.Drawing.Image)(resources.GetObject("img_motor.Image")));
            this.img_motor.Location = new System.Drawing.Point(257, 281);
            this.img_motor.Name = "img_motor";
            this.img_motor.Size = new System.Drawing.Size(191, 131);
            this.img_motor.TabIndex = 6;
            this.img_motor.TabStop = false;
            this.img_motor.Click += new System.EventHandler(this.imagenMotor_Click);
            // 
            // img_water
            // 
            this.img_water.BackColor = System.Drawing.SystemColors.Window;
            this.img_water.Location = new System.Drawing.Point(545, 178);
            this.img_water.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_water.Name = "img_water";
            this.img_water.Size = new System.Drawing.Size(327, 234);
            this.img_water.TabIndex = 7;
            this.img_water.TabStop = false;
            this.img_water.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mensajeTemperatura
            // 
            this.mensajeTemperatura.AutoSize = true;
            this.mensajeTemperatura.Location = new System.Drawing.Point(199, 90);
            this.mensajeTemperatura.Name = "mensajeTemperatura";
            this.mensajeTemperatura.Size = new System.Drawing.Size(79, 15);
            this.mensajeTemperatura.TabIndex = 8;
            this.mensajeTemperatura.Text = "Temperatura: ";
            // 
            // mensajeLuz
            // 
            this.mensajeLuz.AutoSize = true;
            this.mensajeLuz.Location = new System.Drawing.Point(199, 132);
            this.mensajeLuz.Name = "mensajeLuz";
            this.mensajeLuz.Size = new System.Drawing.Size(74, 15);
            this.mensajeLuz.TabIndex = 9;
            this.mensajeLuz.Text = "Nivel de luz: ";
            // 
            // mensajes
            // 
            this.mensajes.AutoSize = true;
            this.mensajes.Location = new System.Drawing.Point(199, 26);
            this.mensajes.Name = "mensajes";
            this.mensajes.Size = new System.Drawing.Size(0, 15);
            this.mensajes.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(930, 528);
            this.Controls.Add(this.mensajes);
            this.Controls.Add(this.mensajeLuz);
            this.Controls.Add(this.mensajeTemperatura);
            this.Controls.Add(this.img_water);
            this.Controls.Add(this.img_motor);
            this.Controls.Add(this.mensajesDistancia);
            this.Controls.Add(this.botonDesconectar);
            this.Controls.Add(this.botonConectar);
            this.Controls.Add(this.botonBuscarPuertos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lienzo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sensores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lienzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_motor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_water)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lienzo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button botonBuscarPuertos;
        private System.Windows.Forms.Button botonConectar;
        private System.Windows.Forms.Button botonDesconectar;
        private System.Windows.Forms.Label mensajesDistancia;
        private System.Windows.Forms.PictureBox img_motor;
        private System.Windows.Forms.PictureBox img_water;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label mensajeTemperatura;
        private System.Windows.Forms.Label mensajeLuz;
        private System.Windows.Forms.Label mensajes;
    }
}

