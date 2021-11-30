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

        SolidBrush lapiz;
        public Graphics graficos;
        Rectangle tinaco = new Rectangle(47, 10, 180, 180);

        public Animaciones(PictureBox px,PictureBox img)
        {
            lapiz = new SolidBrush(Color.Aqua);
            graficos = px.CreateGraphics();
            this.img = img;
        }

        public void LlenarTinaco(int porcentaje)
        {
            if (porcentaje < 0)
            {
                porcentajeTinaco = 0;
            }
            else if (porcentaje > 100)
            {
                porcentajeTinaco = 100;
            }
            else
            {
                porcentajeTinaco = porcentaje;
            }

            if (porcentaje>=90 )
            {
                activarMotores = true;
            }else if(porcentaje <=3)
            {
                activarMotores = false;
            }
            tinaco.Height = 180 - (int)(porcentajeTinaco * 1.8);
            tinaco.Y = 190 - tinaco.Height;
            pintarAgua();
        }
        public void pintarAgua()
        {
            graficos.Clear(Color.White);
            graficos.FillRectangle(lapiz, tinaco);
            img.Enabled = activarMotores;
        }

    }
}

