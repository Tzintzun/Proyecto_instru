using System;
using System.Collections.Generic;
using System.Drawing;
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
        float distancia;
        SolidBrush lapiz;
        public Graphics graficos;
        //Rectangle tinaco = new Rectangle(454, 460, 320, 17);
        Rectangle tinaco = new Rectangle(0, 0, 327, 234);

        public Animaciones(PictureBox px, PictureBox img)
        {
            lapiz = new SolidBrush(Color.DeepSkyBlue);
            graficos = px.CreateGraphics();
            distancia = 50;
            this.img = img;
        }

        public void LlenarTinaco(int porcentaje)
        {
            if (porcentaje < 0)
            {
                porcentajeTinaco = 0;
            }
            else if (porcentaje > 99)
            {
                porcentajeTinaco = 99;
            }
            else
            {
                porcentajeTinaco = porcentaje;
            }

            if (porcentaje >= 90)
            {
                activarMotores = true;
            }else if(porcentaje <= 3)
            {
                activarMotores = false;
            }
            tinaco.Height = 234 - (int)(porcentajeTinaco * 2.34);
            tinaco.Y = 234 - tinaco.Height;
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

