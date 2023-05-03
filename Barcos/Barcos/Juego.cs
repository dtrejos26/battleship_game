using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
namespace Barcos
{
    public class Juego
    {


        public static BarraAccion barraAccion { get; set; }
        public static Canon canon { get; set; }
        public static Jugador jugador;
        public static Oponente oponente;    
        public static Mapa mapaJuego;


        public static bool click;
        

        public static int tiempoLimite;

        public int cantidadBarcos;
        public static bool turnoJugador;



        public Juego()
        {


            jugador = new Jugador();
            oponente = new Oponente();
            barraAccion = new BarraAccion();
            canon = new Canon();
            tiempoLimite = 15;
            cantidadBarcos = 10;
            click = true;
            turnoJugador = true;

            mapaJuego = new Mapa();
        }



        public void cargar()
        {
            mapaJuego.zonaJugador = FormJuego.objZonaJugador;
            mapaJuego.zonaOponente = FormJuego.objZonaOponente;           
            mapaJuego.indicadorTiempo = FormJuego.objEtiqTiempo;
            mapaJuego.indicadorTurno = FormJuego.objEtiTurno;

            barraAccion.imagenJugador = FormJuego.objFotoJugador;
            barraAccion.imagenOponente = FormJuego.objFotoOponente;
            barraAccion.vidaJugador = FormJuego.objVidaJugador;
            barraAccion.vidaOponente = FormJuego.objVidaOponente;
            barraAccion.disparar = FormJuego.objBotonDisparo;
            barraAccion.ejeX = FormJuego.objEjeX;
            barraAccion.ejeY = FormJuego.objEjeY;
            barraAccion.nombreJugador = FormJuego.objEtiNomJugador;
            barraAccion.nombreOponente = FormJuego.objEtiNomOponente;
            barraAccion.zonaDialogo = FormJuego.objZonaDialogo;

            canon.canon = FormJuego.objZonaCanon;
            canon.imagen = Properties.Resources.big_gun;            

            jugador.cargarTablaDialogos();
            oponente.cargarTablaDialogos();


            

        }

        public void iniciar()
        {

           


            barraAccion.imagenJugador.BackgroundImage = Properties.Resources.HombreSerio;
            barraAccion.imagenOponente.BackgroundImage = Properties.Resources.MujerFeliz;
            barraAccion.disparar.Show();
            barraAccion.ejeX.Show();
            barraAccion.ejeY.Show();
            barraAccion.vidaJugador.Value = 100;
            barraAccion.vidaOponente.Value = 100;
            barraAccion.nombreJugador.Text = jugador.nombre;
            barraAccion.nombreOponente.Text = oponente.nombre;
            barraAccion.agregarEventoBotonDisparo();
            barraAccion.ejeX.Maximum = mapaJuego.zonaOponente.Width;
            barraAccion.ejeY.Maximum = mapaJuego.zonaOponente.Height;
            barraAccion.ejeX.Minimum = 0;
            barraAccion.ejeY.Minimum = 0;

            canon.canon.BackgroundImage = canon.imagen;

            oponente.cargarEventoTimer();
            oponente.contador.Interval = 4000;          
                   
                      
            mapaJuego.indicadorTurno.Visible = true;
            mapaJuego.indicadorTiempo.Visible = true;
            mapaJuego.agregarEventos();
            mapaJuego.zonaJugador.Enabled = false;
            mapaJuego.contador.Interval = 1000;
            mapaJuego.contador.Start();
            mapaJuego.listaBarcosJugador = mapaJuego.zonaJugador.Controls.OfType<Barco>();
            mapaJuego.listaBarcosOponente = mapaJuego.zonaOponente.Controls.OfType<Barco>();
            mapaJuego.indicadorTiempo.Text = "15";
            cambioTurno(Color.LightGreen, "Turno jugador");

        }

   



        public async void cargarBarcosJugador()
        {


            Random r1 = new Random();


            int x;
            int y;

            for (int A = 0; A < cantidadBarcos; A++)
            {
                Barco b = new Barco();

                x = r1.Next(mapaJuego.zonaJugador.Width-b.Width);
                y = r1.Next(mapaJuego.zonaJugador.Height-b.Height);


                b.Width = 35;
                b.Height = 35;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.imagenBarco = Properties.Resources.barcoJugador;
                b.barcoDestruido = Properties.Resources.barcoJugadorDestruido;
                b.BackgroundImage = b.imagenBarco;
                b.Location = new Point(x, y);
                b.agregarEventosDrag();
                b.id = "Jugador";

                await Task.Delay(200);

                mapaJuego.zonaJugador.Controls.Add(b);
             
            }

        }

        public async void cargarBarcosOponente()
        {


            Random r2 = new Random();


            int x;
            int y;

            for (int A = 0; A < cantidadBarcos; A++)
            {
                Barco b = new Barco();

                x = r2.Next(mapaJuego.zonaOponente.Width-b.Width);
                y = r2.Next(mapaJuego.zonaOponente.Height-b.Height);

                b.Width = 35;
                b.Height = 35;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.imagenBarco = Properties.Resources.barcoOponente;
                b.barcoDestruido = Properties.Resources.barcoOponenteDestruido;                
                b.Location = new Point(x, y);  
                b.id = "Oponente";
                b.Hide();

                await Task.Delay(200);

                mapaJuego.zonaOponente.Controls.Add(b);
              
            }

        }


        public static void deshabilitarControles()
        {

            turnoJugador = false;
            barraAccion.disparar.Enabled = false;

        }


        public static void habilitarControles()
        {

            turnoJugador = true;
            barraAccion.disparar.Enabled = true;


        }


        public static void cambioTurno(Color c, string msn)
        {

            mapaJuego.indicadorTurno.ForeColor = c;
            mapaJuego.indicadorTurno.Text = msn;

        }

        public static void estadoJuego(string msn)
        {

            mapaJuego.zonaJugador.Enabled = false;
            mapaJuego.zonaOponente.Enabled = false;
            mapaJuego.contador.Stop();
            oponente.contador.Stop();

            switch (msn)
            {

                case "Perder":

                    cambioTurno(Color.Red, "Perdistes!");

                    break;
                case "Ganar":

                    cambioTurno(Color.LightGreen, "Ganastes!");

                    break;
                default:
                    cambioTurno(Color.Red, "ERROR");
                    break;

            }

            


        }


      

    }
}
