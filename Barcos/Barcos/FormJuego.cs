using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Barcos
{
    public partial class FormJuego : Form
    {

        private Juego juego;

        public static Panel objZonaJugador;
        public static Panel objZonaOponente;        
        public static PictureBox objZonaCanon;
        public static PictureBox objFotoJugador;
        public static PictureBox objFotoOponente;
        public static ProgressBar objVidaJugador;
        public static ProgressBar objVidaOponente;        
        public static Label objZonaDialogo;
        public static Label objEtiqTiempo;
        public static Label objEtiqEjeX;
        public static Label objEtiqEjeY;
        public static Label objEtiNomJugador;
        public static Label objEtiNomOponente;
        public static Label objEtiTurno;
        public static Button objBotonDisparo;
        public static NumericUpDown objEjeX;
        public static NumericUpDown objEjeY;

        public FormJuego()
        {
            InitializeComponent();


            juego = new Juego();


            objZonaJugador = pJugador;
            objZonaOponente = pOponente;
            objZonaCanon = pbCanon;
            objFotoJugador = pbJugador;
            objFotoOponente = pbOponente;
            objVidaJugador = pbVidaJugador;
            objVidaOponente = pbVidaOponente;            
            objZonaDialogo = lbTextoPj;
            objEtiqTiempo = lbTiempo;
            objEtiqEjeX = lbEjeX;
            objEtiqEjeY = lbEjeY;
            objBotonDisparo = btnDisparar;
            objEjeX = nudX;
            objEjeY = nudY;
            objEtiNomJugador = lbNombreJugador;
            objEtiNomOponente = lbNombreOponente;
            objEtiTurno = lbTurnoQuien;

            juego.cargar();

          
        }




        private  void Form1_Load(object sender, EventArgs e)
        {

            Bitmap img = new Bitmap(Properties.Resources.punteroDisparo);
            
            Graphics g = Graphics.FromImage(img);
           
            IntPtr ptr = img.GetHicon();
            Cursor = new Cursor(ptr);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            juego.iniciar();

           
            
            lbEjeX.Show();
            lbEjeY.Show();

            btnCargarBarcos.Hide();

            btnIniciar.Hide();

            
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            btnIniciar.Show();

            juego.cargarBarcosJugador();
            juego.cargarBarcosOponente();

           
            
        }

        private void btnTrampa_Click(object sender, EventArgs e)
        {
            string coordenadasBarcos = "Coordenadas barcos enemigos\n";
            
                
            try
            {

                var bar = from b in Juego.mapaJuego.listaBarcosOponente
                          where b.destruido == false
                          select b;


                foreach (var item in bar)
                {

                    coordenadasBarcos += item.Location.ToString() + "\n";

                }

                MessageBox.Show(coordenadasBarcos);
            }
            catch 
            {
                MessageBox.Show("Aun no ha iniciado la partida!");
               
            }
            

            

        }

      
    }
}
