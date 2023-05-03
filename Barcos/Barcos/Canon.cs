using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Barcos
{
    public class Canon
    {

        public PictureBox canon { get; set; }
        public Image imagen { get; set; }

 


        public Canon()
        {
            canon = null;
            imagen = null;


        }



        public Bitmap rotarImagen(Bitmap campoImg, float angulo)
        {



            Bitmap imgNueva = new Bitmap(campoImg.Width, campoImg.Height);
            Graphics g = Graphics.FromImage(imgNueva);
            g.TranslateTransform((float)campoImg.Width / 2, (float)campoImg.Height / 2);
            g.RotateTransform(angulo);
            g.TranslateTransform(-(float)campoImg.Width / 2, -(float)campoImg.Height / 2);
            g.DrawImage(campoImg, new Point(0, 0));

            return imgNueva;
        }


        public bool disparar(int x, int y, IEnumerable<Barco> listaBarcos, Panel p)
        {

            

            var bar = from b in listaBarcos
                      where y >= b.Location.Y && y <= b.Location.Y + b.Height && x>= b.Location.X
                      && x<= b.Location.X+b.Width                      
                      select b;



            foreach (var item in bar)
            {   
                if(item.destruido == true)
                {

                    return false;
                }

                item.Show();
                item.destruir();

                return true;

            }


            Font myFont = new Font("Helvetica", 8, FontStyle.Bold);

            Brush myBrush = new SolidBrush(Color.Red);

            Graphics gs = p.CreateGraphics();

            gs.DrawString("X", myFont, myBrush, x - 6, y - 6);


            return false;

        }



    }
}
