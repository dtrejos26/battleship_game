using System.Drawing;
using System.Windows.Forms;

namespace Barcos
{
    public class Barco : PictureBox
    {


        public Image imagenBarco { get; set; }
        public Image barcoDestruido { get; set; }
        public bool destruido { get; set; }
        private Point localizacionMouse;
        public string id { get; set; }

        public Barco()
        {
            destruido = false;
            imagenBarco = null;
            barcoDestruido = null;
            id = "";

            

        }



        public void destruir()
        {

            BackgroundImage = barcoDestruido;
            destruido = true;


        }

        public void agregarEventosDrag()
        {

            MouseDown += clickOprimido;
            MouseMove += mouseMoviendose;
            

        }



        private void mouseMoviendose(object ob, MouseEventArgs e)
        {
            Barco barco = (Barco)ob;

            if (e.Button == MouseButtons.Left)
            {
                if (!(barco.Location.X < 0) && !(barco.Location.Y < 0) && barco.Location.X < Parent.Width && barco.Location.Y < Parent.Height)
                {
                    barco.Left = e.X + barco.Left - localizacionMouse.X;
                    barco.Top = e.Y + barco.Top - localizacionMouse.Y;

                }
                else if (barco.Location.X < 0)
                {
                    barco.Location = new Point(0, barco.Location.Y);


                }
                else if (barco.Location.Y < 0)
                {
                    barco.Location = new Point(barco.Location.X, 0);


                }
                else if (barco.Location.X <= 0 && barco.Location.Y <= 0)
                {
                    barco.Location = new Point(1, 1);

                }
                else if (barco.Location.X > Parent.Width - barco.Width)
                {

                    barco.Location = new Point(Parent.Width - barco.Width, barco.Location.Y);

                }
                else if (barco.Location.Y > Parent.Height - barco.Height)
                {

                    barco.Location = new Point(barco.Location.X, Parent.Height - barco.Height);

                }





            }





        }


        private void clickOprimido(object ob, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                localizacionMouse = e.Location;


            }

        }


   

     


    }
}
