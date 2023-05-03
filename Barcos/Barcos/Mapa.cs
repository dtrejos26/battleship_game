using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Barcos
{
    public class Mapa
    {

        public Panel zonaJugador { get; set; }
        public Panel zonaOponente { get; set; }
        public Timer contador { get; set; }
        public Label indicadorTiempo { get; set; }
        public Label indicadorTurno { get; set; }
        public IEnumerable<Barco> listaBarcosOponente { get; set; }
        public IEnumerable<Barco> listaBarcosJugador { get; set; }




        public Mapa()
        {

            zonaJugador = null;
            zonaOponente = null;
            contador = new Timer();
            indicadorTiempo = null;
            listaBarcosOponente = null;
            listaBarcosJugador = null;

        }




        public void agregarEventos()
        {


            zonaOponente.MouseClick += eventoZonaJugadores;
            zonaOponente.MouseMove += eventoMouse;
            contador.Tick += eventoTick;
        }


        private void eventoMouse(object ob, MouseEventArgs e)
        {


            if (Juego.click && Juego.turnoJugador)
            {

                Juego.barraAccion.ejeX.Text = e.X.ToString();
                Juego.barraAccion.ejeY.Text = e.Y.ToString();






                Bitmap img = Properties.Resources.big_gun;
                double test = (e.Location.Y - 65) / (Math.PI) + (e.Location.X * -0.05) - 150;
                Juego.canon.canon.BackgroundImage = Juego.canon.rotarImagen(img, (float)test);

            }




        }



        private void eventoZonaJugadores(object ob, MouseEventArgs e)
        {



            if (e.Button == MouseButtons.Left && Juego.turnoJugador)
            {

                Juego.click = false;
                Font myFont = new Font("Helvetica", 8, FontStyle.Bold);

                Brush myBrush = new SolidBrush(Color.SpringGreen);

                Graphics gs = zonaOponente.CreateGraphics();

                gs.DrawString("*", myFont, myBrush, e.X - 6, e.Y - 6);

            }




        }

        private void eventoTick(object sender, EventArgs e)
        {

            int tiempo = Juego.tiempoLimite -= 1;
            indicadorTiempo.Text = tiempo.ToString();


            if(tiempo == 0)
            {
                Juego.cambioTurno(Color.Red, "Turno oponente");
                Juego.deshabilitarControles();
                Juego.tiempoLimite = 15;
                Juego.oponente.contador.Start();

            }
            
        }



        


      

    }
}
