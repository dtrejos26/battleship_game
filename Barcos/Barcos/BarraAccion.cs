using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcos
{
    public  class BarraAccion
    {


        public PictureBox imagenJugador { get; set; }
        public PictureBox imagenOponente { get; set; }

        public ProgressBar vidaJugador { get; set; }
        public ProgressBar vidaOponente { get; set; }

        public Label zonaDialogo { get; set; }
        public NumericUpDown ejeX { get; set; }
        public NumericUpDown ejeY { get; set; }
        public Label nombreJugador { get; set; }
        public Label nombreOponente { get; set; }
        public Label titulo { get; set; }
        public Button disparar { get; set; }


        public BarraAccion()
        {

            imagenJugador = null;
            imagenOponente = null;
            vidaJugador = null;
            vidaOponente = null;
            zonaDialogo = null;
            ejeX = null;
            ejeY = null;
            nombreJugador = null;
            nombreOponente = null;
            titulo = null;
            disparar = null;

        }



        public async void escribir(string quien, string emocion, Dialogo dialog)
        {

            zonaDialogo.Text = String.Empty;

            Random r = new Random();

            int num = r.Next(dialog.dialogos.Count);
            string msn = dialog.dialogos[num];


            if(quien == "Jugador")
            {
                foreach (char c in msn)
                {

                    zonaDialogo.Text += c.ToString();
                    await Task.Delay(50);

                }
                
                imagenJugador.BackgroundImage = dialog.emocion;


            }else if(quien == "Oponente")
            {

                foreach (char c in msn)
                {

                    zonaDialogo.Text += c.ToString();
                    await Task.Delay(50);

                }

                imagenOponente.BackgroundImage = dialog.emocion;


            }


        }


        public void agregarEventoBotonDisparo()
        {

            disparar.Click += eventoDisparo;

        }


        private void eventoDisparo(object ob, EventArgs e)
        {

            
            int t = Convert.ToInt32(Juego.barraAccion.ejeX.Text);
            int t2 = Convert.ToInt32(Juego.barraAccion.ejeY.Text);



            if (Juego.jugador.atacar(Juego.canon, Juego.mapaJuego.listaBarcosOponente, Juego.mapaJuego.zonaOponente, t, t2))
            {

                Juego.barraAccion.vidaOponente.Value = Juego.oponente.setVida(10);
                
                if (Juego.barraAccion.vidaOponente.Value == 0)
                {


                    Juego.estadoJuego("Ganar");
                    return;
                }


            }

            Juego.oponente.contador.Start();

            Dialogo d = (Dialogo)Juego.oponente.dialogos["Preocupada"];


            Juego.cambioTurno(Color.Red, "Turno oponente");
            Juego.barraAccion.escribir("Oponente", "Enojada", d);

            Juego.click = true;
            Juego.deshabilitarControles();
            Juego.tiempoLimite = 15;

        }





    }
}
