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
using System.Drawing.Imaging;

namespace Proyecto_3
{
    public partial class Form1 : Form
    {
        Animaciones an;
        SerialPort comunicaciones;
        string path;

        public Form1()
        {
            path = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            InitializeComponent();
            an = new Animaciones(img_water, img_motor);
            img_motor.Enabled = false;
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
            //Image img = Image.FromFile("C:\\Users\\david\\Desktop\\Semestre 7\\Instrumentacion\\Proyecto 3\\Proyecto_3\\motor (1).gif");
            //Bitmap bpm = new Bitmap(img);
            //imagenMotor.Image = img;
        }
        private void RecivirDatos(Object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            String datos = sp.ReadLine();
            Console.WriteLine(datos + " cm");
            String[] info = datos.Split(' ');
            /*double distancia;
            double temperatura;
            double luz;*/
            float distancia;
            float temperatura;
            float luz;
            int motor;
            try
            {
                /*distancia = ((double)(Int64.Parse(info[0]) / 2)) * 0.0343;
                temperatura = ((double)(Int64.Parse(info[1]) / 1023.0)) * 100.0;
                luz = (Int64.Parse(info[2].Replace("\r\n", "")) *5.0) / 1023.0;*/

                distancia = float.Parse(info[0]);
                temperatura =(float)Math.Round(float.Parse(info[1]));
                luz = float.Parse(info[2]);
                motor = Int32.Parse(info[3].Replace("\r\n", ""));
                luz = (float)Math.Pow(Math.E, (luz - 1.5758) / 0.7671);
                an.Invoke(new MethodInvoker(
                       delegate
                       {
                           MensajeDistancia("Distancia medida: " + distancia, Color.Green);
                           MensajeTemperatura("Temperatura: " + temperatura + " °C", Color.Black, temperatura);
                           MensajeLuz("Nivel de Luz: " + luz, luz);
                           an.LlenarTinaco((int)Math.Round(distancia),motor);
                       }
               ));

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message + "\n Pidiendo datos...");
                try
                {
                    if (comunicaciones.IsOpen)
                    {
                        comunicaciones.Close();
                        Console.WriteLine("Puerto " + comunicaciones.PortName + " desconectado");
                    }
                    else
                    {
                        Console.WriteLine("Puerto " + comunicaciones.PortName + " ya esta desconectado");
                    }
                    
                }
                catch (Exception disconecEx)
                {
                    MessageBox.Show(disconecEx.Message);
                }

                comunicaciones.BaudRate = 9600;
                comunicaciones.Parity = Parity.None;
                comunicaciones.DataBits = 8;
                //comunicaciones.ReadTimeout = 500;
                comunicaciones.Open();
                if (comunicaciones.IsOpen)
                {
                    Console.WriteLine("Conectado al puerto " + comunicaciones.PortName, Color.Green);
                }

                byte[] instruccionInicio = { 1 };
                comunicaciones.Write(instruccionInicio, 0, 1);
            }
        }
        public void Mensaje(String mensaje, Color c)
        {
            mensajes.Text = mensaje;
            mensajes.ForeColor = c;
        }
        public void MensajeDistancia(String mensaje, Color c)
        {
            mensajesDistancia.Text = mensaje;
            mensajesDistancia.ForeColor = c;
        }

        public void MensajeTemperatura(String mensaje, Color c)
        {
            mensajeTemperatura.Text = mensaje;
            mensajeTemperatura.ForeColor = c;
        }
        public void MensajeTemperatura(String mensaje, Color c, float temp)
        {
            MensajeTemperatura(mensaje, c);
            if (temp < 0)
            {
                img_temp.ImageLocation = path + "\\public\\images\\mucho_frio.png";
            }else if (temp < 15)
            {
                img_temp.ImageLocation = path + "\\public\\images\\frio_original.png";
            }
            else if (temp < 35)
            {
                img_temp.ImageLocation = path + "\\public\\images\\calor_original.png";
            }
            else if (temp >= 35)
            {
                img_temp.ImageLocation = path + "\\public\\images\\mucho_calor.png";
            }
        }

        public void MensajeLuz(String mensaje, Color c)
        {
            mensajeLuz.Text = mensaje;
            mensajeLuz.ForeColor = c;
        }

        public void MensajeLuz(String mensaje, float lux)
        {
            mensajeLuz.Text = mensaje;
            // Se volvera más amarillo entre más luminoso y más oscuro entre más cercano a cero
            mensajeLuz.ForeColor = Color.FromArgb(((int) lux * 5), ((int) lux * 4), 0); 
            // 255, 212, 0
            // 54, 45
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
                comunicaciones.BaudRate = 9600;
                comunicaciones.Parity = Parity.None;
                comunicaciones.DataBits = 8;
                //comunicaciones.ReadTimeout = 500;
                comunicaciones.Open();
                if (comunicaciones.IsOpen)
                {
                    Console.WriteLine("Conectado al puerto " + comunicaciones.PortName,Color.Green);
                }
                botonDesconectar.Enabled = true;
                botonConectar.Enabled = false;

                byte[] instruccionInicio = { 1 };
                comunicaciones.Write(instruccionInicio, 0,1);
                img_motor.Enabled = false;
                
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
                    Console.WriteLine("Puerto " + comunicaciones.PortName + " desconectado");
                }
                else
                {
                    Console.WriteLine("Puerto " + comunicaciones.PortName + " ya esta desconectado");
                }
                botonConectar.Enabled = true;
                botonDesconectar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            an.graficos.Clear(Color.White);
            img_motor.Enabled = false;
            MensajeDistancia("Distancia medida: -", Color.Black);
            MensajeTemperatura("Temperatura: - °C", Color.Black);
            MensajeLuz("Nivel de Luz: -", Color.Black);
        }

        private void imagenMotor_Click(object sender, EventArgs e)
        {

        }

        private void lienzo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 win2 = new Form2();
            win2.Show();
        }
    }
}
