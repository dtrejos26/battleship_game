using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Barcos
{
    public class Oponente
    {

        public string nombre { get; set; }
        public  int vida { get; set; }
        public Hashtable dialogos { get; set; }

        private Jugador jugador;

        public delegate int quitarVida(int valor);
        public quitarVida disminuirVida;

        public delegate bool atacar(Canon canon, IEnumerable<Barco> listaBarcos, Panel p, int x, int y);
        public atacar atacarBarco;

        private Random ejes;

        public Timer contador;

       
        public Oponente()
        {
            jugador = new Jugador();

            nombre = "Oponente";
            vida = 100;
            dialogos = new Hashtable();

            disminuirVida = new quitarVida(jugador.quitarVida);

            ejes = new Random();

            atacarBarco = new atacar(jugador.atacar);
            contador = new Timer();

        }

        public int setVida(int valor)
        {
            vida = disminuirVida(valor);

            return vida;
        }



        public void cargarTablaDialogos()
        {

            // LISTA PARA DIALOGO SERIO

            List<string> serioL = new List<string> { "Esto es demasiado facil...", "Espero que sea una buena partida... niño, jajaja!", "..." };
            Dialogo serioD = new Dialogo(serioL, Properties.Resources.MujerFeliz);
            dialogos.Add("Seria", serioD);


            // LISTA PARA DIALOGO ENOJADO

            List<string> enojadoL = new List<string> { "IMPOSIBLE...", "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO!", "MALDITO SEAS, ESTO NO SE QUEDARA ASI!" };
            Dialogo enojadoD = new Dialogo(enojadoL, Properties.Resources.MujerEnojada);
            dialogos.Add("Enojada", enojadoD);


            // LISTA PARA DIALOGO EXITADO

            List<string> exitadoL = new List<string> { "BAHJAJAJAJAJA, das lastima!", "Eres demasiado malo! jajajaja!", "Por lo visto voy a ganar muy rapido. " };
            Dialogo exitadoD = new Dialogo(exitadoL, Properties.Resources.MujerExitada);
            dialogos.Add("Exitada", exitadoD);


            // LISTA PARA DIALOGO PREOCUPADO


            List<string> preocupadoL = new List<string> { "No, no, nooo, NO PUEDE SER VERDAD.", "Debes estar haciendo trampa...", "PE-PE-PERO COMO LO HICISTES!?" };
            Dialogo preocupadoD = new Dialogo(preocupadoL, Properties.Resources.MujerPreocupada);
            dialogos.Add("Preocupada", preocupadoD);


        }

        public void cargarEventoTimer()
        {

            contador.Tick += atacarJugador;

        }


        public void atacarJugador(object sender, EventArgs e)
        {
            int x = ejes.Next(Juego.mapaJuego.zonaJugador.Width);
            int y = ejes.Next(Juego.mapaJuego.zonaJugador.Height);

            
            if(atacarBarco(Juego.canon, Juego.mapaJuego.listaBarcosJugador, Juego.mapaJuego.zonaJugador, x, y))
            {

                Juego.barraAccion.vidaJugador.Value = Juego.jugador.quitarVida(10);

                if(Juego.barraAccion.vidaJugador.Value == 0)
                {
                    Juego.estadoJuego("Perder");
                    return;

                }
                
            }

            Juego.cambioTurno(Color.LightGreen, "Turno jugador");

            contador.Stop();
            Juego.habilitarControles();
            Juego.tiempoLimite = 15;

        }
      

        


    }
}
