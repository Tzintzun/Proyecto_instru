using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3
{
    class Animaciones : Control
    {
        bool activarMotores;
        int porcentajeTinaco;
        PictureBox img;
        int distancia;
        SolidBrush lapiz;
        public Graphics graficos;
        //Rectangle tinaco = new Rectangle(454, 460, 320, 17);
        Rectangle tinaco = new Rectangle(0, 0, 324, 311);

        public Animaciones(PictureBox px, PictureBox img)
        {
            lapiz = new SolidBrush(Color.DeepSkyBlue);
            graficos = px.CreateGraphics();
            distancia = px.Height;
            this.img = img;
            
        }

        public void deconectar()
        {
            porcentajeTinaco = -1;
            activarMotores = false;
        }

        public void LlenarTinaco(int porcentaje, int motor)
        {
            if (porcentaje > 0 && porcentaje < 99)
            {
                porcentajeTinaco = porcentaje;
            }
            byte [] instruccion = new byte[1];

            if (motor == 1)
            {
                activarMotores = true;
            }
            else 
            {
                activarMotores = false;
            }
            tinaco.Height = distancia - (int)(porcentajeTinaco * distancia/100);
            tinaco.Y = distancia - tinaco.Height;
            pintarAgua();
            
        }
        public void pintarAgua()
        {
            img.Enabled = activarMotores;
            graficos.Clear(Color.White);
            graficos.FillRectangle(lapiz, tinaco);
        }
        

    }
}

