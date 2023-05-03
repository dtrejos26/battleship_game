using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Barcos
{
    public class Jugador
    {

        public string nombre { get; set; }
        public  int vida { get; set; }        
        public Hashtable dialogos { get; set; }
 
        public Jugador()
        {

            nombre = "Danny";
            vida = 100;
            dialogos = new Hashtable();
 

        }

        public int quitarVida(int valor)
        {


            vida -= valor;

            if(vida < 0)
            {

                vida = 0;
            }

            return vida;

        }


        public void cargarTablaDialogos()
        {

            // LISTA PARA DIALOGO SERIO

            List<string> serioL = new List<string> { "Esto es demasiado facil...", "Espero que sea una buena partida... señorita, jajaja!", "..." };
            Dialogo serioD = new Dialogo(serioL, Properties.Resources.HombreSerio);
            dialogos.Add("Serio", serioD);


            // LISTA PARA DIALOGO ENOJADO

            List<string> enojadoL = new List<string> { "IMPOSIBLE...", "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO!", "MALDITA SEAS, ESTO NO SE QUEDARA ASI!" };
            Dialogo enojadoD = new Dialogo(enojadoL, Properties.Resources.HombreEnojado);
            dialogos.Add("Enojado", enojadoD);


            // LISTA PARA DIALOGO EXITADO

            List<string> exitadoL = new List<string> { "BAHJAJAJAJAJA, das lastima!", "Eres demasiado mala! jajajaja!", "Por lo visto voy a ganar muy rapido. " };
            Dialogo exitadoD = new Dialogo(exitadoL, Properties.Resources.HombreExitado);
            dialogos.Add("Exitado", exitadoD);


            // LISTA PARA DIALOGO PREOCUPADO


            List<string> preocupadoL = new List<string> { "No, no, nooo, NO PUEDE SER VERDAD.", "Debes estar haciendo trampa...", "PE-PE-PERO COMO LO HICISTES!?" };
            Dialogo preocupadoD = new Dialogo(preocupadoL, Properties.Resources.HombrePreocupado);
            dialogos.Add("Preocupado", preocupadoD);


        }



        public bool atacar(Canon canon, IEnumerable<Barco> listaBarcos,Panel p, int x, int y)
        {

            
            if(x <= p.Width && y<= p.Height)
            {

                

                return canon.disparar(x, y, listaBarcos, p);

            }
            else
            {

                MessageBox.Show("Las coordenadas no son correctas!");

                return false;

            }

        }

    }
}
