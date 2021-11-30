using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace Proyecto_3
{
    public partial class Form1 : Form
    {
        Animaciones an;
        SerialPort comunicaciones;
        public Form1()
        {
            InitializeComponent();
            an = new Animaciones(lienzo,imagenMotor);
            imagenMotor.Enabled = false;
            an.CreateControl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comunicaciones = new SerialPort();
            String[] nomPuertos = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            foreach(String s in nomPuertos)
            {
                comboBox1.Items.Add(s);
                
            }
            if (nomPuertos.Length > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            Mensaje("Se encontraron " + nomPuertos.Length + " puertos", Color.Black);
            comunicaciones.DataReceived += new SerialDataReceivedEventHandler(RecivirDatos);
            Image img = Image.FromFile("C:\\Users\\david\\Desktop\\Semestre 7\\Instrumentacion\\Proyecto 3\\Proyecto_3\\motor (1).gif");
            //Bitmap bpm = new Bitmap(img);
            imagenMotor.Image = img;
            
        }
        private void RecivirDatos(Object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            String datos = sp.ReadLine();
            String[] info = datos.Split(' ');
            float distancia = float.Parse(info[0].Replace("\r\n",""));

            an.Invoke(new MethodInvoker(
                    delegate
                    {
                        Mensaje("Distancia medida: " + distancia, Color.Green);

                        an.LlenarTinaco((int)distancia);
                    }
                ));
            
            
        }
        public void Mensaje(String mensaje, Color c)
        {
            mensajes.Text = mensaje;
            mensajes.ForeColor = c;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonBuscarPuertos_Click(object sender, EventArgs e)
        {
            String[] nomPuertos = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            foreach (String s in nomPuertos)
            {
                comboBox1.Items.Add(s);

            }
            if (nomPuertos.Length > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void botonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedIndex < 0)
                {
                    Mensaje("Escoge un puerto",Color.Red);
                }
                comunicaciones.PortName = comboBox1.Text;
                comunicaciones.Open();
                if (comunicaciones.IsOpen)
                {
                    Mensaje("Conectado al puerto " + comunicaciones.PortName,Color.Green);
                }
                botonDesconectar.Enabled = true;
                botonConectar.Enabled = false;

                byte[] instruccionInicio = { 1 };
                comunicaciones.Write(instruccionInicio, 0,1);
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comunicaciones.IsOpen)
                {
                    comunicaciones.Close();
                    Mensaje("Puerto " + comunicaciones.PortName + " desconectado", Color.Fuchsia);
                }
                else
                {
                    Mensaje("Puerto " + comunicaciones.PortName + " ya esta desconectado", Color.Fuchsia);
                }
                botonConectar.Enabled = true;
                botonDesconectar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            an.graficos.Clear(Color.White);
            imagenMotor.Enabled = false;
        }
    }
}
